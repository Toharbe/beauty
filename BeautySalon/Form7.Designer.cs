namespace BeautySalon
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.beautySalonDataSet = new BeautySalon.BeautySalonDataSet();
            this.treatmentTypeServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentTypeServiceTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.TreatmentTypeServiceTableAdapter();
            this.tableAdapterManager = new BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager();
            this.treatmentTypeServiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.treatmentTypeServiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.treatmentTypeServiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBPrice = new System.Windows.Forms.PictureBox();
            this.lblFull = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblChoices = new System.Windows.Forms.Label();
            this.txtFull = new System.Windows.Forms.TextBox();
            this.lstwC = new System.Windows.Forms.ListView();
            this.lblReceive = new System.Windows.Forms.Label();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentTypeServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentTypeServiceBindingNavigator)).BeginInit();
            this.treatmentTypeServiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentTypeServiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // beautySalonDataSet
            // 
            this.beautySalonDataSet.DataSetName = "BeautySalonDataSet";
            this.beautySalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treatmentTypeServiceBindingSource
            // 
            this.treatmentTypeServiceBindingSource.DataMember = "TreatmentTypeService";
            this.treatmentTypeServiceBindingSource.DataSource = this.beautySalonDataSet;
            // 
            // treatmentTypeServiceTableAdapter
            // 
            this.treatmentTypeServiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.QueuesCalendarTableAdapter = null;
            this.tableAdapterManager.TherapistsTableAdapter = null;
            this.tableAdapterManager.TreatmentTypeServiceTableAdapter = this.treatmentTypeServiceTableAdapter;
            this.tableAdapterManager.UpdateOrder = BeautySalon.BeautySalonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // treatmentTypeServiceBindingNavigator
            // 
            this.treatmentTypeServiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.treatmentTypeServiceBindingNavigator.BindingSource = this.treatmentTypeServiceBindingSource;
            this.treatmentTypeServiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.treatmentTypeServiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.treatmentTypeServiceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.treatmentTypeServiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.treatmentTypeServiceBindingNavigatorSaveItem});
            this.treatmentTypeServiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.treatmentTypeServiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.treatmentTypeServiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.treatmentTypeServiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.treatmentTypeServiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.treatmentTypeServiceBindingNavigator.Name = "treatmentTypeServiceBindingNavigator";
            this.treatmentTypeServiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.treatmentTypeServiceBindingNavigator.Size = new System.Drawing.Size(1593, 31);
            this.treatmentTypeServiceBindingNavigator.TabIndex = 0;
            this.treatmentTypeServiceBindingNavigator.Text = "bindingNavigator1";
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
            // treatmentTypeServiceBindingNavigatorSaveItem
            // 
            this.treatmentTypeServiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.treatmentTypeServiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("treatmentTypeServiceBindingNavigatorSaveItem.Image")));
            this.treatmentTypeServiceBindingNavigatorSaveItem.Name = "treatmentTypeServiceBindingNavigatorSaveItem";
            this.treatmentTypeServiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 26);
            this.treatmentTypeServiceBindingNavigatorSaveItem.Text = "Save Data";
            this.treatmentTypeServiceBindingNavigatorSaveItem.Click += new System.EventHandler(this.treatmentTypeServiceBindingNavigatorSaveItem_Click);
            // 
            // treatmentTypeServiceDataGridView
            // 
            this.treatmentTypeServiceDataGridView.AutoGenerateColumns = false;
            this.treatmentTypeServiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentTypeServiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.treatmentTypeServiceDataGridView.DataSource = this.treatmentTypeServiceBindingSource;
            this.treatmentTypeServiceDataGridView.Location = new System.Drawing.Point(1032, 64);
            this.treatmentTypeServiceDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treatmentTypeServiceDataGridView.Name = "treatmentTypeServiceDataGridView";
            this.treatmentTypeServiceDataGridView.RowHeadersWidth = 51;
            this.treatmentTypeServiceDataGridView.RowTemplate.Height = 24;
            this.treatmentTypeServiceDataGridView.Size = new System.Drawing.Size(474, 275);
            this.treatmentTypeServiceDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeService";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypeService";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // pBPrice
            // 
            this.pBPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pBPrice.Image = ((System.Drawing.Image)(resources.GetObject("pBPrice.Image")));
            this.pBPrice.Location = new System.Drawing.Point(704, 64);
            this.pBPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBPrice.Name = "pBPrice";
            this.pBPrice.Size = new System.Drawing.Size(270, 341);
            this.pBPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBPrice.TabIndex = 2;
            this.pBPrice.TabStop = false;
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFull.Location = new System.Drawing.Point(124, 85);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(94, 20);
            this.lblFull.TabIndex = 3;
            this.lblFull.Text = "Full Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.Location = new System.Drawing.Point(36, 284);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(99, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Total Price:";
            // 
            // lblChoices
            // 
            this.lblChoices.AutoSize = true;
            this.lblChoices.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChoices.Location = new System.Drawing.Point(305, 284);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Size = new System.Drawing.Size(110, 20);
            this.lblChoices.TabIndex = 5;
            this.lblChoices.Text = "My Choices: ";
            // 
            // txtFull
            // 
            this.txtFull.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFull.Location = new System.Drawing.Point(222, 78);
            this.txtFull.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFull.Name = "txtFull";
            this.txtFull.ReadOnly = true;
            this.txtFull.Size = new System.Drawing.Size(164, 25);
            this.txtFull.TabIndex = 6;
            // 
            // lstwC
            // 
            this.lstwC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstwC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstwC.HideSelection = false;
            this.lstwC.Location = new System.Drawing.Point(418, 238);
            this.lstwC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstwC.Name = "lstwC";
            this.lstwC.Size = new System.Drawing.Size(136, 120);
            this.lstwC.TabIndex = 7;
            this.lstwC.UseCompatibleStateImageBehavior = false;
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblReceive.Location = new System.Drawing.Point(35, 413);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(627, 25);
            this.lblReceive.TabIndex = 8;
            this.lblReceive.Text = "Do you want to receive a reminder about the appointment?";
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkYes.Location = new System.Drawing.Point(163, 470);
            this.chkYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(66, 24);
            this.chkYes.TabIndex = 9;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = false;
            this.chkYes.CheckedChanged += new System.EventHandler(this.chkYes_CheckedChanged);
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkNo.Location = new System.Drawing.Point(279, 470);
            this.chkNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(57, 24);
            this.chkNo.TabIndex = 10;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = false;
            this.chkNo.CheckedChanged += new System.EventHandler(this.chkNo_CheckedChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnd.Location = new System.Drawing.Point(591, 545);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(116, 51);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "Ending";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1593, 734);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkYes);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.lstwC);
            this.Controls.Add(this.txtFull);
            this.Controls.Add(this.lblChoices);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.pBPrice);
            this.Controls.Add(this.treatmentTypeServiceDataGridView);
            this.Controls.Add(this.treatmentTypeServiceBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form7";
            this.Text = "Order Summary";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentTypeServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentTypeServiceBindingNavigator)).EndInit();
            this.treatmentTypeServiceBindingNavigator.ResumeLayout(false);
            this.treatmentTypeServiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentTypeServiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautySalonDataSet beautySalonDataSet;
        private System.Windows.Forms.BindingSource treatmentTypeServiceBindingSource;
        private BeautySalonDataSetTableAdapters.TreatmentTypeServiceTableAdapter treatmentTypeServiceTableAdapter;
        private BeautySalonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator treatmentTypeServiceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton treatmentTypeServiceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView treatmentTypeServiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pBPrice;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblChoices;
        private System.Windows.Forms.TextBox txtFull;
        private System.Windows.Forms.ListView lstwC;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.Button btnEnd;
    }
}