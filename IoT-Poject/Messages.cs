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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            tbl_DevicesTableAdapter          deviceTable       = new tbl_DevicesTableAdapter();
            tbl_uplinkmessagesTableAdapter   uplinkMessage     = new tbl_uplinkmessagesTableAdapter();
            tbl_downlinkmessagesTableAdapter downlinkMessage   = new tbl_downlinkmessagesTableAdapter();
            
            tbx_sigfoxup.Text = uplinkMessage.count("Sigfox").ToString();
            tbx_lora_up.Text  = uplinkMessage.count("LoRa").ToString();
            tbx_nbiot_up.Text = uplinkMessage.count("NB-IoT").ToString();

            tbx_sigfoxdown.Text = downlinkMessage.count("Sigfox").ToString();
            tbx_lora_down.Text = downlinkMessage.count("LoRa").ToString();
            tbx_nbiot_down.Text = downlinkMessage.count("NB-IoT").ToString();
        }
    }
}
