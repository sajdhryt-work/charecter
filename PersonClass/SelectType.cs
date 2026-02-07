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
    public partial class SelectType : Form
    {
        public SelectType()
        {
            InitializeComponent();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            var frm = new SelectForm()
            {
                Owner = this,
                isSql = true,
            };
            frm.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var frm = new SelectForm()
            {
                Owner = this,
                isSql = false,
            };
            frm.Show();
            this.Hide();
        }

        private void SelectType_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
