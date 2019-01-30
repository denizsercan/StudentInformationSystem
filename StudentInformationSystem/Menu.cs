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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Courses f3 = new Courses();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GpaCalculator f4 = new GpaCalculator();
            f4.Show();
        }

       

    }
}
