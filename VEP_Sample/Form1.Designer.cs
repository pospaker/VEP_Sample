namespace VEP_Sample
{
    partial class Frm_VEP
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Test = new System.Windows.Forms.Button();
            this.txtReExchStatus = new System.Windows.Forms.TextBox();
            this.txtReFctCode = new System.Windows.Forms.TextBox();
            this.txtRePCNum = new System.Windows.Forms.TextBox();
            this.txtReProcessCode = new System.Windows.Forms.TextBox();
            this.txtReSubFctCode = new System.Windows.Forms.TextBox();
            this.cmbValueList = new System.Windows.Forms.ComboBox();
            this.btnEditValue = new System.Windows.Forms.Button();
            this.txtEditValue = new System.Windows.Forms.TextBox();
            this.txtAddrReSize = new System.Windows.Forms.TextBox();
            this.txtAddrTzSize = new System.Windows.Forms.TextBox();
            this.txtTzExchStatus = new System.Windows.Forms.TextBox();
            this.txtTzFctCode = new System.Windows.Forms.TextBox();
            this.txtTzPCNum = new System.Windows.Forms.TextBox();
            this.txtTzProcessCode = new System.Windows.Forms.TextBox();
            this.txtTzSubFctCode = new System.Windows.Forms.TextBox();
            this.txtStVepStatus = new System.Windows.Forms.TextBox();
            this.txtStVepCycleInt = new System.Windows.Forms.TextBox();
            this.txtStVepCycleEnd = new System.Windows.Forms.TextBox();
            this.txtStBenchCycleInt = new System.Windows.Forms.TextBox();
            this.txtStBenchCycleEnd = new System.Windows.Forms.TextBox();
            this.txtStStartCycle = new System.Windows.Forms.TextBox();
            this.txtAddTzSize = new System.Windows.Forms.TextBox();
            this.txtAddReAddress = new System.Windows.Forms.TextBox();
            this.txtAddReSize = new System.Windows.Forms.TextBox();
            this.txtStatusZoneAddress = new System.Windows.Forms.TextBox();
            this.txtStatusZoneSize = new System.Windows.Forms.TextBox();
            this.txtSynchroZoneAddress = new System.Windows.Forms.TextBox();
            this.txtTzAddress = new System.Windows.Forms.TextBox();
            this.txtTzSize = new System.Windows.Forms.TextBox();
            this.txtReAddress = new System.Windows.Forms.TextBox();
            this.txtReSize = new System.Windows.Forms.TextBox();
            this.txtAddTzAddress = new System.Windows.Forms.TextBox();
            this.txtSynchroZoneSize = new System.Windows.Forms.TextBox();
            this.txtDesZone = new System.Windows.Forms.TextBox();
            this.List_Sync = new System.Windows.Forms.ListView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label45 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Test
            // 
            this.bt_Test.Location = new System.Drawing.Point(547, 604);
            this.bt_Test.Name = "bt_Test";
            this.bt_Test.Size = new System.Drawing.Size(84, 54);
            this.bt_Test.TabIndex = 429;
            this.bt_Test.Text = "Etat";
            this.bt_Test.UseVisualStyleBackColor = true;
            this.bt_Test.Click += new System.EventHandler(this.bt_Test_Click);
            // 
            // txtReExchStatus
            // 
            this.txtReExchStatus.Location = new System.Drawing.Point(1121, 608);
            this.txtReExchStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReExchStatus.Multiline = true;
            this.txtReExchStatus.Name = "txtReExchStatus";
            this.txtReExchStatus.ReadOnly = true;
            this.txtReExchStatus.Size = new System.Drawing.Size(191, 20);
            this.txtReExchStatus.TabIndex = 428;
            // 
            // txtReFctCode
            // 
            this.txtReFctCode.Location = new System.Drawing.Point(1121, 639);
            this.txtReFctCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReFctCode.Multiline = true;
            this.txtReFctCode.Name = "txtReFctCode";
            this.txtReFctCode.ReadOnly = true;
            this.txtReFctCode.Size = new System.Drawing.Size(191, 20);
            this.txtReFctCode.TabIndex = 427;
            // 
            // txtRePCNum
            // 
            this.txtRePCNum.Location = new System.Drawing.Point(1121, 673);
            this.txtRePCNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRePCNum.Multiline = true;
            this.txtRePCNum.Name = "txtRePCNum";
            this.txtRePCNum.ReadOnly = true;
            this.txtRePCNum.Size = new System.Drawing.Size(191, 20);
            this.txtRePCNum.TabIndex = 426;
            // 
            // txtReProcessCode
            // 
            this.txtReProcessCode.Location = new System.Drawing.Point(1121, 705);
            this.txtReProcessCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReProcessCode.Multiline = true;
            this.txtReProcessCode.Name = "txtReProcessCode";
            this.txtReProcessCode.ReadOnly = true;
            this.txtReProcessCode.Size = new System.Drawing.Size(191, 20);
            this.txtReProcessCode.TabIndex = 425;
            // 
            // txtReSubFctCode
            // 
            this.txtReSubFctCode.Location = new System.Drawing.Point(1121, 739);
            this.txtReSubFctCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReSubFctCode.Multiline = true;
            this.txtReSubFctCode.Name = "txtReSubFctCode";
            this.txtReSubFctCode.ReadOnly = true;
            this.txtReSubFctCode.Size = new System.Drawing.Size(191, 20);
            this.txtReSubFctCode.TabIndex = 424;
            // 
            // cmbValueList
            // 
            this.cmbValueList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbValueList.FormattingEnabled = true;
            this.cmbValueList.Location = new System.Drawing.Point(23, 31);
            this.cmbValueList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbValueList.Name = "cmbValueList";
            this.cmbValueList.Size = new System.Drawing.Size(154, 24);
            this.cmbValueList.TabIndex = 262;
            // 
            // btnEditValue
            // 
            this.btnEditValue.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditValue.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEditValue.Location = new System.Drawing.Point(194, 33);
            this.btnEditValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditValue.Name = "btnEditValue";
            this.btnEditValue.Size = new System.Drawing.Size(81, 49);
            this.btnEditValue.TabIndex = 15;
            this.btnEditValue.Text = "Edit";
            this.btnEditValue.UseVisualStyleBackColor = false;
            this.btnEditValue.Click += new System.EventHandler(this.btnEditValue_Click);
            // 
            // txtEditValue
            // 
            this.txtEditValue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEditValue.Location = new System.Drawing.Point(23, 59);
            this.txtEditValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditValue.Name = "txtEditValue";
            this.txtEditValue.Size = new System.Drawing.Size(154, 26);
            this.txtEditValue.TabIndex = 263;
            // 
            // txtAddrReSize
            // 
            this.txtAddrReSize.Location = new System.Drawing.Point(1121, 576);
            this.txtAddrReSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddrReSize.Multiline = true;
            this.txtAddrReSize.Name = "txtAddrReSize";
            this.txtAddrReSize.ReadOnly = true;
            this.txtAddrReSize.Size = new System.Drawing.Size(191, 20);
            this.txtAddrReSize.TabIndex = 423;
            // 
            // txtAddrTzSize
            // 
            this.txtAddrTzSize.Location = new System.Drawing.Point(341, 578);
            this.txtAddrTzSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddrTzSize.Multiline = true;
            this.txtAddrTzSize.Name = "txtAddrTzSize";
            this.txtAddrTzSize.ReadOnly = true;
            this.txtAddrTzSize.Size = new System.Drawing.Size(191, 20);
            this.txtAddrTzSize.TabIndex = 422;
            // 
            // txtTzExchStatus
            // 
            this.txtTzExchStatus.Location = new System.Drawing.Point(341, 610);
            this.txtTzExchStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTzExchStatus.Multiline = true;
            this.txtTzExchStatus.Name = "txtTzExchStatus";
            this.txtTzExchStatus.ReadOnly = true;
            this.txtTzExchStatus.Size = new System.Drawing.Size(191, 20);
            this.txtTzExchStatus.TabIndex = 421;
            // 
            // txtTzFctCode
            // 
            this.txtTzFctCode.Location = new System.Drawing.Point(341, 645);
            this.txtTzFctCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTzFctCode.Multiline = true;
            this.txtTzFctCode.Name = "txtTzFctCode";
            this.txtTzFctCode.ReadOnly = true;
            this.txtTzFctCode.Size = new System.Drawing.Size(191, 20);
            this.txtTzFctCode.TabIndex = 420;
            // 
            // txtTzPCNum
            // 
            this.txtTzPCNum.Location = new System.Drawing.Point(341, 679);
            this.txtTzPCNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTzPCNum.Multiline = true;
            this.txtTzPCNum.Name = "txtTzPCNum";
            this.txtTzPCNum.ReadOnly = true;
            this.txtTzPCNum.Size = new System.Drawing.Size(191, 20);
            this.txtTzPCNum.TabIndex = 419;
            // 
            // txtTzProcessCode
            // 
            this.txtTzProcessCode.Location = new System.Drawing.Point(341, 711);
            this.txtTzProcessCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTzProcessCode.Multiline = true;
            this.txtTzProcessCode.Name = "txtTzProcessCode";
            this.txtTzProcessCode.ReadOnly = true;
            this.txtTzProcessCode.Size = new System.Drawing.Size(191, 20);
            this.txtTzProcessCode.TabIndex = 418;
            // 
            // txtTzSubFctCode
            // 
            this.txtTzSubFctCode.Location = new System.Drawing.Point(341, 745);
            this.txtTzSubFctCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTzSubFctCode.Multiline = true;
            this.txtTzSubFctCode.Name = "txtTzSubFctCode";
            this.txtTzSubFctCode.ReadOnly = true;
            this.txtTzSubFctCode.Size = new System.Drawing.Size(191, 20);
            this.txtTzSubFctCode.TabIndex = 417;
            // 
            // txtStVepStatus
            // 
            this.txtStVepStatus.Location = new System.Drawing.Point(637, 51);
            this.txtStVepStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStVepStatus.Multiline = true;
            this.txtStVepStatus.Name = "txtStVepStatus";
            this.txtStVepStatus.ReadOnly = true;
            this.txtStVepStatus.Size = new System.Drawing.Size(134, 20);
            this.txtStVepStatus.TabIndex = 416;
            // 
            // txtStVepCycleInt
            // 
            this.txtStVepCycleInt.Location = new System.Drawing.Point(637, 87);
            this.txtStVepCycleInt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStVepCycleInt.Multiline = true;
            this.txtStVepCycleInt.Name = "txtStVepCycleInt";
            this.txtStVepCycleInt.ReadOnly = true;
            this.txtStVepCycleInt.Size = new System.Drawing.Size(134, 20);
            this.txtStVepCycleInt.TabIndex = 415;
            // 
            // txtStVepCycleEnd
            // 
            this.txtStVepCycleEnd.Location = new System.Drawing.Point(637, 120);
            this.txtStVepCycleEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStVepCycleEnd.Multiline = true;
            this.txtStVepCycleEnd.Name = "txtStVepCycleEnd";
            this.txtStVepCycleEnd.ReadOnly = true;
            this.txtStVepCycleEnd.Size = new System.Drawing.Size(134, 20);
            this.txtStVepCycleEnd.TabIndex = 414;
            // 
            // txtStBenchCycleInt
            // 
            this.txtStBenchCycleInt.Location = new System.Drawing.Point(637, 158);
            this.txtStBenchCycleInt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStBenchCycleInt.Multiline = true;
            this.txtStBenchCycleInt.Name = "txtStBenchCycleInt";
            this.txtStBenchCycleInt.ReadOnly = true;
            this.txtStBenchCycleInt.Size = new System.Drawing.Size(134, 20);
            this.txtStBenchCycleInt.TabIndex = 413;
            // 
            // txtStBenchCycleEnd
            // 
            this.txtStBenchCycleEnd.Location = new System.Drawing.Point(637, 191);
            this.txtStBenchCycleEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStBenchCycleEnd.Multiline = true;
            this.txtStBenchCycleEnd.Name = "txtStBenchCycleEnd";
            this.txtStBenchCycleEnd.ReadOnly = true;
            this.txtStBenchCycleEnd.Size = new System.Drawing.Size(134, 20);
            this.txtStBenchCycleEnd.TabIndex = 412;
            // 
            // txtStStartCycle
            // 
            this.txtStStartCycle.Location = new System.Drawing.Point(637, 228);
            this.txtStStartCycle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStStartCycle.Multiline = true;
            this.txtStStartCycle.Name = "txtStStartCycle";
            this.txtStStartCycle.ReadOnly = true;
            this.txtStStartCycle.Size = new System.Drawing.Size(134, 20);
            this.txtStStartCycle.TabIndex = 411;
            // 
            // txtAddTzSize
            // 
            this.txtAddTzSize.Location = new System.Drawing.Point(277, 413);
            this.txtAddTzSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddTzSize.Multiline = true;
            this.txtAddTzSize.Name = "txtAddTzSize";
            this.txtAddTzSize.ReadOnly = true;
            this.txtAddTzSize.Size = new System.Drawing.Size(106, 20);
            this.txtAddTzSize.TabIndex = 410;
            // 
            // txtAddReAddress
            // 
            this.txtAddReAddress.Location = new System.Drawing.Point(278, 451);
            this.txtAddReAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddReAddress.Multiline = true;
            this.txtAddReAddress.Name = "txtAddReAddress";
            this.txtAddReAddress.ReadOnly = true;
            this.txtAddReAddress.Size = new System.Drawing.Size(106, 20);
            this.txtAddReAddress.TabIndex = 409;
            // 
            // txtAddReSize
            // 
            this.txtAddReSize.Location = new System.Drawing.Point(278, 493);
            this.txtAddReSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddReSize.Multiline = true;
            this.txtAddReSize.Name = "txtAddReSize";
            this.txtAddReSize.ReadOnly = true;
            this.txtAddReSize.Size = new System.Drawing.Size(106, 20);
            this.txtAddReSize.TabIndex = 408;
            // 
            // txtStatusZoneAddress
            // 
            this.txtStatusZoneAddress.Location = new System.Drawing.Point(278, 85);
            this.txtStatusZoneAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatusZoneAddress.Multiline = true;
            this.txtStatusZoneAddress.Name = "txtStatusZoneAddress";
            this.txtStatusZoneAddress.ReadOnly = true;
            this.txtStatusZoneAddress.Size = new System.Drawing.Size(106, 20);
            this.txtStatusZoneAddress.TabIndex = 407;
            // 
            // txtStatusZoneSize
            // 
            this.txtStatusZoneSize.Location = new System.Drawing.Point(278, 118);
            this.txtStatusZoneSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatusZoneSize.Multiline = true;
            this.txtStatusZoneSize.Name = "txtStatusZoneSize";
            this.txtStatusZoneSize.ReadOnly = true;
            this.txtStatusZoneSize.Size = new System.Drawing.Size(106, 20);
            this.txtStatusZoneSize.TabIndex = 406;
            // 
            // txtSynchroZoneAddress
            // 
            this.txtSynchroZoneAddress.Location = new System.Drawing.Point(278, 156);
            this.txtSynchroZoneAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSynchroZoneAddress.Multiline = true;
            this.txtSynchroZoneAddress.Name = "txtSynchroZoneAddress";
            this.txtSynchroZoneAddress.ReadOnly = true;
            this.txtSynchroZoneAddress.Size = new System.Drawing.Size(106, 20);
            this.txtSynchroZoneAddress.TabIndex = 405;
            // 
            // txtTzAddress
            // 
            this.txtTzAddress.Location = new System.Drawing.Point(278, 226);
            this.txtTzAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTzAddress.Multiline = true;
            this.txtTzAddress.Name = "txtTzAddress";
            this.txtTzAddress.ReadOnly = true;
            this.txtTzAddress.Size = new System.Drawing.Size(106, 20);
            this.txtTzAddress.TabIndex = 404;
            // 
            // txtTzSize
            // 
            this.txtTzSize.Location = new System.Drawing.Point(277, 263);
            this.txtTzSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTzSize.Multiline = true;
            this.txtTzSize.Name = "txtTzSize";
            this.txtTzSize.ReadOnly = true;
            this.txtTzSize.Size = new System.Drawing.Size(106, 20);
            this.txtTzSize.TabIndex = 403;
            // 
            // txtReAddress
            // 
            this.txtReAddress.Location = new System.Drawing.Point(277, 299);
            this.txtReAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReAddress.Multiline = true;
            this.txtReAddress.Name = "txtReAddress";
            this.txtReAddress.ReadOnly = true;
            this.txtReAddress.Size = new System.Drawing.Size(106, 20);
            this.txtReAddress.TabIndex = 402;
            // 
            // txtReSize
            // 
            this.txtReSize.Location = new System.Drawing.Point(277, 336);
            this.txtReSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReSize.Multiline = true;
            this.txtReSize.Name = "txtReSize";
            this.txtReSize.ReadOnly = true;
            this.txtReSize.Size = new System.Drawing.Size(106, 20);
            this.txtReSize.TabIndex = 401;
            // 
            // txtAddTzAddress
            // 
            this.txtAddTzAddress.Location = new System.Drawing.Point(278, 374);
            this.txtAddTzAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddTzAddress.Multiline = true;
            this.txtAddTzAddress.Name = "txtAddTzAddress";
            this.txtAddTzAddress.ReadOnly = true;
            this.txtAddTzAddress.Size = new System.Drawing.Size(106, 20);
            this.txtAddTzAddress.TabIndex = 400;
            // 
            // txtSynchroZoneSize
            // 
            this.txtSynchroZoneSize.Location = new System.Drawing.Point(278, 193);
            this.txtSynchroZoneSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSynchroZoneSize.Multiline = true;
            this.txtSynchroZoneSize.Name = "txtSynchroZoneSize";
            this.txtSynchroZoneSize.ReadOnly = true;
            this.txtSynchroZoneSize.Size = new System.Drawing.Size(106, 20);
            this.txtSynchroZoneSize.TabIndex = 399;
            // 
            // txtDesZone
            // 
            this.txtDesZone.Location = new System.Drawing.Point(278, 53);
            this.txtDesZone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesZone.Multiline = true;
            this.txtDesZone.Name = "txtDesZone";
            this.txtDesZone.ReadOnly = true;
            this.txtDesZone.Size = new System.Drawing.Size(106, 20);
            this.txtDesZone.TabIndex = 398;
            // 
            // List_Sync
            // 
            this.List_Sync.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.List_Sync.BackColor = System.Drawing.Color.SeaShell;
            this.List_Sync.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.List_Sync.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Sync.FullRowSelect = true;
            this.List_Sync.GridLines = true;
            this.List_Sync.HideSelection = false;
            this.List_Sync.Location = new System.Drawing.Point(794, 51);
            this.List_Sync.MultiSelect = false;
            this.List_Sync.Name = "List_Sync";
            this.List_Sync.Size = new System.Drawing.Size(350, 468);
            this.List_Sync.TabIndex = 397;
            this.List_Sync.UseCompatibleStateImageBehavior = false;
            this.List_Sync.View = System.Windows.Forms.View.Details;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbValueList);
            this.groupBox6.Controls.Add(this.btnEditValue);
            this.groupBox6.Controls.Add(this.txtEditValue);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(1162, 52);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(288, 124);
            this.groupBox6.TabIndex = 396;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Edit";
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.Location = new System.Drawing.Point(797, 771);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(306, 19);
            this.label45.TabIndex = 395;
            this.label45.Text = "ZoneInfo";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(788, 797);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(665, 52);
            this.richTextBox2.TabIndex = 394;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-10, 797);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(794, 52);
            this.richTextBox1.TabIndex = 393;
            this.richTextBox1.Text = "";
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label44.Location = new System.Drawing.Point(19, 771);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(306, 19);
            this.label44.TabIndex = 392;
            this.label44.Text = "ZoneInfo";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.Location = new System.Drawing.Point(793, 608);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(306, 19);
            this.label42.TabIndex = 391;
            this.label42.Text = "EtatEchange";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.Location = new System.Drawing.Point(793, 639);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(306, 19);
            this.label41.TabIndex = 390;
            this.label41.Text = "No FncDest (Low)";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.Location = new System.Drawing.Point(793, 673);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(306, 19);
            this.label40.TabIndex = 389;
            this.label40.Text = "NoPCmet (High)";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.Location = new System.Drawing.Point(793, 705);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(306, 19);
            this.label39.TabIndex = 388;
            this.label39.Text = "CodeTrait (Low)";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.Location = new System.Drawing.Point(793, 739);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(306, 19);
            this.label38.TabIndex = 387;
            this.label38.Text = "codeFonction (High)";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label43.Location = new System.Drawing.Point(793, 576);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(306, 19);
            this.label43.TabIndex = 386;
            this.label43.Text = "Size Zone Data";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.Location = new System.Drawing.Point(18, 576);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(306, 19);
            this.label37.TabIndex = 385;
            this.label37.Text = "Size Zone Data";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.Location = new System.Drawing.Point(17, 608);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(306, 19);
            this.label36.TabIndex = 384;
            this.label36.Text = "EtatEchange";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.Location = new System.Drawing.Point(17, 643);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(306, 19);
            this.label35.TabIndex = 383;
            this.label35.Text = "No FncDest (Low)";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.Location = new System.Drawing.Point(17, 677);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(306, 19);
            this.label34.TabIndex = 382;
            this.label34.Text = "NoPCFmet (High)";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.Location = new System.Drawing.Point(17, 709);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(306, 19);
            this.label33.TabIndex = 381;
            this.label33.Text = "CodeTrait (Low)";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.Location = new System.Drawing.Point(17, 743);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(306, 19);
            this.label32.TabIndex = 380;
            this.label32.Text = "CodeFonction (High)";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.Location = new System.Drawing.Point(397, 51);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(234, 19);
            this.label31.TabIndex = 379;
            this.label31.Text = "VEP Status";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(397, 87);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(234, 19);
            this.label30.TabIndex = 378;
            this.label30.Text = "VEP Cycle Interruption ";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.Location = new System.Drawing.Point(397, 120);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(234, 19);
            this.label29.TabIndex = 377;
            this.label29.Text = "VEP Cycle End";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(397, 158);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(234, 19);
            this.label28.TabIndex = 376;
            this.label28.Text = "Bench Cycle Interruption";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(397, 191);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(234, 19);
            this.label27.TabIndex = 375;
            this.label27.Text = "Bench Cycle End";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(397, 228);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(234, 19);
            this.label26.TabIndex = 374;
            this.label26.Text = "Cycle Start";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(1, 85);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(243, 19);
            this.label23.TabIndex = 373;
            this.label23.Text = "1 : Status zone address";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(1, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(243, 19);
            this.label22.TabIndex = 372;
            this.label22.Text = "2 : Status zone size";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(1, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(243, 19);
            this.label21.TabIndex = 371;
            this.label21.Text = "3 : Synchro zone address";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(1, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(243, 19);
            this.label20.TabIndex = 370;
            this.label20.Text = "10 :  Transmission zone address";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(1, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(243, 19);
            this.label19.TabIndex = 369;
            this.label19.Text = "11 : Transmission zone size";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(243, 19);
            this.label18.TabIndex = 368;
            this.label18.Text = "12 : Reception zone address";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(1, 336);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 19);
            this.label17.TabIndex = 367;
            this.label17.Text = "13 : Reception zone size";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(1, 374);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(243, 19);
            this.label16.TabIndex = 366;
            this.label16.Text = "14 : Add transmission zone address";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(1, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 19);
            this.label15.TabIndex = 365;
            this.label15.Text = "15 : Add transmission zone size";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(1, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 19);
            this.label14.TabIndex = 364;
            this.label14.Text = "16 : Add reception zone address";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(1, 489);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 19);
            this.label13.TabIndex = 363;
            this.label13.Text = "17 : Add reception zone size";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(1, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 19);
            this.label12.TabIndex = 362;
            this.label12.Text = "4 : Synchro zone size";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.LightGray;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(790, 524);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(668, 38);
            this.label25.TabIndex = 361;
            this.label25.Text = "Description of the reception zone";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.LightGray;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(7, 524);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(777, 38);
            this.label24.TabIndex = 360;
            this.label24.Text = "Description of the transmission zone";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(1, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 19);
            this.label11.TabIndex = 359;
            this.label11.Text = "0 : Description Zone";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 37);
            this.label8.TabIndex = 358;
            this.label8.Text = "Description zone";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("굴림", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(784, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(666, 37);
            this.label10.TabIndex = 357;
            this.label10.Text = "Synchro exchange zone";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(394, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 37);
            this.label9.TabIndex = 356;
            this.label9.Text = "Data status zone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 54);
            this.button1.TabIndex = 430;
            this.button1.Text = "cyclestart = 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 54);
            this.button2.TabIndex = 431;
            this.button2.Text = "cyclestart = 100";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_VEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 901);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Test);
            this.Controls.Add(this.txtReExchStatus);
            this.Controls.Add(this.txtReFctCode);
            this.Controls.Add(this.txtRePCNum);
            this.Controls.Add(this.txtReProcessCode);
            this.Controls.Add(this.txtReSubFctCode);
            this.Controls.Add(this.txtAddrReSize);
            this.Controls.Add(this.txtAddrTzSize);
            this.Controls.Add(this.txtTzExchStatus);
            this.Controls.Add(this.txtTzFctCode);
            this.Controls.Add(this.txtTzPCNum);
            this.Controls.Add(this.txtTzProcessCode);
            this.Controls.Add(this.txtTzSubFctCode);
            this.Controls.Add(this.txtStVepStatus);
            this.Controls.Add(this.txtStVepCycleInt);
            this.Controls.Add(this.txtStVepCycleEnd);
            this.Controls.Add(this.txtStBenchCycleInt);
            this.Controls.Add(this.txtStBenchCycleEnd);
            this.Controls.Add(this.txtStStartCycle);
            this.Controls.Add(this.txtAddTzSize);
            this.Controls.Add(this.txtAddReAddress);
            this.Controls.Add(this.txtAddReSize);
            this.Controls.Add(this.txtStatusZoneAddress);
            this.Controls.Add(this.txtStatusZoneSize);
            this.Controls.Add(this.txtSynchroZoneAddress);
            this.Controls.Add(this.txtTzAddress);
            this.Controls.Add(this.txtTzSize);
            this.Controls.Add(this.txtReAddress);
            this.Controls.Add(this.txtReSize);
            this.Controls.Add(this.txtAddTzAddress);
            this.Controls.Add(this.txtSynchroZoneSize);
            this.Controls.Add(this.txtDesZone);
            this.Controls.Add(this.List_Sync);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "Frm_VEP";
            this.Text = "Vep";
            this.Load += new System.EventHandler(this.Frm_VEP_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Test;
        private System.Windows.Forms.TextBox txtReExchStatus;
        private System.Windows.Forms.TextBox txtReFctCode;
        private System.Windows.Forms.TextBox txtRePCNum;
        private System.Windows.Forms.TextBox txtReProcessCode;
        private System.Windows.Forms.TextBox txtReSubFctCode;
        private System.Windows.Forms.ComboBox cmbValueList;
        private System.Windows.Forms.Button btnEditValue;
        private System.Windows.Forms.TextBox txtEditValue;
        private System.Windows.Forms.TextBox txtAddrReSize;
        private System.Windows.Forms.TextBox txtAddrTzSize;
        private System.Windows.Forms.TextBox txtTzExchStatus;
        private System.Windows.Forms.TextBox txtTzFctCode;
        private System.Windows.Forms.TextBox txtTzPCNum;
        private System.Windows.Forms.TextBox txtTzProcessCode;
        private System.Windows.Forms.TextBox txtTzSubFctCode;
        private System.Windows.Forms.TextBox txtStVepStatus;
        private System.Windows.Forms.TextBox txtStVepCycleInt;
        private System.Windows.Forms.TextBox txtStVepCycleEnd;
        private System.Windows.Forms.TextBox txtStBenchCycleInt;
        private System.Windows.Forms.TextBox txtStBenchCycleEnd;
        private System.Windows.Forms.TextBox txtStStartCycle;
        private System.Windows.Forms.TextBox txtAddTzSize;
        private System.Windows.Forms.TextBox txtAddReAddress;
        private System.Windows.Forms.TextBox txtAddReSize;
        private System.Windows.Forms.TextBox txtStatusZoneAddress;
        private System.Windows.Forms.TextBox txtStatusZoneSize;
        private System.Windows.Forms.TextBox txtSynchroZoneAddress;
        private System.Windows.Forms.TextBox txtTzAddress;
        private System.Windows.Forms.TextBox txtTzSize;
        private System.Windows.Forms.TextBox txtReAddress;
        private System.Windows.Forms.TextBox txtReSize;
        private System.Windows.Forms.TextBox txtAddTzAddress;
        private System.Windows.Forms.TextBox txtSynchroZoneSize;
        private System.Windows.Forms.TextBox txtDesZone;
        private System.Windows.Forms.ListView List_Sync;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

