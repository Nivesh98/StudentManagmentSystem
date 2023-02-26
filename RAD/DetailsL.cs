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
    public partial class DetailsL : Form
    {
        public DetailsL()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {

            
            con.Open();
            SqlCommand com = new SqlCommand("SELECT Full_Name,  Email, Mobile_No, Sub_ID1, Sub_ID2, Sub_ID3, Reg_Date FROM Lecturer WHERE Reg_No = '"+textBox1.Text+"'", con);
           // com.Parameters.AddWithValue("@ID", textBox1.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {

                label13.Text = dr.GetValue(0).ToString();
                label17.Text = dr.GetValue(1).ToString();
                label18.Text = dr.GetValue(2).ToString();
                label14.Text = dr.GetValue(3).ToString();
                label15.Text = dr.GetValue(4).ToString();
                label16.Text = dr.GetValue(5).ToString();
                label12.Text = dr.GetValue(6).ToString();


            }
            con.Close();

            con.Open();
            SqlCommand com2 = new SqlCommand("SELECT Subject_Name FROM Subject WHERE Subject_ID ='"+label14.Text+"'", con);
            //com2.Parameters.AddWithValue("@mc", label14.Text);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                label1.Text = dr2.GetValue(0).ToString();
            }
            con.Close();

            con.Open();
            SqlCommand com3 = new SqlCommand("SELECT Subject_Name FROM Subject WHERE Subject_ID ='" + label15.Text + "'", con);
           // com3.Parameters.AddWithValue("@mc1", label15.Text);
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                label8.Text = dr3.GetValue(0).ToString();
            }
            con.Close();

            con.Open();
            SqlCommand com4 = new SqlCommand("SELECT Subject_Name FROM Subject WHERE Subject_ID ='" + label16.Text + "'", con);
           // com4.Parameters.AddWithValue("@mc2", label16.Text);
            SqlDataReader dr4 = com4.ExecuteReader();
            while (dr4.Read())
            {
                label11.Text = dr4.GetValue(0).ToString();
            }
            con.Close();

           /* con.Open();
            SqlCommand com5 = new SqlCommand("SELECT Dep_Name FROM Department WHERE Dep_ID =@dep", con);
            com5.Parameters.AddWithValue("@dep", label20.Text);
            SqlDataReader dr5 = com5.ExecuteReader();
            while (dr5.Read())
            {
                label21.Text = dr5.GetValue(0).ToString();
            }
            con.Close();*/

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgS.Hide();
            back2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back2.Visible = true;
            dgS.Visible = true;
            dgS.Visible = true;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lecturer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgS.DataSource = dt;
            con.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminPg aPg = new adminPg();
            aPg.Show();
            this.Hide();

        }

        private void dgS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
