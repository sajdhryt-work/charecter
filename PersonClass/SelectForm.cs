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
    public partial class SelectForm : Form
    {
        public bool isSql;

        public SelectForm()
        {
            InitializeComponent();
        }
       
        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            if (isSql)
            {
                frmDataGridView frm = new frmDataGridView()
                {
                    Owner = this,
                    Text = "Students",
                    isStudentSql = true,
                };
                frm.Show();
                this.Hide();
            }
            else
            {
                frmDataGridView frm = new frmDataGridView()
                {
                    Owner = this,
                    Text = "Students",
                    isStudentList = true,
                };
                frm.Show();
                this.Hide();
            }
           

        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            if (isSql)
            {
                frmDataGridView frm = new frmDataGridView()
                {
                    Owner = this,
                    Text = "Techers",
                    isTeacherSql = true,
                };
                frm.Show();
                this.Hide();
            }
            else
            {
                frmDataGridView frm = new frmDataGridView()
                {
                    Owner = this,
                    Text = "Techers",
                    isTeacherList = true,
                };
                frm.Show();
                this.Hide();
            }


        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

    }
}
