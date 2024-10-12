namespace BeautySalon
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.beautySalonDataSet = new BeautySalon.BeautySalonDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager();
            this.queuesCalendarTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.QueuesCalendarTableAdapter();
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
            this.queuesCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queuesCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCfirst = new System.Windows.Forms.Label();
            this.lblClast = new System.Windows.Forms.Label();
            this.txtCusFN = new System.Windows.Forms.TextBox();
            this.txtCusLN = new System.Windows.Forms.TextBox();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarDataGridView)).BeginInit();
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
            this.tableAdapterManager.QueuesCalendarTableAdapter = this.queuesCalendarTableAdapter;
            this.tableAdapterManager.TherapistsTableAdapter = null;
            this.tableAdapterManager.TreatmentTypeServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // queuesCalendarTableAdapter
            // 
            this.queuesCalendarTableAdapter.ClearBeforeFill = true;
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
            this.customersBindingNavigator.Size = new System.Drawing.Size(1491, 38);
            this.customersBindingNavigator.TabIndex = 0;
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
            this.customersDataGridView.Location = new System.Drawing.Point(1006, 98);
            this.customersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(462, 275);
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
            // queuesCalendarBindingSource
            // 
            this.queuesCalendarBindingSource.DataMember = "QueuesCalendar";
            this.queuesCalendarBindingSource.DataSource = this.beautySalonDataSet;
            // 
            // queuesCalendarDataGridView
            // 
            this.queuesCalendarDataGridView.AutoGenerateColumns = false;
            this.queuesCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queuesCalendarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.queuesCalendarDataGridView.DataSource = this.queuesCalendarBindingSource;
            this.queuesCalendarDataGridView.Location = new System.Drawing.Point(852, 446);
            this.queuesCalendarDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queuesCalendarDataGridView.Name = "queuesCalendarDataGridView";
            this.queuesCalendarDataGridView.RowHeadersWidth = 51;
            this.queuesCalendarDataGridView.RowTemplate.Height = 24;
            this.queuesCalendarDataGridView.Size = new System.Drawing.Size(616, 275);
            this.queuesCalendarDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TreatmentCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "TreatmentCode";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TherapistId";
            this.dataGridViewTextBoxColumn7.HeaderText = "TherapistId";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn8.HeaderText = "time";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn9.HeaderText = "date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn10.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // lblCfirst
            // 
            this.lblCfirst.AutoSize = true;
            this.lblCfirst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCfirst.Location = new System.Drawing.Point(46, 192);
            this.lblCfirst.Name = "lblCfirst";
            this.lblCfirst.Size = new System.Drawing.Size(183, 20);
            this.lblCfirst.TabIndex = 3;
            this.lblCfirst.Text = "Customer First Name:";
            // 
            // lblClast
            // 
            this.lblClast.AutoSize = true;
            this.lblClast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClast.Location = new System.Drawing.Point(46, 321);
            this.lblClast.Name = "lblClast";
            this.lblClast.Size = new System.Drawing.Size(182, 20);
            this.lblClast.TabIndex = 4;
            this.lblClast.Text = "Customer Last Name:";
            // 
            // txtCusFN
            // 
            this.txtCusFN.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCusFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCusFN.Location = new System.Drawing.Point(230, 189);
            this.txtCusFN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusFN.Name = "txtCusFN";
            this.txtCusFN.ReadOnly = true;
            this.txtCusFN.Size = new System.Drawing.Size(140, 25);
            this.txtCusFN.TabIndex = 5;
            // 
            // txtCusLN
            // 
            this.txtCusLN.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCusLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCusLN.Location = new System.Drawing.Point(230, 314);
            this.txtCusLN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusLN.Name = "txtCusLN";
            this.txtCusLN.Size = new System.Drawing.Size(140, 25);
            this.txtCusLN.TabIndex = 6;
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbE.Location = new System.Drawing.Point(230, 374);
            this.rdbE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(66, 24);
            this.rdbE.TabIndex = 7;
            this.rdbE.Text = "Edit";
            this.rdbE.UseVisualStyleBackColor = false;
            this.rdbE.CheckedChanged += new System.EventHandler(this.rdbE_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(309, 370);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDetails.Location = new System.Drawing.Point(46, 109);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(140, 25);
            this.lblDetails.TabIndex = 9;
            this.lblDetails.Text = "Edit Details:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1491, 902);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdbE);
            this.Controls.Add(this.txtCusLN);
            this.Controls.Add(this.txtCusFN);
            this.Controls.Add(this.lblClast);
            this.Controls.Add(this.lblCfirst);
            this.Controls.Add(this.queuesCalendarDataGridView);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.customersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.Text = "Update Customer Details";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queuesCalendarDataGridView)).EndInit();
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
        private BeautySalonDataSetTableAdapters.QueuesCalendarTableAdapter queuesCalendarTableAdapter;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource queuesCalendarBindingSource;
        private System.Windows.Forms.DataGridView queuesCalendarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblCfirst;
        private System.Windows.Forms.Label lblClast;
        private System.Windows.Forms.TextBox txtCusFN;
        private System.Windows.Forms.TextBox txtCusLN;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDetails;
    }
}