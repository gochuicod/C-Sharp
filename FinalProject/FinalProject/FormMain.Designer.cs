
namespace FinalProject
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteEntries = new System.Windows.Forms.Button();
            this.btnUpdateEntries = new System.Windows.Forms.Button();
            this.btnViewEntries = new System.Windows.Forms.Button();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentEntry = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtBoxGrade = new System.Windows.Forms.TextBox();
            this.pnlStudentEntry = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlViewEntries = new System.Windows.Forms.Panel();
            this.cbViewEntriesChoices = new System.Windows.Forms.ComboBox();
            this.txtBoxViewSearch = new System.Windows.Forms.TextBox();
            this.dgvViewEntries = new System.Windows.Forms.DataGridView();
            this.pnlUpdateEntries = new System.Windows.Forms.Panel();
            this.btnUpdateEntriesUpdateButton = new System.Windows.Forms.Button();
            this.dgvUpdateEntries = new System.Windows.Forms.DataGridView();
            this.txtBoxUpdateEntryIDBox = new System.Windows.Forms.TextBox();
            this.lblUpdateEntryID = new System.Windows.Forms.Label();
            this.cbUpdateEntriesChoices = new System.Windows.Forms.ComboBox();
            this.txtBoxUpdateBox = new System.Windows.Forms.TextBox();
            this.pnlDeleteEntries = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEntriesDelete = new System.Windows.Forms.Button();
            this.dgvDeleteEntries = new System.Windows.Forms.DataGridView();
            this.txtBoxDeleteEntriesBox = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlStudentEntry.SuspendLayout();
            this.pnlViewEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEntries)).BeginInit();
            this.pnlUpdateEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateEntries)).BeginInit();
            this.pnlDeleteEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnDeleteEntries);
            this.pnlMenu.Controls.Add(this.btnUpdateEntries);
            this.pnlMenu.Controls.Add(this.btnViewEntries);
            this.pnlMenu.Controls.Add(this.btnNewEntry);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 569);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 63);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteEntries
            // 
            this.btnDeleteEntries.FlatAppearance.BorderSize = 0;
            this.btnDeleteEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntries.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEntries.Location = new System.Drawing.Point(12, 314);
            this.btnDeleteEntries.Name = "btnDeleteEntries";
            this.btnDeleteEntries.Size = new System.Drawing.Size(174, 63);
            this.btnDeleteEntries.TabIndex = 5;
            this.btnDeleteEntries.Text = "Delete Entries";
            this.btnDeleteEntries.UseVisualStyleBackColor = true;
            this.btnDeleteEntries.Click += new System.EventHandler(this.btnDeleteEntries_Click);
            // 
            // btnUpdateEntries
            // 
            this.btnUpdateEntries.FlatAppearance.BorderSize = 0;
            this.btnUpdateEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEntries.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEntries.Location = new System.Drawing.Point(12, 245);
            this.btnUpdateEntries.Name = "btnUpdateEntries";
            this.btnUpdateEntries.Size = new System.Drawing.Size(174, 63);
            this.btnUpdateEntries.TabIndex = 3;
            this.btnUpdateEntries.Text = "Update Entries";
            this.btnUpdateEntries.UseVisualStyleBackColor = true;
            this.btnUpdateEntries.Click += new System.EventHandler(this.btnUpdateEntries_Click);
            // 
            // btnViewEntries
            // 
            this.btnViewEntries.FlatAppearance.BorderSize = 0;
            this.btnViewEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEntries.ForeColor = System.Drawing.Color.White;
            this.btnViewEntries.Location = new System.Drawing.Point(12, 176);
            this.btnViewEntries.Name = "btnViewEntries";
            this.btnViewEntries.Size = new System.Drawing.Size(174, 63);
            this.btnViewEntries.TabIndex = 2;
            this.btnViewEntries.Text = "View Entries";
            this.btnViewEntries.UseVisualStyleBackColor = true;
            this.btnViewEntries.Click += new System.EventHandler(this.btnViewEntries_Click);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.FlatAppearance.BorderSize = 0;
            this.btnNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEntry.ForeColor = System.Drawing.Color.White;
            this.btnNewEntry.Location = new System.Drawing.Point(12, 107);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(174, 63);
            this.btnNewEntry.TabIndex = 1;
            this.btnNewEntry.Text = "New Entry";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(115, 96);
            this.txtBoxFirstName.MaxLength = 12;
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(146, 22);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // lblStudentEntry
            // 
            this.lblStudentEntry.AutoSize = true;
            this.lblStudentEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEntry.Location = new System.Drawing.Point(53, 29);
            this.lblStudentEntry.Name = "lblStudentEntry";
            this.lblStudentEntry.Size = new System.Drawing.Size(192, 31);
            this.lblStudentEntry.TabIndex = 2;
            this.lblStudentEntry.Text = "Student Entry";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(23, 96);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(23, 124);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(115, 124);
            this.txtBoxLastName.MaxLength = 12;
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(146, 22);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(83, 152);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(115, 152);
            this.txtBoxID.MaxLength = 8;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(99, 22);
            this.txtBoxID.TabIndex = 6;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(55, 180);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 20);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "Grade";
            // 
            // txtBoxGrade
            // 
            this.txtBoxGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGrade.Location = new System.Drawing.Point(115, 180);
            this.txtBoxGrade.MaxLength = 3;
            this.txtBoxGrade.Name = "txtBoxGrade";
            this.txtBoxGrade.Size = new System.Drawing.Size(39, 22);
            this.txtBoxGrade.TabIndex = 8;
            // 
            // pnlStudentEntry
            // 
            this.pnlStudentEntry.Controls.Add(this.btnSubmit);
            this.pnlStudentEntry.Controls.Add(this.txtBoxID);
            this.pnlStudentEntry.Controls.Add(this.txtBoxFirstName);
            this.pnlStudentEntry.Controls.Add(this.lblStudentEntry);
            this.pnlStudentEntry.Controls.Add(this.lblFirstName);
            this.pnlStudentEntry.Controls.Add(this.txtBoxLastName);
            this.pnlStudentEntry.Controls.Add(this.lblLastName);
            this.pnlStudentEntry.Controls.Add(this.lblID);
            this.pnlStudentEntry.Controls.Add(this.txtBoxGrade);
            this.pnlStudentEntry.Controls.Add(this.lblGrade);
            this.pnlStudentEntry.Location = new System.Drawing.Point(409, 179);
            this.pnlStudentEntry.Name = "pnlStudentEntry";
            this.pnlStudentEntry.Size = new System.Drawing.Size(292, 271);
            this.pnlStudentEntry.TabIndex = 17;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(3, 218);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(286, 50);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlViewEntries
            // 
            this.pnlViewEntries.Controls.Add(this.cbViewEntriesChoices);
            this.pnlViewEntries.Controls.Add(this.txtBoxViewSearch);
            this.pnlViewEntries.Controls.Add(this.dgvViewEntries);
            this.pnlViewEntries.Location = new System.Drawing.Point(343, 31);
            this.pnlViewEntries.Name = "pnlViewEntries";
            this.pnlViewEntries.Size = new System.Drawing.Size(451, 508);
            this.pnlViewEntries.TabIndex = 18;
            // 
            // cbViewEntriesChoices
            // 
            this.cbViewEntriesChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewEntriesChoices.FormattingEnabled = true;
            this.cbViewEntriesChoices.Location = new System.Drawing.Point(3, 3);
            this.cbViewEntriesChoices.Name = "cbViewEntriesChoices";
            this.cbViewEntriesChoices.Size = new System.Drawing.Size(164, 28);
            this.cbViewEntriesChoices.TabIndex = 2;
            // 
            // txtBoxViewSearch
            // 
            this.txtBoxViewSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxViewSearch.Location = new System.Drawing.Point(173, 3);
            this.txtBoxViewSearch.Name = "txtBoxViewSearch";
            this.txtBoxViewSearch.Size = new System.Drawing.Size(275, 29);
            this.txtBoxViewSearch.TabIndex = 1;
            this.txtBoxViewSearch.TextChanged += new System.EventHandler(this.txtBoxViewSearch_TextChanged);
            // 
            // dgvViewEntries
            // 
            this.dgvViewEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewEntries.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvViewEntries.Location = new System.Drawing.Point(3, 40);
            this.dgvViewEntries.Name = "dgvViewEntries";
            this.dgvViewEntries.Size = new System.Drawing.Size(445, 465);
            this.dgvViewEntries.TabIndex = 0;
            // 
            // pnlUpdateEntries
            // 
            this.pnlUpdateEntries.Controls.Add(this.btnUpdateEntriesUpdateButton);
            this.pnlUpdateEntries.Controls.Add(this.dgvUpdateEntries);
            this.pnlUpdateEntries.Controls.Add(this.txtBoxUpdateEntryIDBox);
            this.pnlUpdateEntries.Controls.Add(this.lblUpdateEntryID);
            this.pnlUpdateEntries.Controls.Add(this.cbUpdateEntriesChoices);
            this.pnlUpdateEntries.Controls.Add(this.txtBoxUpdateBox);
            this.pnlUpdateEntries.Location = new System.Drawing.Point(280, 65);
            this.pnlUpdateEntries.Name = "pnlUpdateEntries";
            this.pnlUpdateEntries.Size = new System.Drawing.Size(564, 450);
            this.pnlUpdateEntries.TabIndex = 19;
            // 
            // btnUpdateEntriesUpdateButton
            // 
            this.btnUpdateEntriesUpdateButton.FlatAppearance.BorderSize = 0;
            this.btnUpdateEntriesUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEntriesUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEntriesUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateEntriesUpdateButton.Location = new System.Drawing.Point(457, 4);
            this.btnUpdateEntriesUpdateButton.Name = "btnUpdateEntriesUpdateButton";
            this.btnUpdateEntriesUpdateButton.Size = new System.Drawing.Size(103, 29);
            this.btnUpdateEntriesUpdateButton.TabIndex = 9;
            this.btnUpdateEntriesUpdateButton.Text = "Update";
            this.btnUpdateEntriesUpdateButton.UseVisualStyleBackColor = true;
            this.btnUpdateEntriesUpdateButton.Click += new System.EventHandler(this.btnUpdateEntriesUpdateButton_Click);
            // 
            // dgvUpdateEntries
            // 
            this.dgvUpdateEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUpdateEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpdateEntries.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUpdateEntries.Location = new System.Drawing.Point(3, 38);
            this.dgvUpdateEntries.Name = "dgvUpdateEntries";
            this.dgvUpdateEntries.Size = new System.Drawing.Size(557, 409);
            this.dgvUpdateEntries.TabIndex = 3;
            // 
            // txtBoxUpdateEntryIDBox
            // 
            this.txtBoxUpdateEntryIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUpdateEntryIDBox.Location = new System.Drawing.Point(41, 3);
            this.txtBoxUpdateEntryIDBox.MaxLength = 8;
            this.txtBoxUpdateEntryIDBox.Name = "txtBoxUpdateEntryIDBox";
            this.txtBoxUpdateEntryIDBox.Size = new System.Drawing.Size(99, 29);
            this.txtBoxUpdateEntryIDBox.TabIndex = 5;
            // 
            // lblUpdateEntryID
            // 
            this.lblUpdateEntryID.AutoSize = true;
            this.lblUpdateEntryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateEntryID.Location = new System.Drawing.Point(9, 8);
            this.lblUpdateEntryID.Name = "lblUpdateEntryID";
            this.lblUpdateEntryID.Size = new System.Drawing.Size(26, 20);
            this.lblUpdateEntryID.TabIndex = 4;
            this.lblUpdateEntryID.Text = "ID";
            // 
            // cbUpdateEntriesChoices
            // 
            this.cbUpdateEntriesChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateEntriesChoices.FormattingEnabled = true;
            this.cbUpdateEntriesChoices.Location = new System.Drawing.Point(146, 4);
            this.cbUpdateEntriesChoices.Name = "cbUpdateEntriesChoices";
            this.cbUpdateEntriesChoices.Size = new System.Drawing.Size(115, 28);
            this.cbUpdateEntriesChoices.TabIndex = 3;
            this.cbUpdateEntriesChoices.SelectedIndexChanged += new System.EventHandler(this.cbUpdateEntriesChoices_SelectedIndexChanged);
            // 
            // txtBoxUpdateBox
            // 
            this.txtBoxUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUpdateBox.Location = new System.Drawing.Point(267, 4);
            this.txtBoxUpdateBox.MaxLength = 12;
            this.txtBoxUpdateBox.Name = "txtBoxUpdateBox";
            this.txtBoxUpdateBox.Size = new System.Drawing.Size(181, 29);
            this.txtBoxUpdateBox.TabIndex = 3;
            // 
            // pnlDeleteEntries
            // 
            this.pnlDeleteEntries.Controls.Add(this.label1);
            this.pnlDeleteEntries.Controls.Add(this.btnDeleteEntriesDelete);
            this.pnlDeleteEntries.Controls.Add(this.dgvDeleteEntries);
            this.pnlDeleteEntries.Controls.Add(this.txtBoxDeleteEntriesBox);
            this.pnlDeleteEntries.Location = new System.Drawing.Point(343, 65);
            this.pnlDeleteEntries.Name = "pnlDeleteEntries";
            this.pnlDeleteEntries.Size = new System.Drawing.Size(460, 447);
            this.pnlDeleteEntries.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // btnDeleteEntriesDelete
            // 
            this.btnDeleteEntriesDelete.FlatAppearance.BorderSize = 0;
            this.btnDeleteEntriesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntriesDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntriesDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteEntriesDelete.Location = new System.Drawing.Point(267, 8);
            this.btnDeleteEntriesDelete.Name = "btnDeleteEntriesDelete";
            this.btnDeleteEntriesDelete.Size = new System.Drawing.Size(103, 29);
            this.btnDeleteEntriesDelete.TabIndex = 12;
            this.btnDeleteEntriesDelete.Text = "Delete";
            this.btnDeleteEntriesDelete.UseVisualStyleBackColor = true;
            this.btnDeleteEntriesDelete.Click += new System.EventHandler(this.btnDeleteEntriesDelete_Click);
            // 
            // dgvDeleteEntries
            // 
            this.dgvDeleteEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeleteEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeleteEntries.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDeleteEntries.Location = new System.Drawing.Point(4, 42);
            this.dgvDeleteEntries.Name = "dgvDeleteEntries";
            this.dgvDeleteEntries.Size = new System.Drawing.Size(452, 409);
            this.dgvDeleteEntries.TabIndex = 10;
            // 
            // txtBoxDeleteEntriesBox
            // 
            this.txtBoxDeleteEntriesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDeleteEntriesBox.Location = new System.Drawing.Point(161, 8);
            this.txtBoxDeleteEntriesBox.MaxLength = 8;
            this.txtBoxDeleteEntriesBox.Name = "txtBoxDeleteEntriesBox";
            this.txtBoxDeleteEntriesBox.Size = new System.Drawing.Size(100, 29);
            this.txtBoxDeleteEntriesBox.TabIndex = 11;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(316, 79);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(462, 31);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Welcome to the Student Data App!";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(318, 133);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(210, 24);
            this.lblStart.TabIndex = 23;
            this.lblStart.Text = "Press New Entry to Start";
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 569);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlDeleteEntries);
            this.Controls.Add(this.pnlStudentEntry);
            this.Controls.Add(this.pnlUpdateEntries);
            this.Controls.Add(this.pnlViewEntries);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.pnlStudentEntry.ResumeLayout(false);
            this.pnlStudentEntry.PerformLayout();
            this.pnlViewEntries.ResumeLayout(false);
            this.pnlViewEntries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEntries)).EndInit();
            this.pnlUpdateEntries.ResumeLayout(false);
            this.pnlUpdateEntries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateEntries)).EndInit();
            this.pnlDeleteEntries.ResumeLayout(false);
            this.pnlDeleteEntries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnUpdateEntries;
        private System.Windows.Forms.Button btnViewEntries;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Button btnDeleteEntries;
        private System.Windows.Forms.Label lblStudentEntry;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtBoxGrade;
        private System.Windows.Forms.Panel pnlStudentEntry;
        private System.Windows.Forms.Panel pnlViewEntries;
        private System.Windows.Forms.DataGridView dgvViewEntries;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxViewSearch;
        private System.Windows.Forms.ComboBox cbViewEntriesChoices;
        private System.Windows.Forms.Panel pnlUpdateEntries;
        private System.Windows.Forms.TextBox txtBoxUpdateEntryIDBox;
        private System.Windows.Forms.Label lblUpdateEntryID;
        private System.Windows.Forms.ComboBox cbUpdateEntriesChoices;
        private System.Windows.Forms.TextBox txtBoxUpdateBox;
        private System.Windows.Forms.DataGridView dgvUpdateEntries;
        private System.Windows.Forms.Button btnUpdateEntriesUpdateButton;
        private System.Windows.Forms.Panel pnlDeleteEntries;
        private System.Windows.Forms.Button btnDeleteEntriesDelete;
        private System.Windows.Forms.DataGridView dgvDeleteEntries;
        private System.Windows.Forms.TextBox txtBoxDeleteEntriesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStart;
    }
}

