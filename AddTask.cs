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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }
        public string TaskName { get; private set; }
        public string Priority { get; private set; }
        public DateTime Deadline { get; private set; }
        public string Description { get; private set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_taskName.Text))
            {
                MessageBox.Show("Task name cannot be empty.");
                return;
            }

            TaskName = txt_taskName.Text;
            Priority = cmb_priority.SelectedItem?.ToString() ?? "Low";
            Deadline = dtp_deadline.Value;
            Description = txt_description.Text;

            DialogResult = DialogResult.OK;
            Close();



        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
