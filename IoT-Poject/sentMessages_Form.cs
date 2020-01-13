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
    public partial class sentMessages_Form : Form
    {
        public sentMessages_Form()
        {
            InitializeComponent();
        }

        private void sentMessages_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioT_DBDataSet.tbl_downlinkmessages' table. You can move, or remove it, as needed.
            this.tbl_downlinkmessagesTableAdapter.Fill(this.ioT_DBDataSet.tbl_downlinkmessages);
            // TODO: This line of code loads data into the 'ioT_DBDataSet.tbl_uplinkmessages' table. You can move, or remove it, as needed.
            this.tbl_uplinkmessagesTableAdapter.Fill(this.ioT_DBDataSet.tbl_uplinkmessages);

        }
    }
}
