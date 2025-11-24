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
    public partial class frmAddPerson : Form
    {
        private Person editingPerson = null;
        public frmAddPerson()
        {
            InitializeComponent();
        }
        public frmAddPerson(Person person)
        {
            InitializeComponent();
            editingPerson = person;

            txtName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtNationalId.Text = person.NationalId;
            txtGender.Text = person.Gender;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var frmDvg = Application.OpenForms[nameof(frmDataGridView)] as frmDataGridView;
            if (editingPerson == null)
            {
                frmDvg.Text = "Add Person";

                var person = new Person
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    NationalId = txtNationalId.Text,
                    Gender = txtGender.Text
                };
                
                frmDvg.people.Add(person);
            }
            else
            {
                frmDvg.Text = "Edit Person";

                editingPerson.FirstName = txtName.Text;
                editingPerson.LastName = txtLastName.Text;
                editingPerson.NationalId = txtNationalId.Text;
                editingPerson.Gender = txtGender.Text;
                this.Close();
            }
        }
    }
}
