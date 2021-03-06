﻿namespace IoT_Poject
{
    partial class Device_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_device = new System.Windows.Forms.DataGridView();
            this.tblDevicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityurban = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.battery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describtionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ioTDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ioT_DBDataSet = new IoT_Poject.IoT_DBDataSet();
            this.tbl_DevicesTableAdapter = new IoT_Poject.IoT_DBDataSetTableAdapters.tbl_DevicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioTDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioT_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_device
            // 
            this.dgv_device.AllowUserToAddRows = false;
            this.dgv_device.AllowUserToDeleteRows = false;
            this.dgv_device.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_device.AutoGenerateColumns = false;
            this.dgv_device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.cityurban,
            this.describtionDataGridViewTextBoxColumn,
            this.battery});
            this.dgv_device.DataSource = this.tblDevicesBindingSource1;
            this.dgv_device.Location = new System.Drawing.Point(12, 107);
            this.dgv_device.Name = "dgv_device";
            this.dgv_device.ReadOnly = true;
            this.dgv_device.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_device.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgv_device.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_device.RowTemplate.Height = 24;
            this.dgv_device.Size = new System.Drawing.Size(1169, 352);
            this.dgv_device.TabIndex = 0;
            this.dgv_device.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_device_CellClick);
            // 
            // tblDevicesBindingSource1
            // 
            this.tblDevicesBindingSource1.DataMember = "tbl_Devices";
            this.tblDevicesBindingSource1.DataSource = this.ioTDBDataSetBindingSource;
            // 
            // tblDevicesBindingSource
            // 
            this.tblDevicesBindingSource.DataMember = "tbl_Devices";
            this.tblDevicesBindingSource.DataSource = this.ioTDBDataSetBindingSource;
            // 
            // cityurban
            // 
            this.cityurban.DataPropertyName = "cityurban";
            this.cityurban.HeaderText = "منطقه(شهری)";
            this.cityurban.Name = "cityurban";
            this.cityurban.ReadOnly = true;
            // 
            // battery
            // 
            this.battery.DataPropertyName = "battery";
            this.battery.HeaderText = "میزان باطری";
            this.battery.Name = "battery";
            this.battery.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام دستگاه";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "نوع";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // describtionDataGridViewTextBoxColumn
            // 
            this.describtionDataGridViewTextBoxColumn.DataPropertyName = "describtion";
            this.describtionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.describtionDataGridViewTextBoxColumn.Name = "describtionDataGridViewTextBoxColumn";
            this.describtionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ioTDBDataSetBindingSource
            // 
            this.ioTDBDataSetBindingSource.DataSource = this.ioT_DBDataSet;
            this.ioTDBDataSetBindingSource.Position = 0;
            // 
            // ioT_DBDataSet
            // 
            this.ioT_DBDataSet.DataSetName = "IoT_DBDataSet";
            this.ioT_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DevicesTableAdapter
            // 
            this.tbl_DevicesTableAdapter.ClearBeforeFill = true;
            // 
            // Device_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 471);
            this.Controls.Add(this.dgv_device);
            this.Name = "Device_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device_Form";
            this.Load += new System.EventHandler(this.Device_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioTDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioT_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_device;
        private System.Windows.Forms.BindingSource ioTDBDataSetBindingSource;
        private IoT_DBDataSet ioT_DBDataSet;
        private System.Windows.Forms.BindingSource tblDevicesBindingSource;
        private IoT_DBDataSetTableAdapters.tbl_DevicesTableAdapter tbl_DevicesTableAdapter;
        private System.Windows.Forms.BindingSource tblDevicesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cityurban;
        private System.Windows.Forms.DataGridViewTextBoxColumn describtionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn battery;
    }
}