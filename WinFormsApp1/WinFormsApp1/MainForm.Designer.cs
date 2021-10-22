
namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBoxScore = new System.Windows.Forms.TextBox();
            this.rtxtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuStudentData = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuRemoveID = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.editMenuUpdateEntries = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(114, 109);
            this.txtBoxID.MaxLength = 10;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(179, 27);
            this.txtBoxID.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(71, 112);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 20);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID #";
            // 
            // txtBoxScore
            // 
            this.txtBoxScore.Location = new System.Drawing.Point(114, 142);
            this.txtBoxScore.MaxLength = 5;
            this.txtBoxScore.Name = "txtBoxScore";
            this.txtBoxScore.Size = new System.Drawing.Size(94, 27);
            this.txtBoxScore.TabIndex = 6;
            // 
            // rtxtBoxOutput
            // 
            this.rtxtBoxOutput.Location = new System.Drawing.Point(29, 218);
            this.rtxtBoxOutput.Name = "rtxtBoxOutput";
            this.rtxtBoxOutput.ReadOnly = true;
            this.rtxtBoxOutput.Size = new System.Drawing.Size(264, 120);
            this.rtxtBoxOutput.TabIndex = 10;
            this.rtxtBoxOutput.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(114, 175);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.editMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuNew,
            this.fileMenuExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            // 
            // fileMenuNew
            // 
            this.fileMenuNew.Name = "fileMenuNew";
            this.fileMenuNew.Size = new System.Drawing.Size(122, 26);
            this.fileMenuNew.Text = "New";
            this.fileMenuNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // fileMenuExit
            // 
            this.fileMenuExit.Name = "fileMenuExit";
            this.fileMenuExit.Size = new System.Drawing.Size(122, 26);
            this.fileMenuExit.Text = "Exit";
            this.fileMenuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuStudentData});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(55, 24);
            this.viewMenu.Text = "View";
            // 
            // viewMenuStudentData
            // 
            this.viewMenuStudentData.Name = "viewMenuStudentData";
            this.viewMenuStudentData.Size = new System.Drawing.Size(179, 26);
            this.viewMenuStudentData.Text = "Student Data";
            this.viewMenuStudentData.Click += new System.EventHandler(this.studentDataToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuRemoveID,
            this.editMenuUpdateEntries});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(49, 24);
            this.editMenu.Text = "Edit";
            // 
            // editMenuRemoveID
            // 
            this.editMenuRemoveID.Name = "editMenuRemoveID";
            this.editMenuRemoveID.Size = new System.Drawing.Size(224, 26);
            this.editMenuRemoveID.Text = "Remove Entries";
            this.editMenuRemoveID.Click += new System.EventHandler(this.undoLastItemToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(315, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMenu
            // 
            this.statusMenu.Name = "statusMenu";
            this.statusMenu.Size = new System.Drawing.Size(103, 20);
            this.statusMenu.Text = "Nothing to do";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(114, 76);
            this.txtBoxLastName.MaxLength = 20;
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(179, 27);
            this.txtBoxLastName.TabIndex = 16;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(62, 145);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 20);
            this.lblScore.TabIndex = 17;
            this.lblScore.Text = "Score";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(28, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(114, 43);
            this.txtBoxFirstName.MaxLength = 20;
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(179, 27);
            this.txtBoxFirstName.TabIndex = 18;
            // 
            // editMenuUpdateEntries
            // 
            this.editMenuUpdateEntries.Name = "editMenuUpdateEntries";
            this.editMenuUpdateEntries.Size = new System.Drawing.Size(224, 26);
            this.editMenuUpdateEntries.Text = "Update Entries";
            this.editMenuUpdateEntries.Click += new System.EventHandler(this.editMenuUpdateEntries_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(315, 389);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtxtBoxOutput);
            this.Controls.Add(this.txtBoxScore);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Student Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBoxScore;
        private System.Windows.Forms.RichTextBox rtxtBoxOutput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuNew;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenuStudentData;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenuRemoveID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuExit;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.ToolStripMenuItem editMenuUpdateEntries;
    }
}

