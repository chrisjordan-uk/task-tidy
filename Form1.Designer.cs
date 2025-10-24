namespace PriorityPulse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_addtask = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_markComplete = new System.Windows.Forms.Button();
            this.btn_deleteTask = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_editTask = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(0, 24);
            this.listViewTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(842, 479);
            this.listViewTasks.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTasks.TabIndex = 0;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_addtask
            // 
            this.btn_addtask.Location = new System.Drawing.Point(6, 16);
            this.btn_addtask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addtask.Name = "btn_addtask";
            this.btn_addtask.Size = new System.Drawing.Size(86, 47);
            this.btn_addtask.TabIndex = 2;
            this.btn_addtask.Text = "Add Task";
            this.btn_addtask.UseVisualStyleBackColor = true;
            this.btn_addtask.Click += new System.EventHandler(this.btn_addtask_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(747, 16);
            this.btn_open.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(86, 47);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Open Tasks";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_markComplete
            // 
            this.btn_markComplete.Location = new System.Drawing.Point(188, 16);
            this.btn_markComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_markComplete.Name = "btn_markComplete";
            this.btn_markComplete.Size = new System.Drawing.Size(86, 47);
            this.btn_markComplete.TabIndex = 5;
            this.btn_markComplete.Text = "Mark task as completed";
            this.btn_markComplete.UseVisualStyleBackColor = true;
            this.btn_markComplete.Click += new System.EventHandler(this.btn_markComplete_Click);
            // 
            // btn_deleteTask
            // 
            this.btn_deleteTask.Location = new System.Drawing.Point(278, 16);
            this.btn_deleteTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deleteTask.Name = "btn_deleteTask";
            this.btn_deleteTask.Size = new System.Drawing.Size(86, 47);
            this.btn_deleteTask.TabIndex = 6;
            this.btn_deleteTask.Text = "Delete Task";
            this.btn_deleteTask.UseVisualStyleBackColor = true;
            this.btn_deleteTask.Click += new System.EventHandler(this.btn_deleteTask_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(656, 16);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 47);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save Tasks";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.btn_markComplete);
            this.groupBox1.Controls.Add(this.btn_deleteTask);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_addtask);
            this.groupBox1.Controls.Add(this.btn_editTask);
            this.groupBox1.Location = new System.Drawing.Point(0, 429);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(945, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTaskToolStripMenuItem,
            this.saveTasksToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTaskToolStripMenuItem
            // 
            this.openTaskToolStripMenuItem.Name = "openTaskToolStripMenuItem";
            this.openTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openTaskToolStripMenuItem.Text = "Open tasks";
            this.openTaskToolStripMenuItem.Click += new System.EventHandler(this.openTaskToolStripMenuItem_Click);
            // 
            // saveTasksToolStripMenuItem
            // 
            this.saveTasksToolStripMenuItem.Name = "saveTasksToolStripMenuItem";
            this.saveTasksToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveTasksToolStripMenuItem.Text = "Save tasks";
            this.saveTasksToolStripMenuItem.Click += new System.EventHandler(this.saveTasksToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.editTaskToolStripMenuItem,
            this.markAsCompletedToolStripMenuItem,
            this.deleteTaskToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editTaskToolStripMenuItem.Text = "Edit Task";
            this.editTaskToolStripMenuItem.Click += new System.EventHandler(this.editTaskToolStripMenuItem_Click);
            // 
            // markAsCompletedToolStripMenuItem
            // 
            this.markAsCompletedToolStripMenuItem.Name = "markAsCompletedToolStripMenuItem";
            this.markAsCompletedToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.markAsCompletedToolStripMenuItem.Text = "Mark as completed";
            this.markAsCompletedToolStripMenuItem.Click += new System.EventHandler(this.markAsCompletedToolStripMenuItem_Click);
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteTaskToolStripMenuItem.Text = "Delete task";
            this.deleteTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteTaskToolStripMenuItem_Click);
            // 
            // btn_editTask
            // 
            this.btn_editTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editTask.Location = new System.Drawing.Point(97, 16);
            this.btn_editTask.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editTask.Name = "btn_editTask";
            this.btn_editTask.Size = new System.Drawing.Size(86, 47);
            this.btn_editTask.TabIndex = 3;
            this.btn_editTask.Text = "Edit Task";
            this.btn_editTask.UseVisualStyleBackColor = true;
            this.btn_editTask.Click += new System.EventHandler(this.btn_editTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewTasks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasktidy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_addtask;
        private System.Windows.Forms.Button btn_editTask;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_markComplete;
        private System.Windows.Forms.Button btn_deleteTask;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
    }
}

