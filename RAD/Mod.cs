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
    public partial class Mod : Form
    {
        public Mod()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "New " + cbColumn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panSt.Visible = true;
            panLec.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            panLec.Visible = true;
            panSt.Visible = false;


        }

        private void Mod_Load(object sender, EventArgs e)
        {
            Dsply();
            DsplyL();
        }
        public void Dsply()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lecturer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgLec.DataSource = dt;
            con.Close();
        }

        private void btDel2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Lecturer where Reg_No = '"+txtRegNoDel2.Text+"' ";
            cmd.ExecuteNonQuery();
            con.Close();
            Dsply();
            MessageBox.Show("Done");


        }

        private void btUp2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Lecturer set " + cbColumn2.Text + " = '" + txtUpdate2.Text + "' where Reg_No = '" + txtRegNoUp2.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            Dsply();
            MessageBox.Show("Done");

        }
        public void DsplyL()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgSt.DataSource = dt;
            con.Close();
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Student set " + cbColumn.Text + " = '" + txtUpdate.Text + "' where Reg_No = '" +txtRegNoUp.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            DsplyL();
            MessageBox.Show("Done");

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Student where Reg_No = '" + txtRegNoDel.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            DsplyL();
            MessageBox.Show("Done");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPg aPg = new adminPg();
            aPg.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminPg aPg = new adminPg();
            aPg.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            adminPg aPg = new adminPg();
            aPg.Show();
            this.Hide();
    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Do you really want to close the program ?", " Exit ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                adminPg aPg = new adminPg();
                aPg.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {

            }
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtRegNoDel.Text = "";
            txtRegNoDel2.Text = "";
            txtRegNoUp.Text = "";
            txtRegNoUp2.Text = "";
            txtUpdate.Text = "";
            txtUpdate2.Text = "";
            cbColumn.Text = "";
            cbColumn2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtRegNoDel.Text = "";
            txtRegNoDel2.Text = "";
            txtRegNoUp.Text = "";
            txtRegNoUp2.Text = "";
            txtUpdate.Text = "";
            txtUpdate2.Text = "";
            cbColumn.Text = "";
            cbColumn2.Text = "";

        }
         
        

    }
}
