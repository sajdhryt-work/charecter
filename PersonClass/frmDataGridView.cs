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
        PersonManager personManager;
        public frmDataGridView()
        {
            InitializeComponent();
            personManager = new PersonManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDgvPerson();
        }
        private void FillDgvPerson()
        {
            dgvPerson.DataSource = personManager.GetPeople().ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAdd = new frmAddPerson()
            {
                Text = "Add Person",
            };

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                FillDgvPerson();
            }
        }

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == dgvPerson.Columns[ColDelete.Name].Index)
            {
                var result = AlertHelper.Question("Are you sure to delete this person?");
                if (result == DialogResult.No)
                    return;
                var person = dgvPerson.Rows[e.RowIndex].DataBoundItem as Person;
                if (person != null)
                {
                    personManager.RemovePerson(person);
                    FillDgvPerson();
                }
            }

            else if(e.ColumnIndex == dgvPerson.Columns[ColEdit.Name].Index)
            {              
                var person = dgvPerson.Rows[e.RowIndex].DataBoundItem as Person;
                frmAddPerson frmAdd = new frmAddPerson()
                {
                    Text = $"Edit {person.FullName}",
                    personEditing = person
                };

                if (frmAdd.ShowDialog() == DialogResult.OK)
                {
                    FillDgvPerson();
                }
            }
        }
    }
}
