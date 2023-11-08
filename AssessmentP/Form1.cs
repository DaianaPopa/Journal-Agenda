using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentP
{
    public partial class frmToDo : Form
    {
        public frmToDo()
        {
            InitializeComponent();

            UnableButtons();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            t.SetTask(txtTask.Text);
            t.SetHour(Convert.ToInt32(nudHour.Value));
            t.SetMinute(Convert.ToInt32(nudMin.Value));

            clbTask.Items.Add(t);
            txtTask.Text = "";
        }

        private void btnUrgent_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            t.SetTask(txtTask.Text);
            t.SetHour(Convert.ToInt32(nudHour.Value));
            t.SetMinute(Convert.ToInt32(nudMin.Value));

            lstUrgent.Items.Add(t);
            txtTask.Text = "";
            lstUrgent.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           Task currentlySelected = clbTask.SelectedItem as Task;
           clbTask.Items.Remove(currentlySelected);

            Task urgentSelected = lstUrgent.SelectedItem as Task;
            lstUrgent.Items.Remove(urgentSelected);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstUrgent.Items.Clear();
            clbTask.Items.Clear();
            lblDate.ResetText();
            lblTitle.Text = "To Do List";
            btnStart.Show();
            lstUrgent.Visible = false;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string date = txtDate.Text.Trim();
            lblDate.Text = date;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide();
            NameEntryForm nef = new NameEntryForm();
            nef.ShowDialog();
            Show();

            lblTitle.Text = nef.GetName() + "'s To Do List";
            btnStart.Hide();
            AbleButtons();
        }

        public void UnableButtons()
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnSet.Enabled = false;
            btnUrgent.Enabled = false;
        }

        public void AbleButtons()
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnSet.Enabled = true;
            btnUrgent.Enabled = true;
        }
    }
}
