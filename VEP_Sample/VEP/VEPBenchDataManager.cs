using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KI_VEP
{
	public class VEPBenchDataManager
	{
		private VEPBenchClient _parent;

		public VEPBenchDescriptionZone DescriptionZone { get; private set; }
		public VEPBenchReceptionZone ReceptionZone { get; private set; }
		public VEPBenchStatusZone StatusZone { get; private set; }
		public VEPBenchSynchroZone SynchroZone { get; internal set; }
		public VEPBenchTransmissionZone TransmissionZone { get; private set; }

		public VEPBenchAddTransmissionZone AddTransmissionZone { get; internal set; }



		public void SetParent(VEPBenchClient parent) { _parent = parent; }

		public VEPBenchDataManager()
		{
			DescriptionZone = new VEPBenchDescriptionZone();
			ReceptionZone = VEPBenchReceptionZone.Instance;
			StatusZone = VEPBenchStatusZone.Instance;
			SynchroZone = VEPBenchSynchroZone.Instance;
			TransmissionZone = VEPBenchTransmissionZone.Instance;
			AddTransmissionZone = VEPBenchAddTransmissionZone.Instance;


		}


		public void UpdateAllZonesFromRegisters(Func<int, int, ushort[]> readRegistersFunc)
		{
			StatusZone.FromRegisters(readRegistersFunc(DescriptionZone.StatusZoneAddr, DescriptionZone.StatusZoneSize));

			ushort[] synchroZone = readRegistersFunc(DescriptionZone.SynchroZoneAddr, DescriptionZone.SynchroZoneSize);
			SynchroZone.FromRegisters(synchroZone);

			ushort[] tzZone = readRegistersFunc(DescriptionZone.TransmissionZoneAddr, DescriptionZone.TransmissionZoneSize);
			TransmissionZone.FromRegisters(tzZone);


			ReceptionZone.FromRegisters(readRegistersFunc(DescriptionZone.ReceptionZoneAddr, DescriptionZone.ReceptionZoneSize));

		}

		public void ReadTransmissionZonesFromRegisters(Func<int, int, ushort[]> readRegistersFunc)
		{
			AddTransmissionZone.FromRegisters(readRegistersFunc(DescriptionZone.AdditionalTZAddr, DescriptionZone.AdditionalTZSize));
		}

		public void WriteAllZonesToRegisters(Action<int, ushort[]> writeRegistersFunc)
		{
			writeRegistersFunc(DescriptionZone.StatusZoneAddr, StatusZone.ToRegisters());

			ushort[] synchroRegisters = SynchroZone.ToRegisters();
			writeRegistersFunc(DescriptionZone.SynchroZoneAddr, synchroRegisters);
			writeRegistersFunc(DescriptionZone.TransmissionZoneAddr, TransmissionZone.ToRegisters());
		}




		public int GetVEPStatus()
		{
			return StatusZone.GetValue(0);
		}
		public bool IsExchange()
		{
			int nTZEx1 = TransmissionZone.GetValue(3);
			int nRZEx2 = ReceptionZone.GetValue(3);

			if (nTZEx1 != 1) return false;
			if (nRZEx2 != 1) return false;
			return true;
		}
		public void SetRZExchange(int nTZEx1)
		{
			_parent.WriteReceptionZone((ushort)3, (ushort)nTZEx1);
		}
		public void SetTZExchange(int nTZEx1)
		{
			_parent.WriteTransmissionZone((ushort)3, (ushort)nTZEx1);
		}

		public bool IsSyncroZero()
		{
			bool bZero = true;
			int nSize = DescriptionZone.SynchroZoneSize;
			for (int i = 0; i < nSize; i++)
			{

				if (SynchroZone.GetValue(i) != 0) bZero = false;
			}
			return bZero;
		}



		public int StartCycle()
		{
			int nRet = 0;
			_parent.WriteStatusZone((ushort)5, 1);
			return nRet;
		}
		public int BenchCycleEnd()
		{
			int nRet = 0;
			_parent.WriteStatusZone((ushort)4, 1);
			return nRet;
		}
		public int BenchCycleBrake()
		{
			int nRet = 0;
			_parent.WriteStatusZone((ushort)3, 1);
			return nRet;
		}

		public int SetSyncroZero()
		{
			int nSize = DescriptionZone.SynchroZoneSize;
			for (int i = 0; i < nSize; i++)
			{

				SynchroZone.SetValue(i, 0);
				_parent.WriteSynchroZone();
			}
			return 0;
		}
		public bool IsOPMsgAnsi()
		{
			if (TransmissionZone.FctCode == 20 &&
				TransmissionZone.PCNum == 1 &&
				(TransmissionZone.ProcessCode == 1 || TransmissionZone.ProcessCode == 2) &&
				TransmissionZone.SubFctCode == 2)
			{
				return true;
			}
			return false;
		}
		public bool IsOPMsgUnicode()
		{
			if (TransmissionZone.FctCode == 21 &&
				TransmissionZone.PCNum == 1 &&
				TransmissionZone.ProcessCode == 1 &&
				TransmissionZone.SubFctCode == 2)
			{
				return true;
			}
			return false;
		}
		public String GetOPMessageAnsi()
		{
			// OPMessage는 최대 크기가 20을 넘지 않는다. (도큐먼트참조)
			//TZ_Addr + 12    Data[0]	Low Byte    14 : Length
			//							High Byte   84(ANSI code “T”)
			//TZ_Addr + 13    Data[1]	Low Byte    72(ANSI code “H”)
			//							High Byte   73(ANSI code “I”)
			//TZ_Addr + 14    Data[2]	Low Byte    83(ANSI code “S”)
			//							High Byte   32(ANSI code “_”)
			//TZ_Addr + 15    Data[3]	Low Byte    73(ANSI code “I”)
			//							High Byte   83(ANSI code “S”)
			//TZ_Addr + 16    Data[4]	Low Byte    32(ANSI code “_”)
			//							High Byte   65(ANSI code “A”)
			//TZ_Addr + 17    Data[5]	Low Byte    32(ANSI code “_”)
			//							High Byte   84(ANSI code “T”)
			//TZ_Addr + 18    Data[6]	Low Byte    69(ANSI code “E”)
			//							High Byte   83(ANSI code “S”)
			//TZ_Addr + 19    Data[7]	Low Byte    84(ANSI code “T”)
			//							High Byte   0

			if (TransmissionZone.FctCode == 20 &&
				TransmissionZone.PCNum == 1 &&
				TransmissionZone.ProcessCode == 1 &&
				TransmissionZone.SubFctCode == 2)
			{

				return TransmissionZone.DataString;
			}
			else
			{
				String str = "";
				return str;
			}
		}
		public String GetTransmissionData()
		{
			return TransmissionZone.DataString; ;
		}



		public bool IsRequestPJI()
		{
			bool bRequest = false;

			if (ReceptionZone.AddReSize == 0 &&
				ReceptionZone.FctCode == 6 &&
				ReceptionZone.PCNum == 1 &&
				ReceptionZone.ProcessCode == 1 &&
				ReceptionZone.SubFctCode == 0
			)
			{
				bRequest = true;
			}

			return bRequest;
		}
		public int SendPJI(String strPJI)
		{
			//if (modClient.Connected == false) return -1;

			int nSize = DescriptionZone.ReceptionZoneSize;


			//RZ_Addr + 2 AddReSize		WORD	   0
			//RZ_Addr + 6 FctCode		Low Byte    6
			//			PCNum			High Byte   1
			//RZ_Addr + 8 ProcessCode	Low Byte    1
			//			SubFctCode		High Byte   0
			//RZ_Addr + 12    Data[0]	Low Byte    1
			//							High Byte   7

			ReceptionZone.AddReSize = 0;
			ReceptionZone.FctCode = 6;
			ReceptionZone.PCNum = 1;
			ReceptionZone.ProcessCode = 1;
			ReceptionZone.SubFctCode = 0;

			String strSendPJI = strPJI;
			int nLen = strSendPJI.Length;
			//RZ_Addr + 12    Data[0]	Low Byte    1
			//							High Byte   7
			//High Byte에 Size를 넣어야 함.
			{
				byte cLow = 1;
				byte cHigh = (byte)nLen;
				ReceptionZone.SetWord(12, cHigh, cLow);
			}



			if (nLen % 2 != 0) strSendPJI = strSendPJI + "0";
			// 문자열을 2개씩 짝지어서 WORD 배열에 넣기
			int nStartPJI = 13;
			for (int i = 0; i < strSendPJI.Length / 2; i++)
			{
				byte cLow = (byte)strSendPJI[i * 2];     // 앞 글자
				byte cHigh = (byte)strSendPJI[i * 2 + 1];  // 뒷 글자
				ReceptionZone.SetWord(nStartPJI + i, cHigh, cLow);
				//_GV.vepData.SetValue(pjiIndex + i, (ushort)((high << 8) | low));
			}

			_parent.WriteReceptionZone();

			return 1;
		}

	}
}
