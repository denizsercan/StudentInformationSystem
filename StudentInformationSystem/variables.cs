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
using System.Data.Sql;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationSystem
{
    public partial class Form1 : Form
    {
        private string exHata;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog= StudentInformationSystem;Integrated Security=true");
                    
                baglanti.Open();
                string ID = textBox1.Text;
                string PW = textBox2.Text;
                SqlCommand query = new SqlCommand("SELECT * FROM  STUDENT WHERE ID='"+ID+"' AND PW='"+PW+"'",baglanti);
                SqlDataReader oku = query.ExecuteReader();
                if (oku.Read())
                {
                    
                }




                string sql = "";
                sql = "SELECT ID,PW FROM STUDENT WHERE  ID=@ID AND PW=@PW";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Giris yapıldı");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else if (count > 0)
                {
                    MessageBox.Show("duplicate user name and password");
                }
                else
                {
                    MessageBox.Show("ID yada Password hatalı");
                }
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }


                 /*     try
            {
                SqlConnection baglanti;
                string conn = "Data Source=.;Initial Catalog= StudentInformationSystem;Integrated Security=true;";
                baglanti = new SqlConnection(conn);
                baglanti.Open();
                SqlParameter prm1 = new SqlParameter("@ID", textBox1.Text);
                SqlParameter prm2 = new SqlParameter("@PW", textBox2.Text);

                string sql = "";
                sql = "SELECT ID,PW FROM STUDENT WHERE  ID=@ID AND PW=@PW";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("giris yapıldı");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Hatalı giris");
                }
            }
            catch (Exception ex)
            {
                exHata = ex.Message;
            }


        }
    }
}*/
     
 