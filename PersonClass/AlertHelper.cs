using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonClass
{
    internal static class AlertHelper
    {
        public static DialogResult Question (string message)
        {
            return MessageBox.Show (message,"you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }
    }
}
