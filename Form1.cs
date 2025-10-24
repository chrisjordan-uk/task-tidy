using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityPulse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listViewTasks.View = View.Details;
            listViewTasks.Columns.Add("Name", 150);
            listViewTasks.Columns.Add("Priority", 100);
            listViewTasks.Columns.Add("Deadline", 150);
            listViewTasks.Columns.Add("Status", 100);
            listViewTasks.Columns.Add("Description", 100);
            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Мащабиране според DPI на дисплея

        }
        public string TaskName { get; private set; }
        public string Priority { get; private set; }
        public DateTime Deadline { get; private set; }
        public string Description { get; private set; }

        public class Task
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Deadline { get; set; }
            public string Priority { get; set; }
            public bool IsCompleted { get; set; }
        }
        private void btn_addtask_Click(object sender, EventArgs e)
        {
            AddTask frm = new AddTask();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Task newTask = new Task
                {
                    Name = frm.TaskName,
                    Priority = frm.Priority,
                    Deadline = frm.Deadline,
                    Description = frm.Description,
                    IsCompleted = false
                };

                AddTaskToListView(newTask);
            }


        }
        private void AddTaskToListView(Task task)
        {
            var listItem = new ListViewItem(task.Name);
            listItem.SubItems.Add(task.Priority);
            listItem.SubItems.Add(task.Deadline.ToString("yyyy-MM-dd HH:mm"));
            listItem.SubItems.Add(task.IsCompleted ? "Completed" : "Pending");
            listItem.SubItems.Add(task.Description);
            listItem.Tag = task;
            listViewTasks.Items.Add(listItem);
        }

        private void btn_deleteTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                listViewTasks.Items.Remove(listViewTasks.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_markComplete_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                var selectedTask = (Task)listViewTasks.SelectedItems[0].Tag;
                selectedTask.IsCompleted = true;

                listViewTasks.SelectedItems[0].SubItems[3].Text = "Completed";
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_editTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTasks.SelectedItems[0];

                string currentName = selectedItem.SubItems[0].Text;
                string currentPriority = selectedItem.SubItems[1].Text;
                string currentDescription = selectedItem.SubItems[4].Text;

                if (string.IsNullOrWhiteSpace(selectedItem.SubItems[1].Text) ||
                    !DateTime.TryParse(selectedItem.SubItems[2].Text, out DateTime currentDeadline))
                {
                    MessageBox.Show($"Invalid deadline format: {selectedItem.SubItems[1].Text}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
                using (EditTaskForm editTaskForm = new EditTaskForm(currentName, currentDeadline, currentPriority, currentDescription))
                {
                    if (editTaskForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedItem.SubItems[0].Text = editTaskForm.TaskName;
                        selectedItem.SubItems[1].Text = editTaskForm.Priority;
                        selectedItem.SubItems[2].Text = editTaskForm.Deadline.ToString("yyyy-MM-dd HH:mm");
                        selectedItem.SubItems[4].Text = editTaskForm.Description;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "Edit Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Open Tasks";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        listViewTasks.Items.Clear();

                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 5)
                            {
                                ListViewItem item = new ListViewItem(parts[0]);
                                item.SubItems.Add(parts[1]); 
                                item.SubItems.Add(parts[2]); 
                                item.SubItems.Add(parts[3]);
                                item.SubItems.Add(parts[4]); 

                                listViewTasks.Items.Add(item);
                            }
                        }
                    }
                    MessageBox.Show("Tasks loaded successfully!", "Open Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Tasks";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (ListViewItem item in listViewTasks.Items)
                        {
                            string line = string.Join("|",
                                item.SubItems[0].Text,
                                item.SubItems[1].Text,
                                item.SubItems[2].Text,
                                item.SubItems[3].Text, 
                                item.SubItems[4].Text 

                            );
                            writer.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Tasks saved successfully!", "Save Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_open.PerformClick();
        }

        private void saveTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_save.PerformClick();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_addtask.PerformClick();
        }

        private void editTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_editTask.PerformClick();
        }

        private void markAsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_markComplete.PerformClick();
        }

        private void deleteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_deleteTask.PerformClick();
        }
    }
}
