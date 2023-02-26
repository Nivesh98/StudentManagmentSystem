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
    public partial class AddMarks : Form
    {
        public AddMarks()
        {
            InitializeComponent();
           
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "Select * from Result where Reg_No = '" + txtRegno.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                double  ass1, ass2, ass3, m1, m2, m3;
                string tot1, tot2, tot3;

                if (txtSub2.Visible == true && txtSub3.Visible == true)
                {//////////////////////////////////
                    if (txtSub1.Text == "" && txtSub2.Text == "" && txtSub3.Text == "" && Ass1.Text == "" && Ass2.Text == "" && Ass3.Text == "")
                    { MessageBox.Show("Enter Exam Marks & Assignment Marks."); }
                    else if (txtSub3.Text == "" && Ass3.Text == "" && txtSub2.Text == "" && Ass2.Text == "")
                    {
                        if (Ass1.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered444444444444444444444");
                        }
                        else
                        {
                            m1 = Convert.ToDouble(txtSub1.Text);
                            ass1 = Convert.ToDouble(Ass1.Text);
                            tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        }
                    }
                    else if (txtSub3.Text == "" && Ass3.Text == "" && txtSub1.Text == "" && Ass1.Text == "")
                    {
                        if (Ass2.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered3333333333333333333333");
                        }
                        else
                        {
                            m2 = Convert.ToDouble(txtSub2.Text);
                            ass2 = Convert.ToDouble(Ass2.Text);
                            tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label3.Text + " = '" + tot2 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        }
                    }
                    else if (txtSub2.Text == "" && Ass2.Text == "" && txtSub1.Text == "" && Ass1.Text == "")
                    {
                        if (Ass3.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered2222222222222222");
                        }
                        else
                        {
                            m3 = Convert.ToDouble(txtSub3.Text);
                            ass3 = Convert.ToDouble(Ass3.Text);
                            tot3 = Convert.ToString((m3 * 0.7) + (ass3 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label4.Text + " = '" + tot3 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        }
                    }
                    else if (txtSub3.Text == "" && Ass3.Text == "")
                    {
                        if (Ass1.Text == "" || Ass2.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered777777777777777777");
                        }
                        else
                        {
                            m1 = Convert.ToDouble(txtSub1.Text);
                            m2 = Convert.ToDouble(txtSub2.Text);
                            ass1 = Convert.ToDouble(Ass1.Text);
                            ass2 = Convert.ToDouble(Ass2.Text);
                            tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                            tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'," + label3.Text + "  = '" + tot2 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        }
             
                    }
                    else if (txtSub2.Text == "" && Ass2.Text == "")
                    {
                        if (Ass1.Text == "" || Ass3.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered66666666666666666666");
                        }
                        else
                        {
                            m1 = Convert.ToDouble(txtSub1.Text);
                            m3 = Convert.ToDouble(txtSub3.Text);
                            ass1 = Convert.ToDouble(Ass1.Text);
                            ass3 = Convert.ToDouble(Ass3.Text);
                            tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                            tot3 = Convert.ToString((m3 * 0.7) + (ass3 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "', " + label4.Text + "  = '" + tot3 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        }
                        
                    }
                    else if (txtSub1.Text == "" && Ass1.Text == "")
                    {
                        if (Ass2.Text == "" || Ass3.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered55555555555555555");
                        }
                        else
                        {
                            m2 = Convert.ToDouble(txtSub2.Text);
                            m3 = Convert.ToDouble(txtSub3.Text);
                            ass2 = Convert.ToDouble(Ass2.Text);
                            ass3 = Convert.ToDouble(Ass3.Text);
                            tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                            tot3 = Convert.ToString((m3 * 0.7) + (ass3 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label3.Text + "  = '" + tot2 + "', " + label4.Text + "  = '" + tot3 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        }
                        
 
                    }
                   
                    else
                    {
                       
                        if (Ass2.Text == "" || Ass3.Text == "" || Ass1.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered111111111111111111111");
                        }
                        else
                        {
                            m1 = Convert.ToDouble(txtSub1.Text);
                            m2 = Convert.ToDouble(txtSub2.Text);
                            m3 = Convert.ToDouble(txtSub3.Text);
                            ass1 = Convert.ToDouble(Ass1.Text);
                            ass2 = Convert.ToDouble(Ass2.Text);
                            ass3 = Convert.ToDouble(Ass3.Text);
                            tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                            tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                            tot3 = Convert.ToString((m3 * 0.7) + (ass3 * 0.3));


                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'," + label3.Text + "  = '" + tot2 + "', " + label4.Text + "  = '" + tot3 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        
                        }
                       
                        
                    }


//////////////////////////////////////////////////////////////////
                    /////////////////////////////////
                  /*  m1 = Convert.ToDouble(txtSub1.Text);
                    m2 = Convert.ToDouble(txtSub2.Text);
                    m3 = Convert.ToDouble(txtSub3.Text);
                    ass1 = Convert.ToDouble(Ass1.Text);
                    ass2 = Convert.ToDouble(Ass2.Text);
                    ass3 = Convert.ToDouble(Ass3.Text);
                    tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                    tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                    tot3 = Convert.ToString((m3 * 0.7) + (ass3 * 0.3));


                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update Result set " + label2.Text + " = '" +tot1+ "'," + label3.Text + "  = '" + tot2 + "', " + label4.Text + "  = '" + tot3 + "'where Reg_No = '" + txtRegno.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DsplyMks();
                    MessageBox.Show("Done");*/
                }
                else if (txtSub2.Visible == true)
                {////////////////////////////////////////////////
                    if (txtSub2.Text == "")
                    {
                        if (Ass1.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered");
                        }
                        else 
                        {
                            m1 = Convert.ToDouble(txtSub1.Text);
                            ass1 = Convert.ToDouble(Ass1.Text);
                            tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        
                        }
                    }
                    else if (txtSub1.Text == "")
                    {
                        if (Ass2.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered");
                        }
                        else
                        {
                            m2 = Convert.ToDouble(txtSub2.Text);
                            ass2 = Convert.ToDouble(Ass2.Text);
                            tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label3.Text + " = '" + tot2 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");
                        }
                    
                    }
                    else
                    {
                        if (Ass2.Text == "" || Ass1.Text == "")
                        {
                            MessageBox.Show("Assignment Marks must entered");
                        }
                        else
                        {
                            m1 = Convert.ToDouble(txtSub1.Text);
                            m2 = Convert.ToDouble(txtSub2.Text);
                            ass1 = Convert.ToDouble(Ass1.Text);
                            ass2 = Convert.ToDouble(Ass2.Text);
                            tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                            tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'," + label3.Text + "  = '" + tot2 + "'where Reg_No = '" + txtRegno.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DsplyMks();
                            MessageBox.Show("Done");

                        }
                      

                    }
                    //////////////////////////
                    /*
                    m1 = Convert.ToDouble(txtSub1.Text);
                    m2 = Convert.ToDouble(txtSub2.Text);
                    ass1 = Convert.ToDouble(Ass1.Text);
                    ass2 = Convert.ToDouble(Ass2.Text);
                    tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                    tot2 = Convert.ToString((m2 * 0.7) + (ass2 * 0.3));
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'," + label3.Text + "  = '" + tot2 + "'where Reg_No = '" + txtRegno.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DsplyMks();
                    MessageBox.Show("Done");*/

                }
                else
                {
                    ///////////////////////////
                    if (Ass1.Text == "")
                    {
                        MessageBox.Show("Assignment Marks must entered");
                    }
                    else
                    {
                        m1 = Convert.ToDouble(txtSub1.Text);
                        ass1 = Convert.ToDouble(Ass1.Text);
                        tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'where Reg_No = '" + txtRegno.Text + "' ";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        DsplyMks();
                        MessageBox.Show("Done");
                    }
                    /////////////////////////////
                    /*
                    m1 = Convert.ToDouble(txtSub1.Text);
                    ass1 = Convert.ToDouble(Ass1.Text);
                    tot1 = Convert.ToString((m1 * 0.7) + (ass1 * 0.3));
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update Result set " + label2.Text + " = '" + tot1 + "'where Reg_No = '" + txtRegno.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DsplyMks();
                    MessageBox.Show("Done");*/
                }


            }
            else
            {
                MessageBox.Show("Invalid Registration Number");
            }



            

            
        }

        public void DsplyMks()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Result";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgMarks.DataSource = dt;
            con.Close();



          /*  string x, y, z;

            con.Open();
            SqlCommand com = new SqlCommand("SELECT Sub_ID1, Sub_ID2, Sub_ID3 FROM Lecturer WHERE Reg_No = @ID", con);
            com.Parameters.AddWithValue("@ID", logPg.uname);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                x = dr.GetValue(0).ToString();
                y = dr.GetValue(1).ToString();
                z = dr.GetValue(2).ToString();
                if (y.Substring(0, 1) == "S" && z.Substring(0, 1) == "S")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select "+x+","+y+","+z+" from Result";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgMarks.DataSource = dt;
                    con.Close();
                }
                else if (y.Substring(0, 1) == "S")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select  " + x + "," + y + " from Result";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgMarks.DataSource = dt;
                    con.Close();

                }
                else
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select  " + x + "," + y + " from Result";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgMarks.DataSource = dt;
                    con.Close();
                    
                }con.Close();


            }*/

        
           
        }

        private void uname_Click(object sender, EventArgs e)
        {
           
        }

        private void AddMarks_Load(object sender, EventArgs e)
        {

            DsplyMks();
            string x, y, z;

            con.Open();
            SqlCommand com = new SqlCommand("SELECT Sub_ID1, Sub_ID2, Sub_ID3 FROM Lecturer WHERE Reg_No = @ID", con);
            com.Parameters.AddWithValue("@ID", logPg.uname);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                x = dr.GetValue(0).ToString();
                y  = dr.GetValue(1).ToString();
                z  = dr.GetValue(2).ToString();

                if (z.Substring(0, 1) == "S")
                {

                    label3.Visible = true;
                    txtSub2.Visible = true;
                    label4.Visible = true;
                    txtSub3.Visible = true;
                    Ass1.Visible = true;
                    Ass2.Visible = true;
                    Ass3.Visible = true;
                    label2.Text = x;
                    label3.Text = y;
                    label4.Text = z;
                    
                }
                if (y.Substring(0, 1) == "S")
                {
                    label3.Visible = true;
                    txtSub2.Visible = true;
                    Ass1.Visible = true;
                    Ass2.Visible = true;
                    label2.Text = x;
                    label3.Text = y;
                
                }
                if (x.Substring(0, 1) == "S")
                {
                    label2.Text = x;
                    label2.Visible = true;
                    txtSub1.Visible = true;
                    Ass1.Visible = true;
                
                }

           
               /* if (z.Substring(0, 1) == "S")
                {
                    
                }
                else
                {
                    if (x.Substring(0, 1) == "S")
                    {
                        label2.Visible = true;
                        txtSub1.Visible = true;
                    }
                    else
                    {
                        if (x.Substring(0, 1) == "S")
                        {
                            label2.Visible = true;
                            txtSub1.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }

                    }
                }*/
            }
            con.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecPg lPg = new LecPg();
            lPg.Show();
            this.Hide();

        }

        private void txtRegno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Do you really want to close the program ?", " Exit ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                LecPg lPg = new LecPg();
                lPg.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {

            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSub1.Text = "";
            txtSub2.Text = "";
            txtSub3.Text = "";
            txtRegno.Text = "";
            Ass1.Text = "";
            Ass2.Text = "";
            Ass3.Text = "";

        }
    }
}
