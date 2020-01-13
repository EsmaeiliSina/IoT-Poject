namespace IoT_Poject
{
    partial class sentMessages_Form
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
            this.dgv_Uplink = new System.Windows.Forms.DataGridView();
            this.dgv_Downlink = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ioT_DBDataSet = new IoT_Poject.IoT_DBDataSet();
            this.tbluplinkmessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_uplinkmessagesTableAdapter = new IoT_Poject.IoT_DBDataSetTableAdapters.tbl_uplinkmessagesTableAdapter();
            this.tbldownlinkmessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_downlinkmessagesTableAdapter = new IoT_Poject.IoT_DBDataSetTableAdapters.tbl_downlinkmessagesTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protcolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uplink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Downlink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioT_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluplinkmessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldownlinkmessagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Uplink
            // 
            this.dgv_Uplink.AllowUserToAddRows = false;
            this.dgv_Uplink.AllowUserToDeleteRows = false;
            this.dgv_Uplink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Uplink.AutoGenerateColumns = false;
            this.dgv_Uplink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Uplink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.deviceidDataGridViewTextBoxColumn,
            this.protcolDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.dgv_Uplink.DataSource = this.tbluplinkmessagesBindingSource;
            this.dgv_Uplink.Location = new System.Drawing.Point(12, 46);
            this.dgv_Uplink.Name = "dgv_Uplink";
            this.dgv_Uplink.ReadOnly = true;
            this.dgv_Uplink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Uplink.RowTemplate.Height = 24;
            this.dgv_Uplink.Size = new System.Drawing.Size(609, 489);
            this.dgv_Uplink.TabIndex = 0;
            // 
            // dgv_Downlink
            // 
            this.dgv_Downlink.AllowUserToAddRows = false;
            this.dgv_Downlink.AllowUserToDeleteRows = false;
            this.dgv_Downlink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Downlink.AutoGenerateColumns = false;
            this.dgv_Downlink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Downlink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.deviceidDataGridViewTextBoxColumn1,
            this.protocolDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn1});
            this.dgv_Downlink.DataSource = this.tbldownlinkmessagesBindingSource;
            this.dgv_Downlink.Location = new System.Drawing.Point(627, 46);
            this.dgv_Downlink.Name = "dgv_Downlink";
            this.dgv_Downlink.ReadOnly = true;
            this.dgv_Downlink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Downlink.RowTemplate.Height = 24;
            this.dgv_Downlink.Size = new System.Drawing.Size(609, 489);
            this.dgv_Downlink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "UpLink Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(623, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "DownLink Messages";
            // 
            // ioT_DBDataSet
            // 
            this.ioT_DBDataSet.DataSetName = "IoT_DBDataSet";
            this.ioT_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbluplinkmessagesBindingSource
            // 
            this.tbluplinkmessagesBindingSource.DataMember = "tbl_uplinkmessages";
            this.tbluplinkmessagesBindingSource.DataSource = this.ioT_DBDataSet;
            // 
            // tbl_uplinkmessagesTableAdapter
            // 
            this.tbl_uplinkmessagesTableAdapter.ClearBeforeFill = true;
            // 
            // tbldownlinkmessagesBindingSource
            // 
            this.tbldownlinkmessagesBindingSource.DataMember = "tbl_downlinkmessages";
            this.tbldownlinkmessagesBindingSource.DataSource = this.ioT_DBDataSet;
            // 
            // tbl_downlinkmessagesTableAdapter
            // 
            this.tbl_downlinkmessagesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "شناسه پیام";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // deviceidDataGridViewTextBoxColumn1
            // 
            this.deviceidDataGridViewTextBoxColumn1.DataPropertyName = "device_id";
            this.deviceidDataGridViewTextBoxColumn1.HeaderText = "شناسه دستگاه";
            this.deviceidDataGridViewTextBoxColumn1.Name = "deviceidDataGridViewTextBoxColumn1";
            this.deviceidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "پروتکل";
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            this.protocolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn1
            // 
            this.messageDataGridViewTextBoxColumn1.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn1.HeaderText = "پیام";
            this.messageDataGridViewTextBoxColumn1.Name = "messageDataGridViewTextBoxColumn1";
            this.messageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "شناسه پیام";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceidDataGridViewTextBoxColumn
            // 
            this.deviceidDataGridViewTextBoxColumn.DataPropertyName = "device_id";
            this.deviceidDataGridViewTextBoxColumn.HeaderText = "شناسه دستگاه";
            this.deviceidDataGridViewTextBoxColumn.Name = "deviceidDataGridViewTextBoxColumn";
            this.deviceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // protcolDataGridViewTextBoxColumn
            // 
            this.protcolDataGridViewTextBoxColumn.DataPropertyName = "protcol";
            this.protcolDataGridViewTextBoxColumn.HeaderText = "پروتکل";
            this.protcolDataGridViewTextBoxColumn.Name = "protcolDataGridViewTextBoxColumn";
            this.protcolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "پیام";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sentMessages_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Downlink);
            this.Controls.Add(this.dgv_Uplink);
            this.Name = "sentMessages_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیام های ارسالی";
            this.Load += new System.EventHandler(this.sentMessages_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uplink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Downlink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioT_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluplinkmessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldownlinkmessagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Uplink;
        private System.Windows.Forms.DataGridView dgv_Downlink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private IoT_DBDataSet ioT_DBDataSet;
        private System.Windows.Forms.BindingSource tbluplinkmessagesBindingSource;
        private IoT_DBDataSetTableAdapters.tbl_uplinkmessagesTableAdapter tbl_uplinkmessagesTableAdapter;
        private System.Windows.Forms.BindingSource tbldownlinkmessagesBindingSource;
        private IoT_DBDataSetTableAdapters.tbl_downlinkmessagesTableAdapter tbl_downlinkmessagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protcolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn1;
    }
}