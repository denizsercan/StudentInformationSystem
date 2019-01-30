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
    public partial class ReporCard : Form
    {
        public ReporCard()
        {
            InitializeComponent();
            string CurrentUser = User.UserName;
            DataTable dtSel = DAL.Select("=" + CurrentUser);
        }
    }
}
