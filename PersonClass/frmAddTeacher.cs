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
    public partial class frmAddTeacher : Form
    {

        public Teacher TeacherEditing { get; set; }
        TeacherManager teacherManager;

        Action _action;

        public frmAddTeacher(Action action)
        {
            InitializeComponent();
            teacherManager = new TeacherManager();
            _action = action;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox Tb = sender as TextBox;
            if (Tb != null)
            {
                Tb.BackColor = Color.LightCyan;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox Tb = sender as TextBox;
            if (Tb != null)
            {
                Tb.BackColor = Color.White;
            }
        }

        private void frmAddTeacher_Load(object sender, EventArgs e)
        {
            if (TeacherEditing != null)
            {
                txtName.Text = TeacherEditing.FirstName;
                txtLastName.Text = TeacherEditing.LastName;
                txtNationalId.Text = TeacherEditing.NationalId;
                if (TeacherEditing.Gender == Genders.man)
                    txtGender.Text = "man";
                else if (TeacherEditing.Gender == Genders.woman)
                    txtGender.Text = "woman";
                txtPhonNumber.Text = TeacherEditing.PhonNumber;
                txtMajor.Text = TeacherEditing.Major;
                txtAddrres.Text = TeacherEditing.Addrres;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Teacher teacher;

            if (TeacherEditing != null)
            {
                teacher = TeacherEditing;
            }
            else
            {
                teacher = new Teacher();
            }

            teacher.FirstName = txtName.Text;
            teacher.LastName = txtLastName.Text;
            teacher.NationalId = txtNationalId.Text;

            if (txtGender.Text == "man")
                teacher.Gender = Genders.man;
            else if (txtGender.Text == "woman")
                teacher.Gender = Genders.woman;
            else
                teacher.Gender = Genders.unknow;
            teacher.Major = txtMajor.Text;
            teacher.PhonNumber = txtPhonNumber.Text;
            teacher.Addrres = txtAddrres.Text;


            if (TeacherEditing == null)
            {
                var isValide = teacherManager.Validate(teacher);
                if (isValide.IsSuccess)
                    teacherManager.Add(teacher);
                else
                    MessageBox.Show(isValide.Message, "warning", MessageBoxButtons.RetryCancel);
            }
            _action?.Invoke();


        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);

            this.Close();
        }
    }
}
