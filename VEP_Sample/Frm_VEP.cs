using KI_VEP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VEP_Sample
{
    public partial class Frm_VEP : Form
    {

        
        private VEPBenchDataManager _VEP_Data = new VEPBenchDataManager();
        private VEPBenchClient _VEP;

        public Frm_VEP()
        {
            InitializeComponent();
        }

        private void Frm_VEP_Load(object sender, EventArgs e)
        {

            List_Sync.View = View.Details; // REPORT 모드
            List_Sync.FullRowSelect = true;
            List_Sync.GridLines = true;

            List_Sync.Columns.Clear();

            // 컬럼 추가
            List_Sync.Columns.Add("Non", 0);
            List_Sync.Columns.Add("Add", List_Sync.Width / 3 - 20, HorizontalAlignment.Center);
            List_Sync.Columns.Add("Sync", List_Sync.Width / 3 - 20, HorizontalAlignment.Center);


            List_Sync.Columns.Add("Val", List_Sync.Width / 3 + 15, HorizontalAlignment.Center);
            _VEP = new VEPBenchClient(_VEP_Data);
            _VEP.Connect("127.0.0.1", 502);
            _VEP.StartMonitoring();

            _VEP.DescriptionZoneRead += BenchClient_OnDescriptionZoneRead;
            _VEP.StatusZoneChanged += BenchClient_StatusZoneChanged;
            _VEP.SynchroZoneChanged += BenchClient_SynchroZoneChanged;
            _VEP.TransmissionZoneChanged += BenchClient_TransmissionZoneChanged;
            _VEP.ReceptionZoneChanged += BenchClient_ReceptionZoneChanged;
			


		}


        

        private void BenchClient_OnDescriptionZoneRead(object sender, VEPBenchDescriptionZone e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<object, VEPBenchDescriptionZone>(BenchClient_OnDescriptionZoneRead), sender, e);
                return;
            }

            txtDesZone.Text = e.ValidityIndicator.ToString();
            txtStatusZoneAddress.Text = e.StatusZoneAddr.ToString();
            txtStatusZoneSize.Text = e.StatusZoneSize.ToString();
            txtSynchroZoneAddress.Text = e.SynchroZoneAddr.ToString();
            txtSynchroZoneSize.Text = e.SynchroZoneSize.ToString();
            txtTzAddress.Text = e.TransmissionZoneAddr.ToString();
            txtTzSize.Text = e.TransmissionZoneSize.ToString();
            txtReAddress.Text = e.ReceptionZoneAddr.ToString();
            txtReSize.Text = e.ReceptionZoneSize.ToString();
            txtAddTzAddress.Text = e.AdditionalTZAddr.ToString();
            txtAddTzSize.Text = e.AdditionalTZSize.ToString();
            txtAddReAddress.Text = e.AdditionalRZAddr.ToString();
            txtAddReSize.Text = e.AdditionalRZSize.ToString();
        }
        private void BenchClient_StatusZoneChanged(object sender, VEPBenchStatusZone e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateStatusInfo(
                    e.VepStatus,
                    e.VepCycleEnd,
                    e.BenchCycleEnd,
                    e.StartCycle,
                    e.VepCycleInterruption,
                    e.BenchCycleInterruption)));
            }
            else
            {
                UpdateStatusInfo(
                    e.VepStatus,
                    e.VepCycleEnd,
                    e.BenchCycleEnd,
                    e.StartCycle,
                    e.VepCycleInterruption,
                    e.BenchCycleInterruption);
            }
        }
        public void UpdateStatusInfo(ushort vepStatus, ushort vepCycleEnd, ushort benchCycleEnd, ushort startCycle, ushort vepCycleInt, ushort benchCycleInt)
        {
            txtStVepStatus.Text = vepStatus.ToString();
            txtStVepCycleEnd.Text = vepCycleEnd.ToString();
            txtStBenchCycleEnd.Text = benchCycleEnd.ToString();
            txtStStartCycle.Text = startCycle.ToString();
            txtStVepCycleInt.Text = vepCycleInt.ToString();
            txtStBenchCycleInt.Text = benchCycleInt.ToString();
        }

        public void UpdateSynchroValues(ushort[] pSync)
        {
			if (List_Sync.Items.Count != pSync.Length)
			{
				List_Sync.Items.Clear();

				int nAdd = _VEP.Addr_SynchroZone;

				for (int ni = 0; ni < pSync.Length; ni++)
				{
					ListViewItem item = new ListViewItem("1");
					item.SubItems.Add(nAdd.ToString());
					item.SubItems.Add(ni.ToString());
					item.SubItems.Add("");
					List_Sync.Items.Add(item);
					nAdd++;
					cmbValueList.Items.Add("Sync : " + ni.ToString());
				}

			}
			if (List_Sync.Items.Count > 0)
            {
				cmbValueList.SelectedIndex = 0;
				for (int ni = 0; ni < pSync.Length; ni++)
                {
                    List_Sync.Items[ni].SubItems[3].Text = pSync[ni].ToString();
                }
            }
            
        }

        private void BenchClient_SynchroZoneChanged(object sender, VEPBenchSynchroZone e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateSynchroValues(e.ToRegisters())));

            }
            else
            {
                UpdateSynchroValues(e.ToRegisters());
            }
        }

        private void BenchClient_TransmissionZoneChanged(object sender, VEPBenchTransmissionZone e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateTransmissionInfo(e.AddTzSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode, e.DataString)));
            }
            else
            {
                UpdateTransmissionInfo(e.AddTzSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode, e.DataString);
            }

            if (e.IsRequest)
            {
                Console.WriteLine($"TransmissionZoneChanged 이벤트: 요청 감지 FctCode={e.FctCode}, PCNum={e.PCNum}");
            }
        }

        public void UpdateTransmissionInfo(ushort size, ushort exchStatus, byte fctCode, byte pcNum, byte processCode, byte subFctCode, String DataString)
        {
            txtAddrTzSize.Text = size.ToString();
            txtTzExchStatus.Text = exchStatus.ToString();
            txtTzFctCode.Text = fctCode.ToString();
            txtTzPCNum.Text = pcNum.ToString();
            txtTzProcessCode.Text = processCode.ToString();
            txtTzSubFctCode.Text = subFctCode.ToString();
			richTextBox1.Text = DataString;

		}

        public void UpdateReceptionInfo(ushort size, ushort exchStatus, byte fctCode, byte pcNum, byte processCode, byte subFctCode)
        {
            txtAddrReSize.Text = size.ToString();
            txtReExchStatus.Text = exchStatus.ToString();
            txtReFctCode.Text = fctCode.ToString();
            txtRePCNum.Text = pcNum.ToString();
            txtReProcessCode.Text = processCode.ToString();
            txtReSubFctCode.Text = subFctCode.ToString();
        }

        private void BenchClient_ReceptionZoneChanged(object sender, VEPBenchReceptionZone e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateReceptionInfo(e.AddReSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode)));
            }
            else
            {
                UpdateReceptionInfo(e.AddReSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode);
            }

            string status = e.IsResponseCompleted ? "응답 완료" : "응답 준비";
            Console.WriteLine($"ReceptionZoneChanged 이벤트: {status}, FctCode={e.FctCode}");
        }

        private void btnEditValue_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = cmbValueList.SelectedItem?.ToString();
                int nIndex = cmbValueList.SelectedIndex;
                if (string.IsNullOrEmpty(selectedItem))
                {
                    return;
                }

                if (!int.TryParse(txtEditValue.Text, out int valueToSet))
                {
                    MessageBox.Show("Enter a valid integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //_GV._VEP_Data.SynchroZone.SetValue(nIndex, (ushort)valueToSet);
                //_GV._VEP_Client.WriteSynchroZone();
                _VEP.WriteSyncroZone((ushort)nIndex, (ushort)valueToSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error modifying value: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Test_Click(object sender, EventArgs e)
        {
            _VEP.SetTzEtat(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _VEP_Data.StatusZone.StartCycle = 1;
            _VEP.WriteStatusZone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _VEP_Data.StatusZone.StartCycle = 100;
            _VEP.WriteStatusZone();
            
        }

		private void btnAddTransmission_Click(object sender, EventArgs e)
		{
			_VEP.ReadAddTransmissionZone();
			_VEP_Data.AddTransmissionZone.ShowData();

			
		}

		private void btnSendPJI_Click(object sender, EventArgs e)
		{
			String strPJI = "656252302943";
			_VEP_Data.SendPJI(strPJI);

		}

		private void btnSynchroTest_Click(object sender, EventArgs e)
		{
			int nSize = _VEP_Data.SynchroZone.Size;

			for (int i = 0; i < nSize; i++)
			{
				_VEP_Data.SynchroZone.SetValue(i, (ushort)(i + 1));

			}

			_VEP.WriteSynchroZone();
		}
	}
}
