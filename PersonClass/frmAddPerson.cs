using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonClass
{
    public partial class frmAddPerson : Form
    {
        public Student StudentEditing { get; set; }
        StudentManager studentManager;
        public bool isSql = false;
        int idForEdit;

        Action _action;
        public frmAddPerson()
        {
            InitializeComponent();
        }
        public frmAddPerson(int id =0)
        {
            InitializeComponent();
            idForEdit = id;
        }
        public frmAddPerson(Action action)
        {
            InitializeComponent();
            studentManager = new StudentManager();
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
        private void FillINfoFromSql()
        {
            var repo = new StudentRepo();
            var dt = repo.Select(idForEdit);

            if (dt != null && dt.Rows.Count == 1)
            {
                var row = dt.Rows[0];

                txtName.Text = row["FirstName"].ToString();
                txtLastName.Text = row["LastName"].ToString();
                txtNationalId.Text = row["NationalCode"].ToString();
                txtStudentCode.Text = row["StudentCode"].ToString();


            }
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            if (idForEdit > 0)
            {
                FillINfoFromSql();
            }

            if (StudentEditing != null)
            {
                txtName.Text = StudentEditing.FirstName;
                txtLastName.Text = StudentEditing.LastName;
                txtNationalId.Text = StudentEditing.NationalId;
                if (StudentEditing.Gender == Genders.man)
                    txtGender.Text = "man";
                else if (StudentEditing.Gender == Genders.woman)
                    txtGender.Text = "woman";

                if (StudentEditing.Grade == Grades.dahom)
                    txtGrade.Text = "dahom";
                else if (StudentEditing.Grade == Grades.yazdahom)
                    txtGrade.Text = "yazdahom";
                else if (StudentEditing.Grade == Grades.davazdahom)
                    txtGrade.Text = "davazdahom";

                txtStudentCode.Text = StudentEditing.StudentCode.ToString();
            }

        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isSql)
            {
                StudentRepo repo = new StudentRepo();
                if (idForEdit > 0)
                {
                    repo.Update(new Student
                    {
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                        NationalId = txtNationalId.Text,
                        StudentCode = int.Parse(txtStudentCode.Text),
                        Id = idForEdit,
                    });
                    _action?.Invoke();
                }
                else
                {
                    repo.Insert(new Student
                    {
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                        NationalId = txtNationalId.Text,
                        StudentCode = int.Parse(txtStudentCode.Text),
                    });
                    _action?.Invoke();
                }            
            }
            else
            {

                Student student;

                if (StudentEditing != null)
                {
                    student = StudentEditing;
                }
                else
                {
                    student = new Student();
                }

                student.FirstName = txtName.Text;
                student.LastName = txtLastName.Text;
                student.NationalId = txtNationalId.Text;

                if (txtGender.Text == "man")
                    student.Gender = Genders.man;
                else if (txtGender.Text == "woman")
                    student.Gender = Genders.woman;
                else
                    student.Gender = Genders.unknow;

                if (txtGrade.Text == "dahom")
                    student.Grade = Grades.dahom;
                else if (txtGrade.Text == "yazdahom")
                    student.Grade = Grades.yazdahom;
                else if (txtGrade.Text == "davazdahom")
                    student.Grade = Grades.davazdahom;
                else
                    student.Grade = Grades.unknow;
                try
                {
                    student.StudentCode = int.Parse(txtStudentCode.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("please inter the number in fild student code");
                }

                if (StudentEditing == null)
                {
                    var isValide = studentManager.Validate(student);
                    if (isValide.IsSuccess)
                        studentManager.Add(student);
                    else
                        MessageBox.Show(isValide.Message, "warning", MessageBoxButtons.RetryCancel);
                }
                _action?.Invoke();
            }

        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);

            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print data student
        }
    }

}






