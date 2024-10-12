namespace BeautySalon
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.beautySalonDataSet = new BeautySalon.BeautySalonDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager();
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
            this.pBheart = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.cmbG = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBheart)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.TherapistsTableAdapter = null;
            this.tableAdapterManager.TreatmentTypeServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.customersBindingNavigator.Size = new System.Drawing.Size(1546, 31);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 26);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 26);
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
            this.customersDataGridView.Location = new System.Drawing.Point(710, 542);
            this.customersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(740, 140);
            this.customersDataGridView.TabIndex = 1;
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
            // pBheart
            // 
            this.pBheart.Image = ((System.Drawing.Image)(resources.GetObject("pBheart.Image")));
            this.pBheart.Location = new System.Drawing.Point(620, 106);
            this.pBheart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBheart.Name = "pBheart";
            this.pBheart.Size = new System.Drawing.Size(260, 265);
            this.pBheart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBheart.TabIndex = 2;
            this.pBheart.TabStop = false;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAccount.Location = new System.Drawing.Point(93, 106);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(197, 29);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Create Account:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFname.Location = new System.Drawing.Point(37, 196);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(101, 20);
            this.lblFname.TabIndex = 4;
            this.lblFname.Text = "First Name:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLname.Location = new System.Drawing.Point(37, 274);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(100, 20);
            this.lblLname.TabIndex = 5;
            this.lblLname.Text = "Last Name:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblid.Location = new System.Drawing.Point(36, 351);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(112, 20);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "Id Customer:";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBD.Location = new System.Drawing.Point(36, 436);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(39, 20);
            this.lblBD.TabIndex = 7;
            this.lblBD.Text = "BD:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblG.Location = new System.Drawing.Point(36, 521);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(74, 20);
            this.lblG.TabIndex = 8;
            this.lblG.Text = "Gender:";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFname.Location = new System.Drawing.Point(155, 189);
            this.txtFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(138, 25);
            this.txtFname.TabIndex = 9;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLname.Location = new System.Drawing.Point(155, 266);
            this.txtLname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(138, 25);
            this.txtLname.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtid.Location = new System.Drawing.Point(166, 348);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(138, 25);
            this.txtid.TabIndex = 11;
            // 
            // dtpBD
            // 
            this.dtpBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(99, 430);
            this.dtpBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(133, 25);
            this.dtpBD.TabIndex = 12;
            // 
            // cmbG
            // 
            this.cmbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbG.FormattingEnabled = true;
            this.cmbG.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.cmbG.Location = new System.Drawing.Point(123, 511);
            this.cmbG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbG.Name = "cmbG";
            this.cmbG.Size = new System.Drawing.Size(136, 28);
            this.cmbG.TabIndex = 13;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUp.Location = new System.Drawing.Point(454, 592);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(133, 64);
            this.btnUp.TabIndex = 14;
            this.btnUp.Text = "Sing Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1546, 848);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.cmbG);
            this.Controls.Add(this.dtpBD);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.pBheart);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.customersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Sing Up";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBheart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.PictureBox pBheart;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.ComboBox cmbG;
        private System.Windows.Forms.Button btnUp;
    }
}