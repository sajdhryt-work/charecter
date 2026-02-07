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
    public partial class frmDataGridView : Form
    {
        public bool isStudentList = false;
        public bool isStudentSql = false;
        public bool isTeacherList = false;
        public bool isTeacherSql = false;
        StudentManager studentManager;
        TeacherManager teacherManager;
        frmAddPerson frmAdd;
        public frmDataGridView()
        {
            InitializeComponent();
            frmAdd = new frmAddPerson(FillDgvPerson);
            studentManager = new StudentManager();
            teacherManager = new TeacherManager();
        }
       
        //public void FrmChangeData_PersonInserted (Person person)
        //{
        //    FillDgvPerson();
        //}
        private void Form1_Load(object sender, EventArgs e)
        {         
            FillDgvPerson();            
        }
        private void FillDgvPerson()
        {
            if (isStudentList)
                dgvPerson.DataSource = studentManager.GetStudent().ToList();
            else if (isTeacherList)
                dgvPerson.DataSource = teacherManager.GetTeacher().ToList();
            else if(isStudentSql)
            {
                string search = txtSearch.Text;
                var repo = new StudentRepo();
                dgvPerson.DataSource = repo.Select(search);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (isStudentList || isStudentSql)
            {
                frmAddPerson frmAdd = new frmAddPerson(FillDgvPerson)
                {
                    Text = "Add Person",
                };
                if (isStudentSql)
                {
                    frmAdd.isSql = true;
                }
                frmAdd.Show();
            }
            if (isTeacherList || isTeacherSql)
            {
                frmAddTeacher frmAdd = new frmAddTeacher(FillDgvPerson)
                {
                    Text = "Add Person",
                };
                frmAdd.Show();
            }
           
        }

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isStudentSql)
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dgvPerson.Columns[ColDelete.Name].Index)
                    {
                        var id = (int)dgvPerson.Rows[e.RowIndex].Cells["Id"].Value;
                        var repo = new StudentRepo();
                        repo.Delete(id);
                        FillDgvPerson();
                    }
                    else if (e.ColumnIndex == dgvPerson.Columns[ColEdit.Name].Index)
                    {
                        var id = (int)dgvPerson.Rows[e.RowIndex].Cells["Id"].Value;
                        new frmAddPerson(id).ShowDialog();
                    }
                }
            }
            if (isStudentList)
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
                    var student = dgvPerson.Rows[e.RowIndex].DataBoundItem as Student;
                    if (student != null)
                    {
                        studentManager.Remove(student);
                        FillDgvPerson();
                    }
                }

                else if (e.ColumnIndex == dgvPerson.Columns[ColEdit.Name].Index)
                {
                    var student = dgvPerson.Rows[e.RowIndex].DataBoundItem as Student;
                    frmAddPerson frmAdd = new frmAddPerson(FillDgvPerson)
                    {
                        Text = $"Edit {student.FullName}",
                        StudentEditing = student
                    };
                    frmAdd.Show();
                }
            }
            else if(isTeacherList) //this for Teacher
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
                    var teacher = dgvPerson.Rows[e.RowIndex].DataBoundItem as Teacher;
                    if (teacher != null)
                    {
                        teacherManager.Remove(teacher);
                        FillDgvPerson();
                    }
                }

                else if (e.ColumnIndex == dgvPerson.Columns[ColEdit.Name].Index)
                {
                    var teacher = dgvPerson.Rows[e.RowIndex].DataBoundItem as Teacher;
                    frmAddTeacher frmAdd = new frmAddTeacher(FillDgvPerson)
                    {
                        Text = $"Edit {teacher.FullName}",
                        TeacherEditing = teacher
                    };

                    frmAdd.Show();

                }
            }
            
        }
        private void frmDataGridView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }   

        private void dgvPerson_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPerson.Rows[e.RowIndex].Cells[ColRows.Name].Value = e.RowIndex + 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillDgvPerson();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDgvPerson();
        }
    }
}
