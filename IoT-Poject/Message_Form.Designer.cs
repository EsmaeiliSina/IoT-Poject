namespace IoT_Poject
{
    partial class Message_Form
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
            this.rbtn_sigfox = new System.Windows.Forms.RadioButton();
            this.rbtn_lora = new System.Windows.Forms.RadioButton();
            this.rbtn_nbiot = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tbx_message = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.tbx_code = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_max = new System.Windows.Forms.TextBox();
            this.tbx_lengh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_sigfox
            // 
            this.rbtn_sigfox.AutoSize = true;
            this.rbtn_sigfox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.rbtn_sigfox.Location = new System.Drawing.Point(6, 33);
            this.rbtn_sigfox.Name = "rbtn_sigfox";
            this.rbtn_sigfox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn_sigfox.Size = new System.Drawing.Size(91, 29);
            this.rbtn_sigfox.TabIndex = 0;
            this.rbtn_sigfox.TabStop = true;
            this.rbtn_sigfox.Text = "Sigfox";
            this.rbtn_sigfox.UseVisualStyleBackColor = true;
            this.rbtn_sigfox.CheckedChanged += new System.EventHandler(this.rbtn_sigfox_CheckedChanged);
            // 
            // rbtn_lora
            // 
            this.rbtn_lora.AutoSize = true;
            this.rbtn_lora.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.rbtn_lora.Location = new System.Drawing.Point(6, 70);
            this.rbtn_lora.Name = "rbtn_lora";
            this.rbtn_lora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn_lora.Size = new System.Drawing.Size(85, 29);
            this.rbtn_lora.TabIndex = 1;
            this.rbtn_lora.TabStop = true;
            this.rbtn_lora.Text = "LoRa";
            this.rbtn_lora.UseVisualStyleBackColor = true;
            this.rbtn_lora.CheckedChanged += new System.EventHandler(this.rbtn_lora_CheckedChanged);
            // 
            // rbtn_nbiot
            // 
            this.rbtn_nbiot.AutoSize = true;
            this.rbtn_nbiot.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtn_nbiot.Location = new System.Drawing.Point(6, 107);
            this.rbtn_nbiot.Name = "rbtn_nbiot";
            this.rbtn_nbiot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn_nbiot.Size = new System.Drawing.Size(106, 29);
            this.rbtn_nbiot.TabIndex = 2;
            this.rbtn_nbiot.TabStop = true;
            this.rbtn_nbiot.Text = "NB-IoT";
            this.rbtn_nbiot.UseVisualStyleBackColor = true;
            this.rbtn_nbiot.CheckedChanged += new System.EventHandler(this.rbtn_nbiot_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rbtn_nbiot);
            this.groupBox.Controls.Add(this.rbtn_lora);
            this.groupBox.Controls.Add(this.rbtn_sigfox);
            this.groupBox.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox.Size = new System.Drawing.Size(200, 151);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "پروتکل";
            // 
            // tbx_message
            // 
            this.tbx_message.Location = new System.Drawing.Point(218, 82);
            this.tbx_message.Multiline = true;
            this.tbx_message.Name = "tbx_message";
            this.tbx_message.Size = new System.Drawing.Size(375, 81);
            this.tbx_message.TabIndex = 0;
            this.tbx_message.TextChanged += new System.EventHandler(this.tbx_message_TextChanged);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_code.Location = new System.Drawing.Point(511, 16);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(82, 29);
            this.lbl_code.TabIndex = 2;
            this.lbl_code.Text = "شناسه دستگاه";
            // 
            // tbx_code
            // 
            this.tbx_code.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_code.Location = new System.Drawing.Point(404, 12);
            this.tbx_code.Name = "tbx_code";
            this.tbx_code.ReadOnly = true;
            this.tbx_code.Size = new System.Drawing.Size(101, 36);
            this.tbx_code.TabIndex = 3;
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_name.Location = new System.Drawing.Point(230, 12);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.ReadOnly = true;
            this.tbx_name.Size = new System.Drawing.Size(98, 36);
            this.tbx_name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(334, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام دستگاه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(563, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "پیام";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Confirm.Location = new System.Drawing.Point(11, 170);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(98, 34);
            this.btn_Confirm.TabIndex = 2;
            this.btn_Confirm.Text = "تایید";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(115, 170);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 34);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(496, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "حداکثر طول پیام";
            // 
            // tbx_max
            // 
            this.tbx_max.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_max.Location = new System.Drawing.Point(389, 167);
            this.tbx_max.Name = "tbx_max";
            this.tbx_max.ReadOnly = true;
            this.tbx_max.Size = new System.Drawing.Size(101, 36);
            this.tbx_max.TabIndex = 8;
            // 
            // tbx_lengh
            // 
            this.tbx_lengh.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_lengh.Location = new System.Drawing.Point(222, 168);
            this.tbx_lengh.Name = "tbx_lengh";
            this.tbx_lengh.ReadOnly = true;
            this.tbx_lengh.Size = new System.Drawing.Size(98, 36);
            this.tbx_lengh.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(328, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "طول پیام";
            // 
            // Message_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 216);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_lengh);
            this.Controls.Add(this.tbx_max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_code);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.tbx_message);
            this.Controls.Add(this.groupBox);
            this.Name = "Message_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیام";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_sigfox;
        private System.Windows.Forms.RadioButton rbtn_lora;
        private System.Windows.Forms.RadioButton rbtn_nbiot;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox tbx_message;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.TextBox tbx_code;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_max;
        private System.Windows.Forms.TextBox tbx_lengh;
        private System.Windows.Forms.Label label4;
    }
}