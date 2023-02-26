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
    public partial class RegPg : Form
    {
        public RegPg()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRegno_TextChanged(object sender, EventArgs e)
        {
          txtUname.Text = txtRegno.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txtUnameL.Text = txtRegnoL.Text;
        }

        private void SubmitL_Click(object sender, EventArgs e)
        {
             if(txtRegnoL.Text == "")
            {
                MessageBox.Show("Feilds cannot be Empty.");
            }
            else if (txtNameL.Text == "")
            {
                MessageBox.Show("Feilds cannot be Empty.");
            }
            else if (txtMobL.Text == "")
            {
                MessageBox.Show("Feilds cannot be Empty.");
            }
            else if (txtMailL.Text == "")
            {
                MessageBox.Show("Feilds cannot be Empty.");
            }
            else if (depL.Text == "Select a Department")
            {
                MessageBox.Show("Please Select a Department.");
            }
             else if (txtPwordL.Text == "")
             {
                 MessageBox.Show("Fields cannot be Empty");
             }
             else
             {
                 String nameL = txtNameL.Text;
                 String regNoL = txtRegnoL.Text;
                 String emailL = txtMailL.Text;
                 String regDateL = dbRegdateL.Text;
                 String depL1;
                 if (depL.Text == "Department of Information Technology")
                 {
                     depL1 = "D01";
                 }
                 else
                 {
                     depL1 = "D02";
                 }
                 String mobiL = txtMobL.Text;
                 String unameL = txtUnameL.Text;
                 String pwordL = txtPwordL.Text;
                 String Cou1L, Cou2L, Cou3L;
                 Cou1L = cb1L.Text;
                 Cou2L = cb2L.Text;
                 Cou3L = cb3L.Text;

                 SqlCommand cmd = new SqlCommand("INSERT INTO Lecturer VALUES (@regNo, @name, @dep, @email, @mod1, @mod2, @mod3, @uname, @pword, @mobile, @regDate)", con);
                 cmd.CommandType = CommandType.Text;
                 cmd.Parameters.AddWithValue("@regNo", regNoL);
                 cmd.Parameters.AddWithValue("@name", nameL);
                 cmd.Parameters.AddWithValue("@dep", depL1);
                 cmd.Parameters.AddWithValue("@mod1", Cou1L);
                 cmd.Parameters.AddWithValue("@mod2", Cou2L);
                 cmd.Parameters.AddWithValue("@mod3", Cou3L);
                 cmd.Parameters.AddWithValue("@email", emailL);
                 cmd.Parameters.AddWithValue("@uname", unameL);
                 cmd.Parameters.AddWithValue("@pword", pwordL);
                 cmd.Parameters.AddWithValue("@mobile", mobiL);
                 cmd.Parameters.AddWithValue("@regDate", regDateL);
                 


                 

                 con.Open();
                 cmd.ExecuteNonQuery();
                // cmd1.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("Data Saved.", "Data", MessageBoxButtons.OK);
             }
        }

        private void submitS_Click(object sender, EventArgs e)
        {
            if (txtRegno.Text == "")
            {
                MessageBox.Show("Fields cannot be Empty");
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Fields cannot be Empty");
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("Fields cannot be Empty");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Fields cannot be Empty");
            }
            else if (txtAdd.Text == "")
            {
                MessageBox.Show("Fields cannot be Empty");
            }
            else if (Dep.Text == "Select a Department")
            {
                MessageBox.Show("Please select a department");
            }
            else if (txtPword.Text == "")
            {
                 MessageBox.Show("Fields cannot be Empty");
            }
           

            else
            {
                String name = txtName.Text;
                String regNo = txtRegno.Text;
                String age = txtAge.Text;
                String gender;
                //  bool isChekcked = rbMale.Checked;
                if (rbm.Checked)
                {
                    gender = rbm.Text;
                }
                else
                {
                    gender = rbf.Text;
                }

                String bdate = txtDate.Text;
                String email = txtEmail.Text;
                String address = txtAdd.Text;
                String regDate = txtRegdate.Text;
                String dep;
                if (Dep.Text == "Department of Information Technology")
                {
                    dep = "D01";
                }
                else
                {
                    dep = "D02";
                }
                String mobi = txtMob.Text;
                String Cou1, Cou2, Cou3, Cou4, Cou5, Cou6, Cou7, Cou8;
                Cou1 = c1.Text;
                Cou2 = c2.Text;
                Cou3 = c3.Text;
                Cou4 = c4.Text;
                Cou5 = c5.Text;
                Cou6 = c6.Text;
                Cou7 = c7.Text;
                Cou8 = c8.Text;
                String unameS = txtUname.Text;
                String pwordS = txtPword.Text;

                SqlCommand cmd = new SqlCommand("INSERT INTO Student VALUES (@regNo, @name, @cou, @sub, @age, @dob, @address, @email, @mobile, @gen, @uname, @pword, @regDate)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@regNo", regNo);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@cou", dep);
                cmd.Parameters.AddWithValue("@sub", Cou1 + "," + Cou2 + "," + Cou3 + "," + Cou4 + "," + Cou5 + "," + Cou6 + "," + Cou7 + "," + Cou8);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@dob", bdate);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobile", mobi);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@uname", unameS);
                cmd.Parameters.AddWithValue("@pword", pwordS);
                cmd.Parameters.AddWithValue("@regDate", regDate);

                


                /*con.Open();
                 cmd.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("Data Saved.", "Data", MessageBoxButtons.OK);*/

               /* SqlCommand cmd1 = new SqlCommand("INSERT INTO Result (Reg_No)  VALUES (@regNo)", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@regNo", regNo);*/
                //cmd1.Parameters.AddWithValue("@regDate", regDate);

                con.Open();
                cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved.", "Data", MessageBoxButtons.OK);

            }
        }

        private void backL_Click(object sender, EventArgs e)
        {
            adminPg aPg = new adminPg();
            aPg.Show();
            this.Hide();
        }
 
        private void backS_Click(object sender, EventArgs e)
        {
            adminPg aPg = new adminPg();
            aPg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtMob.Text = "";
            txtName.Text = "";
            txtRegno.Text = "";
            Dep.Text = "Select a Department";
            c1.Text = "Subject Code";
            c2.Text = "Subject Code";
            c3.Text = "Subject Code";
            c4.Text = "Subject Code";
            c5.Text = "Subject Code";
            c6.Text = "Subject Code";
            c7.Text = "Subject Code";
            c8.Text = "Subject Code";
            txtAdd.Text = "";
            txtAge.Text = "";
            rbf.Checked = false;
            rbm.Checked = false;
            txtPword.Text = "";
            txtPword.Text = "";
        }

        private void backS_Click_1(object sender, EventArgs e)
        {
            adminPg aPg = new adminPg();
            aPg.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtMailL.Text = "";
            txtMobL.Text = "";
            txtNameL.Text = "";
            txtRegnoL.Text = "";
            depL.Text = "Select a Department";
            cb1L.Text = "Course Code";
            cb2L.Text = "Course Code";
            cb3L.Text = "Course Code";
            txtPwordL.Text = "";
            txtUnameL.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
