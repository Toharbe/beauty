namespace BeautySalon
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblT = new System.Windows.Forms.Label();
            this.lblIDt = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.beautySalonDataSet = new BeautySalon.BeautySalonDataSet();
            this.queuesCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queuesCalendarTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.QueuesCalendarTableAdapter();
            this.tableAdapterManager = new BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.CustomersTableAdapter();
            this.therapistsTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.TherapistsTableAdapter();
            this.queuesCalendarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.queuesCalendarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.queuesCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNamet = new System.Windows.Forms.TextBox();
            this.txtIDt = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnfilterdate = new System.Windows.Forms.Button();
            this.lstP = new System.Windows.Forms.ListBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBDiary = new System.Windows.Forms.PictureBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.therapistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.therapistsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarBindingNavigator)).BeginInit();
            this.queuesCalendarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblT.Location = new System.Drawing.Point(115, 85);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(202, 25);
            this.lblT.TabIndex = 0;
            this.lblT.Text = "Therapist\'s Name:";
            // 
            // lblIDt
            // 
            this.lblIDt.AutoSize = true;
            this.lblIDt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIDt.Location = new System.Drawing.Point(594, 89);
            this.lblIDt.Name = "lblIDt";
            this.lblIDt.Size = new System.Drawing.Size(147, 25);
            this.lblIDt.TabIndex = 1;
            this.lblIDt.Text = "Therapist ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDate.Location = new System.Drawing.Point(34, 224);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblList.Location = new System.Drawing.Point(34, 630);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(138, 20);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "List Of Patients:";
            // 
            // beautySalonDataSet
            // 
            this.beautySalonDataSet.DataSetName = "BeautySalonDataSet";
            this.beautySalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queuesCalendarBindingSource
            // 
            this.queuesCalendarBindingSource.DataMember = "QueuesCalendar";
            this.queuesCalendarBindingSource.DataSource = this.beautySalonDataSet;
            // 
            // queuesCalendarTableAdapter
            // 
            this.queuesCalendarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.QueuesCalendarTableAdapter = this.queuesCalendarTableAdapter;
            this.tableAdapterManager.TherapistsTableAdapter = this.therapistsTableAdapter;
            this.tableAdapterManager.TreatmentTypeServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // therapistsTableAdapter
            // 
            this.therapistsTableAdapter.ClearBeforeFill = true;
            // 
            // queuesCalendarBindingNavigator
            // 
            this.queuesCalendarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.queuesCalendarBindingNavigator.BindingSource = this.queuesCalendarBindingSource;
            this.queuesCalendarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.queuesCalendarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.queuesCalendarBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.queuesCalendarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.queuesCalendarBindingNavigatorSaveItem});
            this.queuesCalendarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.queuesCalendarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.queuesCalendarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.queuesCalendarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.queuesCalendarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.queuesCalendarBindingNavigator.Name = "queuesCalendarBindingNavigator";
            this.queuesCalendarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.queuesCalendarBindingNavigator.Size = new System.Drawing.Size(1565, 38);
            this.queuesCalendarBindingNavigator.TabIndex = 4;
            this.queuesCalendarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // queuesCalendarBindingNavigatorSaveItem
            // 
            this.queuesCalendarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.queuesCalendarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("queuesCalendarBindingNavigatorSaveItem.Image")));
            this.queuesCalendarBindingNavigatorSaveItem.Name = "queuesCalendarBindingNavigatorSaveItem";
            this.queuesCalendarBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.queuesCalendarBindingNavigatorSaveItem.Text = "Save Data";
            this.queuesCalendarBindingNavigatorSaveItem.Click += new System.EventHandler(this.queuesCalendarBindingNavigatorSaveItem_Click);
            // 
            // queuesCalendarDataGridView
            // 
            this.queuesCalendarDataGridView.AutoGenerateColumns = false;
            this.queuesCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queuesCalendarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.queuesCalendarDataGridView.DataSource = this.queuesCalendarBindingSource;
            this.queuesCalendarDataGridView.Location = new System.Drawing.Point(37, 321);
            this.queuesCalendarDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queuesCalendarDataGridView.Name = "queuesCalendarDataGridView";
            this.queuesCalendarDataGridView.RowHeadersWidth = 51;
            this.queuesCalendarDataGridView.RowTemplate.Height = 24;
            this.queuesCalendarDataGridView.Size = new System.Drawing.Size(747, 232);
            this.queuesCalendarDataGridView.TabIndex = 5;
            this.queuesCalendarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.queuesCalendarDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TreatmentCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "TreatmentCode";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TherapistId";
            this.dataGridViewTextBoxColumn2.HeaderText = "TherapistId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn3.HeaderText = "time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn5.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // txtNamet
            // 
            this.txtNamet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNamet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNamet.Location = new System.Drawing.Point(305, 82);
            this.txtNamet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamet.Name = "txtNamet";
            this.txtNamet.ReadOnly = true;
            this.txtNamet.Size = new System.Drawing.Size(137, 25);
            this.txtNamet.TabIndex = 6;
            // 
            // txtIDt
            // 
            this.txtIDt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIDt.Location = new System.Drawing.Point(735, 89);
            this.txtIDt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDt.Name = "txtIDt";
            this.txtIDt.ReadOnly = true;
            this.txtIDt.Size = new System.Drawing.Size(134, 25);
            this.txtIDt.TabIndex = 7;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(98, 180);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(136, 25);
            this.dtpStart.TabIndex = 8;
            this.dtpStart.Value = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(98, 259);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(136, 25);
            this.dtpEnd.TabIndex = 9;
            this.dtpEnd.Value = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            // 
            // btnfilterdate
            // 
            this.btnfilterdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfilterdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnfilterdate.Location = new System.Drawing.Point(279, 220);
            this.btnfilterdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfilterdate.Name = "btnfilterdate";
            this.btnfilterdate.Size = new System.Drawing.Size(84, 29);
            this.btnfilterdate.TabIndex = 10;
            this.btnfilterdate.Text = "Filter ";
            this.btnfilterdate.UseVisualStyleBackColor = false;
            this.btnfilterdate.Click += new System.EventHandler(this.btnfilterdate_Click);
            // 
            // lstP
            // 
            this.lstP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstP.FormattingEnabled = true;
            this.lstP.ItemHeight = 20;
            this.lstP.Location = new System.Drawing.Point(176, 590);
            this.lstP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstP.Name = "lstP";
            this.lstP.Size = new System.Drawing.Size(134, 104);
            this.lstP.TabIndex = 11;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.beautySalonDataSet;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(342, 615);
            this.customersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(474, 188);
            this.customersDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdCustomer";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdCustomer";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn7.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn8.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bd";
            this.dataGridViewTextBoxColumn9.HeaderText = "bd";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "mf";
            this.dataGridViewTextBoxColumn10.HeaderText = "mf";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // pBDiary
            // 
            this.pBDiary.Image = ((System.Drawing.Image)(resources.GetObject("pBDiary.Image")));
            this.pBDiary.Location = new System.Drawing.Point(981, 38);
            this.pBDiary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBDiary.Name = "pBDiary";
            this.pBDiary.Size = new System.Drawing.Size(223, 249);
            this.pBDiary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBDiary.TabIndex = 13;
            this.pBDiary.TabStop = false;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGo.Location = new System.Drawing.Point(955, 699);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(153, 42);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Go back";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // therapistsBindingSource
            // 
            this.therapistsBindingSource.DataMember = "Therapists";
            this.therapistsBindingSource.DataSource = this.beautySalonDataSet;
            // 
            // therapistsDataGridView
            // 
            this.therapistsDataGridView.AutoGenerateColumns = false;
            this.therapistsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.therapistsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.therapistsDataGridView.DataSource = this.therapistsBindingSource;
            this.therapistsDataGridView.Location = new System.Drawing.Point(1105, 342);
            this.therapistsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.therapistsDataGridView.Name = "therapistsDataGridView";
            this.therapistsDataGridView.RowHeadersWidth = 51;
            this.therapistsDataGridView.RowTemplate.Height = 24;
            this.therapistsDataGridView.Size = new System.Drawing.Size(338, 275);
            this.therapistsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IdTherapist";
            this.dataGridViewTextBoxColumn11.HeaderText = "IdTherapist";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn12.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn13.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn14.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "BD";
            this.dataGridViewTextBoxColumn15.HeaderText = "BD";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn16.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "specialization";
            this.dataGridViewTextBoxColumn17.HeaderText = "specialization";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1565, 1079);
            this.Controls.Add(this.therapistsDataGridView);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pBDiary);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.lstP);
            this.Controls.Add(this.btnfilterdate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtIDt);
            this.Controls.Add(this.txtNamet);
            this.Controls.Add(this.queuesCalendarDataGridView);
            this.Controls.Add(this.queuesCalendarBindingNavigator);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIDt);
            this.Controls.Add(this.lblT);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "My Diary";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarBindingNavigator)).EndInit();
            this.queuesCalendarBindingNavigator.ResumeLayout(false);
            this.queuesCalendarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblIDt;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblList;
        private BeautySalonDataSet beautySalonDataSet;
        private System.Windows.Forms.BindingSource queuesCalendarBindingSource;
        private BeautySalonDataSetTableAdapters.QueuesCalendarTableAdapter queuesCalendarTableAdapter;
        private BeautySalonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator queuesCalendarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton queuesCalendarBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView queuesCalendarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtNamet;
        private System.Windows.Forms.TextBox txtIDt;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnfilterdate;
        private BeautySalonDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ListBox lstP;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.PictureBox pBDiary;
        private System.Windows.Forms.Button btnGo;
        private BeautySalonDataSetTableAdapters.TherapistsTableAdapter therapistsTableAdapter;
        private System.Windows.Forms.BindingSource therapistsBindingSource;
        private System.Windows.Forms.DataGridView therapistsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}