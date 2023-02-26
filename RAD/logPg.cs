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
    public partial class logPg : Form
    {
      
       SqlCommand com = new SqlCommand();
        public logPg()
        {
            InitializeComponent();
            
        }
        public static string uname;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");
            String a = textBox1.Text;

            if (a.Substring(0, 1) == "A" || a.Substring(0, 1) == "a")
            {
 
                string query = "Select * from Admin where Username = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    uname = textBox1.Text;
                    adminPg adm = new adminPg();
                    adm.Show();
                    this.Hide();    
                }
                else
                {
                    MessageBox.Show("Please Check your Password or Username");
                }
            }

            else if (a.Substring(0, 1) == "S" )
            {

                string query = "Select * from Student where Username = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    uname = textBox1.Text;
                    stPg spg = new stPg();
                    this.Hide();
                    spg.Show();
                }
                else
                {
                    MessageBox.Show("Please Check your Password or Username");
                }
            }

            else if (a.Substring(0, 1) == "L") 
            {

                string query = "Select * from Lecturer where Username = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    uname = textBox1.Text;
                    LecPg lpg = new LecPg();
                    this.Hide();
                    lpg.Show();
                }
                else
                {
                    MessageBox.Show("Please Check your Password or Username");
                }
            }

            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = @"Username";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = @"Password";
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Do you really want to close the program ?", " Exit ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                firstPg f1 = new firstPg();
                f1.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }

        }

        private void lecRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        

      /*  private void Form2_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }*/

    
    }
}
