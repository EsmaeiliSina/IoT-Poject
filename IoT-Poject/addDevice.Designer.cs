namespace IoT_Poject
{
    partial class addDevice
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_distance = new System.Windows.Forms.TextBox();
            this.tbx_describtion = new System.Windows.Forms.TextBox();
            this.tbx_type = new System.Windows.Forms.TextBox();
            this.btn_COnfirm = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_name.Location = new System.Drawing.Point(309, 37);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(30, 34);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(302, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "نوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(250, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "(km)فاصله ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(264, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "توضیحات";
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_name.Location = new System.Drawing.Point(12, 29);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(232, 36);
            this.tbx_name.TabIndex = 0;
            this.tbx_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_distance
            // 
            this.tbx_distance.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_distance.Location = new System.Drawing.Point(12, 121);
            this.tbx_distance.Name = "tbx_distance";
            this.tbx_distance.Size = new System.Drawing.Size(232, 36);
            this.tbx_distance.TabIndex = 2;
            this.tbx_distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_distance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_distance_KeyPress);
            // 
            // tbx_describtion
            // 
            this.tbx_describtion.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_describtion.Location = new System.Drawing.Point(12, 167);
            this.tbx_describtion.Multiline = true;
            this.tbx_describtion.Name = "tbx_describtion";
            this.tbx_describtion.Size = new System.Drawing.Size(232, 82);
            this.tbx_describtion.TabIndex = 3;
            this.tbx_describtion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_type
            // 
            this.tbx_type.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_type.Location = new System.Drawing.Point(12, 75);
            this.tbx_type.Name = "tbx_type";
            this.tbx_type.Size = new System.Drawing.Size(232, 36);
            this.tbx_type.TabIndex = 1;
            this.tbx_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_COnfirm
            // 
            this.btn_COnfirm.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_COnfirm.Location = new System.Drawing.Point(12, 267);
            this.btn_COnfirm.Name = "btn_COnfirm";
            this.btn_COnfirm.Size = new System.Drawing.Size(113, 34);
            this.btn_COnfirm.TabIndex = 4;
            this.btn_COnfirm.Text = "تایید";
            this.btn_COnfirm.UseVisualStyleBackColor = true;
            this.btn_COnfirm.Click += new System.EventHandler(this.btn_COnfirm_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(131, 267);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(113, 34);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // addDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 313);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_COnfirm);
            this.Controls.Add(this.tbx_type);
            this.Controls.Add(this.tbx_describtion);
            this.Controls.Add(this.tbx_distance);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Name = "addDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دستگاه جدید";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_distance;
        private System.Windows.Forms.TextBox tbx_describtion;
        private System.Windows.Forms.TextBox tbx_type;
        private System.Windows.Forms.Button btn_COnfirm;
        private System.Windows.Forms.Button btn_exit;
    }
}