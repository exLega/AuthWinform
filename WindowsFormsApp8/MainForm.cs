using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn(object sender, EventArgs e)
        {
            Hide();
            Doctor.Authentication register = new Doctor.Authentication();
            register.Show();
        }
    }
}
