namespace BeautySalon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grp = new System.Windows.Forms.GroupBox();
            this.rdT = new System.Windows.Forms.RadioButton();
            this.rdE = new System.Windows.Forms.RadioButton();
            this.txtidE = new System.Windows.Forms.TextBox();
            this.txtidT = new System.Windows.Forms.TextBox();
            this.btnInE = new System.Windows.Forms.Button();
            this.btnInT = new System.Windows.Forms.Button();
            this.btnClearE = new System.Windows.Forms.Button();
            this.btnClearT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.beautySalonDataSet = new BeautySalon.BeautySalonDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager();
            this.therapistsTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.TherapistsTableAdapter();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.therapistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.therapistsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp.Controls.Add(this.rdT);
            this.grp.Controls.Add(this.rdE);
            this.grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grp.Location = new System.Drawing.Point(25, 159);
            this.grp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp.Name = "grp";
            this.grp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp.Size = new System.Drawing.Size(297, 216);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "My Account:";
            // 
            // rdT
            // 
            this.rdT.AutoSize = true;
            this.rdT.Checked = true;
            this.rdT.Location = new System.Drawing.Point(7, 120);
            this.rdT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdT.Name = "rdT";
            this.rdT.Size = new System.Drawing.Size(148, 29);
            this.rdT.TabIndex = 1;
            this.rdT.TabStop = true;
            this.rdT.Text = "Therapists";
            this.rdT.UseVisualStyleBackColor = true;
            this.rdT.CheckedChanged += new System.EventHandler(this.rdT_CheckedChanged);
            // 
            // rdE
            // 
            this.rdE.AutoSize = true;
            this.rdE.Location = new System.Drawing.Point(7, 42);
            this.rdE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdE.Name = "rdE";
            this.rdE.Size = new System.Drawing.Size(228, 29);
            this.rdE.TabIndex = 0;
            this.rdE.Text = "Existing Customer";
            this.rdE.UseVisualStyleBackColor = true;
            this.rdE.CheckedChanged += new System.EventHandler(this.rdE_CheckedChanged);
            // 
            // txtidE
            // 
            this.txtidE.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtidE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtidE.Location = new System.Drawing.Point(32, 456);
            this.txtidE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidE.Name = "txtidE";
            this.txtidE.Size = new System.Drawing.Size(119, 25);
            this.txtidE.TabIndex = 1;
            this.txtidE.Visible = false;
            // 
            // txtidT
            // 
            this.txtidT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtidT.Location = new System.Drawing.Point(32, 456);
            this.txtidT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidT.Name = "txtidT";
            this.txtidT.Size = new System.Drawing.Size(119, 25);
            this.txtidT.TabIndex = 2;
            this.txtidT.Visible = false;
            // 
            // btnInE
            // 
            this.btnInE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnInE.Location = new System.Drawing.Point(170, 452);
            this.btnInE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInE.Name = "btnInE";
            this.btnInE.Size = new System.Drawing.Size(84, 40);
            this.btnInE.TabIndex = 3;
            this.btnInE.Text = "Log In";
            this.btnInE.UseVisualStyleBackColor = false;
            this.btnInE.Visible = false;
            this.btnInE.Click += new System.EventHandler(this.btnInE_Click);
            // 
            // btnInT
            // 
            this.btnInT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnInT.Location = new System.Drawing.Point(170, 451);
            this.btnInT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInT.Name = "btnInT";
            this.btnInT.Size = new System.Drawing.Size(84, 44);
            this.btnInT.TabIndex = 4;
            this.btnInT.Text = "Log In";
            this.btnInT.UseVisualStyleBackColor = false;
            this.btnInT.Visible = false;
            this.btnInT.Click += new System.EventHandler(this.btnInT_Click);
            // 
            // btnClearE
            // 
            this.btnClearE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClearE.Location = new System.Drawing.Point(170, 520);
            this.btnClearE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearE.Name = "btnClearE";
            this.btnClearE.Size = new System.Drawing.Size(84, 41);
            this.btnClearE.TabIndex = 5;
            this.btnClearE.Text = "Clear";
            this.btnClearE.UseVisualStyleBackColor = false;
            this.btnClearE.Visible = false;
            this.btnClearE.Click += new System.EventHandler(this.btnClearE_Click);
            // 
            // btnClearT
            // 
            this.btnClearT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClearT.Location = new System.Drawing.Point(170, 520);
            this.btnClearT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearT.Name = "btnClearT";
            this.btnClearT.Size = new System.Drawing.Size(84, 44);
            this.btnClearT.TabIndex = 6;
            this.btnClearT.Text = "Clear";
            this.btnClearT.UseVisualStyleBackColor = false;
            this.btnClearT.Visible = false;
            this.btnClearT.Click += new System.EventHandler(this.btnClearT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(25, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUp.Location = new System.Drawing.Point(291, 622);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 34);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Sing Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // beautySalonDataSet
            // 
            this.beautySalonDataSet.DataSetName = "BeautySalonDataSet";
            this.beautySalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.beautySalonDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.QueuesCalendarTableAdapter = null;
            this.tableAdapterManager.TherapistsTableAdapter = this.therapistsTableAdapter;
            this.tableAdapterManager.TreatmentTypeServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // therapistsTableAdapter
            // 
            this.therapistsTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1550, 38);
            this.customersBindingNavigator.TabIndex = 9;
            this.customersBindingNavigator.Text = "bindingNavigator1";
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
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(901, 330);
            this.customersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(484, 184);
            this.customersDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCustomer";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCustomer";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bd";
            this.dataGridViewTextBoxColumn4.HeaderText = "bd";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mf";
            this.dataGridViewTextBoxColumn5.HeaderText = "mf";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.therapistsDataGridView.DataSource = this.therapistsBindingSource;
            this.therapistsDataGridView.Location = new System.Drawing.Point(901, 544);
            this.therapistsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.therapistsDataGridView.Name = "therapistsDataGridView";
            this.therapistsDataGridView.RowHeadersWidth = 51;
            this.therapistsDataGridView.RowTemplate.Height = 24;
            this.therapistsDataGridView.Size = new System.Drawing.Size(484, 199);
            this.therapistsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdTherapist";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdTherapist";
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
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn9.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "BD";
            this.dataGridViewTextBoxColumn10.HeaderText = "BD";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn11.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "specialization";
            this.dataGridViewTextBoxColumn12.HeaderText = "specialization";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // pBHome
            // 
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(410, 38);
            this.pBHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(341, 524);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.TabIndex = 12;
            this.pBHome.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1550, 918);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.therapistsDataGridView);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.customersBindingNavigator);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearT);
            this.Controls.Add(this.btnClearE);
            this.Controls.Add(this.btnInT);
            this.Controls.Add(this.btnInE);
            this.Controls.Add(this.txtidT);
            this.Controls.Add(this.txtidE);
            this.Controls.Add(this.grp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapistsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton rdT;
        private System.Windows.Forms.RadioButton rdE;
        private System.Windows.Forms.TextBox txtidE;
        private System.Windows.Forms.TextBox txtidT;
        private System.Windows.Forms.Button btnInE;
        private System.Windows.Forms.Button btnInT;
        private System.Windows.Forms.Button btnClearE;
        private System.Windows.Forms.Button btnClearT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUp;
        private BeautySalonDataSet beautySalonDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private BeautySalonDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private BeautySalonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private BeautySalonDataSetTableAdapters.TherapistsTableAdapter therapistsTableAdapter;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource therapistsBindingSource;
        private System.Windows.Forms.DataGridView therapistsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.PictureBox pBHome;
    }
}