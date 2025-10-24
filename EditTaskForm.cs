using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityPulse
{
    public partial class EditTaskForm : Form
    {

        public string TaskName { get; private set; }
        public DateTime Deadline { get; private set; }
        public string Priority { get; private set; }
        public string Description { get; private set; }
        public EditTaskForm(string taskName, DateTime deadline, string priority, string description)
        {
            InitializeComponent();
            dtp_deadline.MinDate = DateTime.Today;
            dtp_deadline.MaxDate = DateTime.Today.AddYears(10);
            txt_taskName.Text = taskName;
            dtp_deadline.Value = deadline;
            cmb_priority.SelectedItem = priority;
            txt_description.Text = description;
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txt_description.Text) || cmb_priority.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaskName = txt_taskName.Text;
            Deadline = dtp_deadline.Value;
            Priority = cmb_priority.SelectedItem.ToString();
            Description = txt_description.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
