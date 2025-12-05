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
        bool isEdit = false;
        bool isReadyToExit = true;

        public frmAddPerson()
        {
            InitializeComponent();
            PersonManager = new PersonManager();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            if (personEditing != null)
            {
                txtName.Text = personEditing.FirstName;
                txtLastName.Text = personEditing.LastName;
                txtNationalId.Text = personEditing.NationalId;
                if (personEditing.Gender == Genders.man)
                    txtGender.Text = "man";
                else if (personEditing.Gender == Genders.woman)
                    txtGender.Text = "woman";
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (personEditing == null || isReadyToExit==false)
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
            if (txtGender.Text.ToLower() == "man")
                personEditing.Gender = Genders.man;
            else if (txtGender.Text.ToLower() == "woman")
                personEditing.Gender = Genders.woman;
            else
                personEditing.Gender = Genders.unknow;

            if (!isEdit)
            {
               
                var isValide = PersonManager.AddPerson(personEditing);
                if (!isValide.IsSuccess)
                {

                    if (MessageBox.Show(isValide.Message, "warning", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    {
                        isReadyToExit = false;
                    }
                   
                }
                 else
                        isReadyToExit = true;

            }
            if (isReadyToExit)
            {
                DialogResult = DialogResult.OK;
            }
   
           
        }

       
    }
}
