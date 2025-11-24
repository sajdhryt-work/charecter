using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonClass
{
    public partial class frmDataGridView : Form
    {
        public List<Person> people = new List<Person>();
        public frmDataGridView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAdd = new frmAddPerson();
            frmAdd.ShowDialog();
            FillDgvPerson();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDgvPerson();
        }

        private void FillDgvPerson()
        {
            dgvPerson.DataSource = people.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                int key = dgvPerson.SelectedRows[0].Index;

                people.RemoveAt(key);
                FillDgvPerson();
            }
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                int rowIndex = dgvPerson.CurrentCell.RowIndex;
                var frmEdit = new frmAddPerson(people[rowIndex]);
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    FillDgvPerson(); 
                }

            }
            else
                MessageBox.Show("choss one Row");
        }
    }
}
