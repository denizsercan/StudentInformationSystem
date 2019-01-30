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
    public partial class Courses : Form
    {

        public Courses()
        {
            InitializeComponent();
            string CurrentUser = User.UserName;

             DataTable dtSel = DAL.Select("SELECT DISTINCT Course.course_ID,Course.course_Desc,Course.Grade from Course INNER JOIN Other ON Course.course_ID = Other.course_ID INNER JOIN Student ON Student.Stu_No = Other.Stu_No where Other.Stu_No =" + CurrentUser);

            foreach (DataRow item in dtSel.Rows)
            {
                ListViewItem lvi = new ListViewItem(item["course_ID"].ToString());
                lvi.SubItems.Add(item["course_Desc"].ToString());
                lvi.SubItems.Add(item["Grade"].ToString());
                listView1.Items.Add(lvi);     
                    }
            }

      /*  private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listView1.SelectedItems.Count == 1)
            {

                Form2 f2 = new Form2();
                f2.Show();
            }
     */   }

    }

