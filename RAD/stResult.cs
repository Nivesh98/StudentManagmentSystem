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
    public partial class stResult : Form
    {
        public stResult()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-2PVJRHG4;Initial Catalog=RAD;Integrated Security=True");

        private void stResult_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com = new SqlCommand("SELECT S001, S002, S003, S004, S005, S006, S007, S008 FROM Result WHERE Reg_No ='St001'", con);
            //com.Parameters.AddWithValue("@ID", logPg.uname);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                /* s1.Text = dr.GetValue(0).ToString();
                 s2.Text = dr.GetValue(1).ToString();
                 s3.Text = dr.GetValue(2).ToString();
                 s4.Text = dr.GetValue(3).ToString();
                 s5.Text = dr.GetValue(4).ToString();
                 s6.Text = dr.GetValue(5).ToString();
                 s7.Text = dr.GetValue(6).ToString();
                 s8.Text = dr.GetValue(7).ToString();*/
                String[] ar = new String[8];
                for (int i = 0; i < ar.Length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 85)
                        {
                            ar[i] = "A+";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 75)
                        {
                            ar[i] = "A";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 70)
                        {
                            ar[i] = "A-";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 65)
                        {
                            ar[i] = "B+";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 60)
                        {
                            ar[i] = "B";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 55)
                        {
                            ar[i] = "B-";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 50)
                        {
                            ar[i] = "C+";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 45)
                        {
                            ar[i] = "C";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 40)
                        {
                            ar[i] = "C-";
                            break;
                        }
                        else
                        {
                            ar[i] = "Fail";

                        }
                    }

                }
                s1.Text = ar[0];
                s2.Text = ar[1];
                s3.Text = ar[2];
                s4.Text = ar[3];
                s5.Text = ar[4];
                s6.Text = ar[5];
                s7.Text = ar[6];
                s8.Text = ar[7];

                double total = (0);
                double gc = (0);
                double totalCredit = 20;

                for (int i = 0; i < ar.Length; i++)
                {

                    if (i == 0)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (2 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (2 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (2 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (2 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (2 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (2 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (2 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (2 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (2 * 2);
                        }
                        else
                        {
                            gc = (2 * 1.7);
                        }
                    }
                    else if (i == 1)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (3 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (3 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (3 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (3 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (3 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (3 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (3 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (3 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (3 * 2);
                        }
                        else
                        {
                            gc = (3 * 1.7);
                        }
                    }
                    else if (i == 2)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (3 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (3 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (3 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (3 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (3 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (3 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (3 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (3 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (3 * 2);
                        }
                        else
                        {
                            gc = (3 * 1.7);
                        }
                    }
                    else if (i == 3)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (2 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (2 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (2 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (2 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (2 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (2 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (2 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (2 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (2 * 2);
                        }
                        else
                        {
                            gc = (2 * 1.7);
                        }
                    }
                    else if (i == 4)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (3 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (3 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (3 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (3 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (3 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (3 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (3 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (3 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (3 * 2);
                        }
                        else
                        {
                            gc = (3 * 1.7);
                        }
                    }
                    else if (i == 5)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (3 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (3 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (3 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (3 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (3 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (3 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (3 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (3 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (3 * 2);
                        }
                        else
                        {
                            gc = (3 * 1.7);
                        }
                    }
                    else if (i == 6)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (2 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (2 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (2 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (2 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (2 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (2 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (2 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (2 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (2 * 2);
                        }
                        else
                        {
                            gc = (2 * 1.7);
                        }
                    }
                    else if (i == 7)
                    {
                        if (ar[i] == "A+")
                        {
                            gc = (2 * 4.2);
                        }
                        else if (ar[i] == "A")
                        {
                            gc = (2 * 3.7);
                        }
                        else if (ar[i] == "A-")
                        {
                            gc = (2 * 3.5);
                        }
                        else if (ar[i] == "B+")
                        {
                            gc = (2 * 3.2);
                        }
                        else if (ar[i] == "B")
                        {
                            gc = (2 * 3.0);
                        }
                        else if (ar[i] == "B-")
                        {
                            gc = (2 * 2.7);
                        }
                        else if (ar[i] == "C+")
                        {
                            gc = (2 * 2.5);
                        }
                        else if (ar[i] == "C")
                        {
                            gc = (2 * 2.3);
                        }
                        else if (ar[i] == "C-")
                        {
                            gc = (2 * 2);
                        }
                        else
                        {
                            gc = (2 * 1.7);
                        }
                    }

                    total = total + gc;

                }
                double fgpa = (total / totalCredit);
                string cl = "";
                if (fgpa > 3.7 && fgpa <= 4.2)
                {
                    cl = " first class";
                }
                else if (fgpa > 3.2 && fgpa < 3.7)
                {
                    cl = " Second Upper ";
                }
                else if (fgpa > 2.7 && fgpa < 3.2)
                {
                    cl = " Second Lower ";
                }
                else
                {
                    cl = " General ";
                }

               // MessageBox.Show(" GPA " + fgpa + " Class is " + cl);

                txtGPA.Text = Convert.ToString(fgpa);
                txtCLASS.Text = cl;
               

            } con.Close();

                 
                //if (Convert.ToInt32(s1.Text) >= 75)
               /* String[] ar = new String[8];
                for (int i = 0; i < ar.Length; i++)
                {
                    for (int j = 0; j<=i; j++)
                    {
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 85)
                        {
                            ar[i] = "A+";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 75)
                        {
                            ar[i] = "A";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 70)
                        {
                            ar[i] = "A-";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 65)
                        {
                            ar[i] = "B+";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 60)
                        {
                            ar[i] = "B";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 55)
                        {
                            ar[i] = "B-";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 50)
                        {
                            ar[i] = "C+";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 45)
                        {
                            ar[i] = "C";
                            break;
                        }
                        if (Convert.ToInt16(dr.GetValue(i).ToString()) >= 40)
                        {
                            ar[i] = "C-";
                            break;
                        }
                        else
                        {
                            ar[i] = "Fail";

                        }
                    }
                                  
                }
                s1.Text = ar[0];
                s2.Text = ar[1];
                s3.Text = ar[2];
                s4.Text = ar[3];
                s5.Text = ar[4];
                s6.Text = ar[5];
                s7.Text = ar[6];
                s8.Text = ar[7];*/


                
            
        }

        private void back2_Click(object sender, EventArgs e)
        {
            stPg s = new stPg();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Do you really want to close the program ?", " Exit ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                stPg s = new stPg();
                s.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
