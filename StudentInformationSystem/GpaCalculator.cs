using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class GpaCalculator : Form
    {
        private Dictionary<string, double> courseInfo = new Dictionary<string, double>();
        private ListViewItem lvItem;
        public GpaCalculator()
        {
            InitializeComponent();
            string CurrentUser = User.UserName;

        }

        private void NotHesaplama_Load(object sender, EventArgs e)
        {
            LoadCourseInfo();
            // Add a few items to the combo box list.
            this.cbListViewCombo.Items.Add("AA");
            this.cbListViewCombo.Items.Add("BA");
            this.cbListViewCombo.Items.Add("BB");
            this.cbListViewCombo.Items.Add("CB");
            this.cbListViewCombo.Items.Add("CC");
            this.cbListViewCombo.Items.Add("DC");
            this.cbListViewCombo.Items.Add("DD");
            this.cbListViewCombo.Items.Add("FD");
            this.cbListViewCombo.Items.Add("FF");

            // Set view of ListView to Details.
            this.myListView1.View = View.Details;

            // Turn on full row select.
            this.myListView1.FullRowSelect = true;

            //ListViewItem listviewitem;
            DataTable dtSel = DAL.Select("SELECT DISTINCT Course.Grade,Course.Credit,Course.course_Desc from Course");
            foreach (DataRow item in dtSel.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(item["Credit"].ToString());
                lvi.SubItems.Add(item["course_Desc"].ToString());
                myListView1.Items.Add(lvi);
            }

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in this.myListView1.Columns)
            {
                ch.Width = -2;
            }
        }

        private void LoadCourseInfo()
        {
            courseInfo.Add("AA", 4.0);
            courseInfo.Add("BA", 3.5);
            courseInfo.Add("BB", 3.0);
            courseInfo.Add("CB", 2.5);
            courseInfo.Add("CC", 2.0);
            courseInfo.Add("DC", 1.5);
            courseInfo.Add("DD", 1.0);
            courseInfo.Add("FD", 0.5);
            courseInfo.Add("FF", 0.0);
        }

        private void cbListViewCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            // Set text of ListView item to match the ComboBox.
            lvItem.Text = this.cbListViewCombo.Text;

            // Hide the ComboBox.
            this.cbListViewCombo.Visible = false;
        }

        private void cbListViewCombo_Leave(object sender, EventArgs e)
        {
            // Set text of ListView item to match the ComboBox.
            lvItem.Text = this.cbListViewCombo.Text;

            // Hide the ComboBox.
            this.cbListViewCombo.Visible = false;
        }

        private void cbListViewCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the user presses ESC.
            switch (e.KeyChar)
            {
                case (char)(int)Keys.Escape:
                    {
                        // Reset the original text value, and then hide the ComboBox.
                        this.cbListViewCombo.Text = lvItem.Text;
                        this.cbListViewCombo.Visible = false;
                        break;
                    }

                case (char)(int)Keys.Enter:
                    {
                        // Hide the ComboBox.
                        this.cbListViewCombo.Visible = false;
                        break;
                    }
            }
        }

        private void myListView1_MouseUp(object sender, MouseEventArgs e)
        {
            // Get the item on the row that is clicked.
            lvItem = this.myListView1.GetItemAt(e.X, e.Y);

            // Make sure that an item is clicked.
            if (lvItem != null)
            {
                // Get the bounds of the item that is clicked.
                Rectangle ClickedItem = lvItem.Bounds;

                // Verify that the column is completely scrolled off to the left.
                if ((ClickedItem.Left + this.myListView1.Columns[0].Width) < 0)
                {
                    // If the cell is out of view to the left, do nothing.
                    return;
                }

                // Verify that the column is partially scrolled off to the left.
                else if (ClickedItem.Left < 0)
                {
                    // Determine if column extends beyond right side of ListView.
                    if ((ClickedItem.Left + this.myListView1.Columns[0].Width) > this.myListView1.Width)
                    {
                        // Set width of column to match width of ListView.
                        ClickedItem.Width = this.myListView1.Width;
                        ClickedItem.X = 0;
                    }
                    else
                    {
                        // Right side of cell is in view.
                        ClickedItem.Width = this.myListView1.Columns[0].Width + ClickedItem.Left;
                        ClickedItem.X = 2;
                    }
                }
                else if (this.myListView1.Columns[0].Width > this.myListView1.Width)
                {
                    ClickedItem.Width = this.myListView1.Width;
                }
                else
                {
                    ClickedItem.Width = this.myListView1.Columns[0].Width;
                    ClickedItem.X = 2;
                }

                // Adjust the top to account for the location of the ListView.
                ClickedItem.Y += this.myListView1.Top;
                ClickedItem.X += this.myListView1.Left;

                // Assign calculated bounds to the ComboBox.
                this.cbListViewCombo.Bounds = ClickedItem;

                // Set default text for ComboBox to match the item that is clicked.
                this.cbListViewCombo.Text = lvItem.Text;

                // Display the ComboBox, and make sure that it is on top with focus.
                this.cbListViewCombo.Visible = true;
                this.cbListViewCombo.BringToFront();
                this.cbListViewCombo.Focus();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (myListView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in myListView1.SelectedItems)
                {
                    myListView1.Items.Remove(item);
                }
            }
        }

        private void BtnRef_Click(object sender, EventArgs e)
        {
            myListView1.Items.Clear();
            DataTable dtSel = DAL.Select("SELECT DISTINCT Course.Grade,Course.Credit,Course.course_Desc from Course");
            foreach (DataRow item in dtSel.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(item["Credit"].ToString());
                lvi.SubItems.Add(item["course_Desc"].ToString());
                myListView1.Items.Add(lvi);
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            double count_course = 0.0;

            int sum_credit = myListView1.Items[1].SubItems.Count;
            double sumDbl = 0;

            foreach (ListViewItem item in myListView1.Items)
                if (courseInfo.ContainsKey(item.SubItems[0].Text))
                {
                    //count_course += courseInfo[item.SubItems[0].Text];
                    count_course += Convert.ToDouble(item.SubItems[1].Text);
                    sumDbl += (courseInfo[item.SubItems[0].Text]) * Convert.ToDouble(item.SubItems[1].Text);
                }

            int count_row = myListView1.Items.Count;
            double avg = sumDbl / count_course;
            MessageBox.Show("Ortalama = "+ avg.ToString());
        }

    }
}

