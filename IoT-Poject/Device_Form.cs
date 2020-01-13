using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Poject
{
    public partial class Device_Form : Form
    {
        public Device_Form()
        {
            InitializeComponent();
        }

        private void Device_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioT_DBDataSet.tbl_Devices' table. You can move, or remove it, as needed.
            this.tbl_DevicesTableAdapter.Fill(this.ioT_DBDataSet.tbl_Devices);

            DataGridViewButtonColumn sendmessage = new DataGridViewButtonColumn();
            sendmessage.Name = "uplink";
            sendmessage.Text = "uplink";
            sendmessage.UseColumnTextForButtonValue = true;
            int columnIndex = 5;
            if (dgv_device.Columns["uplink"] == null)
            {
                dgv_device.Columns.Insert(columnIndex, sendmessage);
            }

            DataGridViewButtonColumn downlinkMesaage = new DataGridViewButtonColumn();
            downlinkMesaage.Name = "downlink";
            downlinkMesaage.Text = "downlink";
            downlinkMesaage.UseColumnTextForButtonValue = true;
            int columnIndex2 = 6;
            if (dgv_device.Columns["downlink"] == null)
            {
                dgv_device.Columns.Insert(columnIndex2, downlinkMesaage);
            }

        }

        private void dgv_device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_device.Columns["uplink"].Index)
            {
                string deviceName = dgv_device.Rows[e.RowIndex].Cells[1].Value.ToString();
                int code = Convert.ToInt32(dgv_device.Rows[e.RowIndex].Cells[0].Value.ToString());     
                new UplinkMessage_Form(code , deviceName).Show();
            }else if (e.ColumnIndex == dgv_device.Columns["downlink"].Index)
            {
                string deviceName = dgv_device.Rows[e.RowIndex].Cells[1].Value.ToString();
                int code = Convert.ToInt32(dgv_device.Rows[e.RowIndex].Cells[0].Value.ToString());
                new DownlinkMessage_Form(code, deviceName).Show();
                //MessageBox.Show(code.ToString());
            }
        }
    }
}
