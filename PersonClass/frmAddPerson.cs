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
        public Person personEditing { get; set; }
        PersonManager PersonManager;
        public frmAddPerson()
        {
            InitializeComponent();
            PersonManager = new PersonManager();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
           
                txtName.Text = personEditing.FirstName;
                txtLastName.Text = personEditing.LastName;
                txtNationalId.Text = personEditing.NationalId;
                txtGender.Text = personEditing.Gender;
           
        }
        //public frmAddPerson(Person person)
        //{
        //    InitializeComponent();
        //    personEditing = person;

        //    txtName.Text = person.FirstName;
        //    txtLastName.Text = person.LastName;
        //    txtNationalId.Text = person.NationalId;
        //    txtGender.Text = person.Gender;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isEdit = false;
            if (personEditing == null)
            {
                personEditing = new Person();
            }
            else
            {
                isEdit = true;
            }
            personEditing.FirstName = txtName.Text;
            personEditing.LastName = txtLastName.Text;
            personEditing.NationalId = txtNationalId.Text;
            personEditing.Gender = txtGender.Text;

            if (!isEdit)
            {
                //var isValide = person.Validate();
                //if (isValide.IsSuccess)
                //{
                PersonManager.AddPerson(personEditing);
                //}
                //else
                //{
                //    MessageBox.Show(isValide.Message);
                //}
            }
              
              DialogResult = DialogResult.OK;
               
           
        }

       
    }
}
