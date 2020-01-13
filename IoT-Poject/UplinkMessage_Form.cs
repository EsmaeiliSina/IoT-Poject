using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IoT_Poject.IoT_DBDataSetTableAdapters;

namespace IoT_Poject
{
    public partial class UplinkMessage_Form : Form
    {
        int code = 0;
        string name = "";

        public UplinkMessage_Form(int code, string name)
        {
            InitializeComponent();
            this.code = code;
            this.name = name;
            tbx_code.Text = this.code.ToString();
            tbx_name.Text = this.name;
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            tbl_uplinkmessagesTableAdapter messageTable = new tbl_uplinkmessagesTableAdapter();

            string protocol = "";

            if (rbtn_sigfox.Checked)
            {
                if (System.Text.Encoding.UTF8.GetByteCount(tbx_message.Text) <= 12)
                {
                    protocol = "Sigfox";
                    messageTable.Insert(this.code, protocol, tbx_message.Text);
                    MessageBox.Show("پیام ارسال شد", "تایید", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("طول پیام بیش از حد مجاز", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            if (rbtn_lora.Checked)
            {
                if (System.Text.Encoding.UTF8.GetByteCount(tbx_message.Text) <= 243)
                {
                    protocol = "LoRa";
                    messageTable.Insert(this.code, protocol, tbx_message.Text);
                    MessageBox.Show("پیام ارسال شد", "تایید", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("طول پیام بیش از حد مجاز", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (rbtn_nbiot.Checked)
            {
                if (System.Text.Encoding.UTF8.GetByteCount(tbx_message.Text) <= 1600)
                {
                    protocol = "NB-IoT";
                    messageTable.Insert(this.code, protocol, tbx_message.Text);
                    MessageBox.Show("پیام ارسال شد", "تایید", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("طول پیام بیش از حد مجاز", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

           
        }

        private void rbtn_sigfox_CheckedChanged(object sender, EventArgs e)
        {
            tbx_max.Text = "12 بایت";
        }

        private void rbtn_lora_CheckedChanged(object sender, EventArgs e)
        {
            tbx_max.Text = "243 بایت";
        }

        private void rbtn_nbiot_CheckedChanged(object sender, EventArgs e)
        {
            tbx_max.Text = "1600 بایت";
        }

        private void tbx_message_TextChanged(object sender, EventArgs e)
        {     
            tbx_lengh.Text = System.Text.Encoding.UTF8.GetByteCount(tbx_message.Text).ToString() + " بایت ";
        }
    }
}
