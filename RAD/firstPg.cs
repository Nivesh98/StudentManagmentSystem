using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD
{
    public partial class firstPg : Form
    {
        public firstPg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void firstPg_Load(object sender, EventArgs e)
        {
           //button1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            logPg f2 = new logPg();
            f2.Show();
            button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPg s = new adminPg();
            s.Close();
            this.Close();
        }
    }
}
