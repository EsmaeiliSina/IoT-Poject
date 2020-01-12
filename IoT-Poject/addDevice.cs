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
    public partial class addDevice : Form
    {
        public addDevice()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_COnfirm_Click(object sender, EventArgs e)
        {
            tbl_DevicesTableAdapter deviceTable = new tbl_DevicesTableAdapter();

            deviceTable.Insert1(tbx_name.Text, tbx_type.Text, Convert.ToInt32(tbx_distance.Text), tbx_describtion.Text);
            MessageBox.Show("دستگاه با موفقیت اضافه شد","تایید", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();

        }

        private void tbx_distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
