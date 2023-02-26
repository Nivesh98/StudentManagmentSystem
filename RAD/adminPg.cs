using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RAD
{
    public partial class adminPg : Form
    {
        public adminPg()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminPg_Load(object sender, EventArgs e)
        {

            //label2.Text = Form1.uname;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");
            con.Open();

            SqlCommand com = new SqlCommand("SELECT Username, Full_Name, Email, mob1, mob2 FROM Admin WHERE Username = @u", con);
            com.Parameters.AddWithValue("@u", logPg.uname);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {

                label3.Text = dr.GetValue(1).ToString();
                label4.Text = dr.GetValue(2).ToString();
                label5.Text = dr.GetValue(3).ToString();
                
                label6.Text = dr.GetValue(4).ToString();

                label8.Text = logPg.uname;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegPg rpg = new RegPg();
            rpg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod mod = new Mod();
            mod.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetailsSt dSt = new DetailsSt();
            dSt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetailsL dLec = new DetailsL();
            dLec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Do you really want to close the program ?", " Exit ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                logPg l = new logPg();
                l.Show();
            }
            else if (dialog == DialogResult.No)
            {

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            logPg l = new logPg();
            l.Show();
        }
    }
}
