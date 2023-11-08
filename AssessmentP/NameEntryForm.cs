using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentP
{
    public partial class NameEntryForm : Form
    {
        public NameEntryForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                Close();
            }
        }
        public string GetName()
        {
            return txtName.Text.Trim();
        }
    }
}
