using System;
using System.Collections.Generic;
using System.Linq;
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

			ReceptionZone.AddReSize = 0;
			ReceptionZone.FctCode = 6;
			ReceptionZone.PCNum = 1;
			ReceptionZone.ProcessCode = 1;
			ReceptionZone.SubFctCode = 0;

			String strSendPJI = strPJI;
			int nLen = strSendPJI.Length;
			//RZ_Addr + 12    Data[0]	Low Byte    1
			//							High Byte   7
			//High Byte�� Size�� �־�� ��.
			{
				byte cLow = 1;
				byte cHigh = (byte)nLen;
				ReceptionZone.SetWord(12, cHigh, cLow);
			}



			if (nLen % 2 != 0) strSendPJI = strSendPJI + "0";
			// ���ڿ��� 2���� ¦��� WORD �迭�� �ֱ�
			int nStartPJI = 13;
			for (int i = 0; i < strSendPJI.Length / 2; i++)
			{
				byte cLow = (byte)strSendPJI[i * 2];     // �� ����
				byte cHigh = (byte)strSendPJI[i * 2 + 1];  // �� ����
				ReceptionZone.SetWord(nStartPJI + i, cHigh, cLow);
				//_GV.vepData.SetValue(pjiIndex + i, (ushort)((high << 8) | low));
			}

			_parent.WriteReceptionZone();

			return 1;
		}

	}
}
