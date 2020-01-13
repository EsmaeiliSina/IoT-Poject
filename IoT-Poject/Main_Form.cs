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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            new addDevice().Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Device_Form().Show();
        }

        private void btn_message_Click(object sender, EventArgs e)
        {
            new Messages().Show();
        }
    }
}
