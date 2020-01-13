namespace IoT_Poject
{
    partial class BatteryUsage_Form
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
            this.dgv_sigfox = new System.Windows.Forms.DataGridView();
            this.device_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_lora = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nbiot = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sigfox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nbiot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sigfox
            // 
            this.dgv_sigfox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sigfox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sigfox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.device_id,
            this.device_name,
            this.message_count,
            this.battery});
            this.dgv_sigfox.Location = new System.Drawing.Point(12, 62);
            this.dgv_sigfox.Name = "dgv_sigfox";
            this.dgv_sigfox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_sigfox.RowTemplate.Height = 24;
            this.dgv_sigfox.Size = new System.Drawing.Size(454, 347);
            this.dgv_sigfox.TabIndex = 0;
            // 
            // device_id
            // 
            this.device_id.HeaderText = "شناسه دستگاه";
            this.device_id.Name = "device_id";
            // 
            // device_name
            // 
            this.device_name.HeaderText = "نام دستگاه";
            this.device_name.Name = "device_name";
            // 
            // message_count
            // 
            this.message_count.HeaderText = "تعدا پیام ها";
            this.message_count.Name = "message_count";
            // 
            // battery
            // 
            this.battery.HeaderText = "میزان باطری مصرفی";
            this.battery.Name = "battery";
            // 
            // dgv_lora
            // 
            this.dgv_lora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_lora.Location = new System.Drawing.Point(474, 62);
            this.dgv_lora.Name = "dgv_lora";
            this.dgv_lora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_lora.RowTemplate.Height = 24;
            this.dgv_lora.Size = new System.Drawing.Size(454, 347);
            this.dgv_lora.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "شناسه دستگاه";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "نام دستگاه";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "تعدا پیام ها";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "میزان باطری مصرفی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgv_nbiot
            // 
            this.dgv_nbiot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nbiot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nbiot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgv_nbiot.Location = new System.Drawing.Point(934, 62);
            this.dgv_nbiot.Name = "dgv_nbiot";
            this.dgv_nbiot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_nbiot.RowTemplate.Height = 24;
            this.dgv_nbiot.Size = new System.Drawing.Size(454, 347);
            this.dgv_nbiot.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "شناسه دستگاه";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "نام دستگاه";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "تعدا پیام ها";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "میزان باطری مصرفی";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sigfox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(930, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "NB-IoT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "LoRa";
            // 
            // BatteryUsage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_nbiot);
            this.Controls.Add(this.dgv_lora);
            this.Controls.Add(this.dgv_sigfox);
            this.Name = "BatteryUsage_Form";
            this.Text = "BatteryUsage_Form";
            this.Load += new System.EventHandler(this.BatteryUsage_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sigfox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nbiot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sigfox;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn battery;
        private System.Windows.Forms.DataGridView dgv_lora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgv_nbiot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}