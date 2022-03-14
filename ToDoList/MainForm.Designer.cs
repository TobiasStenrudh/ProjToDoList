
namespace ToDoList
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_DateAndTime = new System.Windows.Forms.Label();
            this.label_ToDo = new System.Windows.Forms.Label();
            this.label_PriorityCombo = new System.Windows.Forms.Label();
            this.txtbox_ToDo = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.btn_AddToList = new System.Windows.Forms.Button();
            this.groupbox_ToDoList = new System.Windows.Forms.GroupBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Priority = new System.Windows.Forms.Label();
            this.label_Hour = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.lstboxObjects = new System.Windows.Forms.ListBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.groupbox_ToDoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label_DateAndTime
            // 
            this.label_DateAndTime.AutoSize = true;
            this.label_DateAndTime.Location = new System.Drawing.Point(13, 41);
            this.label_DateAndTime.Name = "label_DateAndTime";
            this.label_DateAndTime.Size = new System.Drawing.Size(35, 13);
            this.label_DateAndTime.TabIndex = 1;
            this.label_DateAndTime.Text = "label1";
            // 
            // label_ToDo
            // 
            this.label_ToDo.AutoSize = true;
            this.label_ToDo.Location = new System.Drawing.Point(16, 99);
            this.label_ToDo.Name = "label_ToDo";
            this.label_ToDo.Size = new System.Drawing.Size(35, 13);
            this.label_ToDo.TabIndex = 2;
            this.label_ToDo.Text = "label1";
            // 
            // label_PriorityCombo
            // 
            this.label_PriorityCombo.AutoSize = true;
            this.label_PriorityCombo.Location = new System.Drawing.Point(412, 70);
            this.label_PriorityCombo.Name = "label_PriorityCombo";
            this.label_PriorityCombo.Size = new System.Drawing.Size(35, 13);
            this.label_PriorityCombo.TabIndex = 3;
            this.label_PriorityCombo.Text = "label1";
            // 
            // txtbox_ToDo
            // 
            this.txtbox_ToDo.Location = new System.Drawing.Point(77, 96);
            this.txtbox_ToDo.Name = "txtbox_ToDo";
            this.txtbox_ToDo.Size = new System.Drawing.Size(281, 20);
            this.txtbox_ToDo.TabIndex = 4;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(77, 41);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(281, 20);
            this.DateTimePicker.TabIndex = 5;
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(453, 67);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 6;
            // 
            // btn_AddToList
            // 
            this.btn_AddToList.Location = new System.Drawing.Point(159, 146);
            this.btn_AddToList.Name = "btn_AddToList";
            this.btn_AddToList.Size = new System.Drawing.Size(112, 23);
            this.btn_AddToList.TabIndex = 7;
            this.btn_AddToList.Text = "button1";
            this.btn_AddToList.UseVisualStyleBackColor = true;
            this.btn_AddToList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // groupbox_ToDoList
            // 
            this.groupbox_ToDoList.Controls.Add(this.label_Description);
            this.groupbox_ToDoList.Controls.Add(this.label_Priority);
            this.groupbox_ToDoList.Controls.Add(this.label_Hour);
            this.groupbox_ToDoList.Controls.Add(this.label_Date);
            this.groupbox_ToDoList.Controls.Add(this.lstboxObjects);
            this.groupbox_ToDoList.Location = new System.Drawing.Point(71, 195);
            this.groupbox_ToDoList.Name = "groupbox_ToDoList";
            this.groupbox_ToDoList.Size = new System.Drawing.Size(524, 183);
            this.groupbox_ToDoList.TabIndex = 9;
            this.groupbox_ToDoList.TabStop = false;
            this.groupbox_ToDoList.Text = "groupBox1";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(316, 21);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(35, 13);
            this.label_Description.TabIndex = 4;
            this.label_Description.Text = "label1";
            // 
            // label_Priority
            // 
            this.label_Priority.AutoSize = true;
            this.label_Priority.Location = new System.Drawing.Point(191, 21);
            this.label_Priority.Name = "label_Priority";
            this.label_Priority.Size = new System.Drawing.Size(35, 13);
            this.label_Priority.TabIndex = 3;
            this.label_Priority.Text = "label1";
            // 
            // label_Hour
            // 
            this.label_Hour.AutoSize = true;
            this.label_Hour.Location = new System.Drawing.Point(130, 21);
            this.label_Hour.Name = "label_Hour";
            this.label_Hour.Size = new System.Drawing.Size(35, 13);
            this.label_Hour.TabIndex = 2;
            this.label_Hour.Text = "label1";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(15, 21);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(29, 13);
            this.label_Date.TabIndex = 1;
            this.label_Date.Text = "label";
            // 
            // lstboxObjects
            // 
            this.lstboxObjects.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lstboxObjects.FormattingEnabled = true;
            this.lstboxObjects.Location = new System.Drawing.Point(0, 37);
            this.lstboxObjects.Name = "lstboxObjects";
            this.lstboxObjects.Size = new System.Drawing.Size(524, 147);
            this.lstboxObjects.TabIndex = 8;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(117, 384);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(119, 24);
            this.btn_Change.TabIndex = 10;
            this.btn_Change.Text = "button1";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(429, 384);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "button2";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.groupbox_ToDoList);
            this.Controls.Add(this.btn_AddToList);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.txtbox_ToDo);
            this.Controls.Add(this.label_PriorityCombo);
            this.Controls.Add(this.label_ToDo);
            this.Controls.Add(this.label_DateAndTime);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.groupbox_ToDoList.ResumeLayout(false);
            this.groupbox_ToDoList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label label_DateAndTime;
        private System.Windows.Forms.Label label_ToDo;
        private System.Windows.Forms.Label label_PriorityCombo;
        private System.Windows.Forms.TextBox txtbox_ToDo;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button btn_AddToList;
        private System.Windows.Forms.GroupBox groupbox_ToDoList;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Priority;
        private System.Windows.Forms.Label label_Hour;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ListBox lstboxObjects;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

