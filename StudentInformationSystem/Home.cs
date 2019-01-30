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


namespace StudentInformationSystem
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();

        }

        public void button1_Click(object sender, EventArgs e)
        {

            DataTable dtSel = DAL.Select("SELECT Stu_No,PW FROM STUDENT WHERE  Stu_No=@1 AND PW=@2", textBox1.Text, textBox2.Text);
            if (dtSel.Rows.Count > 0)
                User.UserName = dtSel.Rows[0]["Stu_No"].ToString();
     
            if (dtSel.Rows.Count == 1)
            {
                MessageBox.Show("giris yapıldı");
                Menu f2 = new Menu();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giris");
            }
            textBox1.Clear();
            textBox2.Clear();
            
        }
    }
}
