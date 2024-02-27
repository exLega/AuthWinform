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
    public partial class PacientInfo : Form
    {
        public PacientInfo()
        {
            InitializeComponent();
        }

        public void LoadData() 
        {
            dataGridView1.DataSource = MedicinaEntities.GetContext().Pacient.
                Join(MedicinaEntities.GetContext().Pasport, h => h.pasport_id, j => j.id, (h, j) => new PacientView { Name = j.name, Surname = j.surname, Id = h.id }).ToList();
        }

        private void Onload(object sender, EventArgs e)
        {
            LoadData();
        }
    }

    class PacientView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Number { get; set; }
    }
}
