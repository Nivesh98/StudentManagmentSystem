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
    public partial class lstDtails : Form
    {
        public lstDtails()
        {
            InitializeComponent();
        }

        private void lstDtails_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");
     
        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com = new SqlCommand("SELECT Full_Name, Course_ID, Age, Address, Email, Mobile_No, Gender, DOB, Reg_Date FROM Student WHERE Reg_No =  '" + textBox1.Text + "' ", con);
            // com.Parameters.AddWithValue("@ID", textBox1.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {

                label13.Text = dr.GetValue(0).ToString();
                label14.Text = dr.GetValue(2).ToString();
                label15.Text = dr.GetValue(7).ToString();
                label16.Text = dr.GetValue(6).ToString();
                label17.Text = dr.GetValue(4).ToString();
                label18.Text = dr.GetValue(5).ToString();
                label19.Text = dr.GetValue(3).ToString();
                label20.Text = dr.GetValue(1).ToString();
                label12.Text = dr.GetValue(8).ToString();

            }
            con.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgS.Visible = true;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgS.DataSource = dt;
            con.Close();
            back2.Visible = true;

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            LecPg aPg = new LecPg();
            aPg.Show();
            this.Hide();

        }

        private void back2_Click_1(object sender, EventArgs e)
        {
            dgS.Hide();
            back2.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Do you really want to close the program ?", " Exit ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dgS.Hide();
                back2.Visible = false;
            }
            else if (dialog == DialogResult.No)
            {

            }
            

        }
    }
}
