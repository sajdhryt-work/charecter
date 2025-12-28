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
    public partial class frmFirst : Form
    {
        

        public frmFirst()
        {
            InitializeComponent();
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            frmDataGridView frm = new frmDataGridView()
            {
                Owner= this,
                Text = "Students",
                isStudent = true,
            };
            frm.Show();
            this.Hide();

        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            frmDataGridView frm = new frmDataGridView()
            {
                Owner = this,
                Text = "Techers",
                isTeacher = true,
            };
            frm.Show();
            this.Hide();


        }

        private void frmFirst_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
