using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8.Doctor
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void AuthBtn(object sender, EventArgs e)
        {
            var users = MedicinaEntities.GetContext().Doctor.FirstOrDefault(u => u.login == LoginTxtBox.Text && u.password == PasswordTxtBox.Text);
            if (users == null)
            {
                MessageBox.Show("Пользователь не найден");
            }
            else 
            {
                PacientInfo pacientInfo = new PacientInfo();
                pacientInfo.Show();
                Hide();
            }
        }
    }
}
