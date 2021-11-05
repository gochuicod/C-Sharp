
namespace WinFormsApp1
{
    partial class StudentScores
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
            this.StudentScoresTable = new System.Windows.Forms.DataGridView();
            this.lastname = new System.Windows.Forms.Label();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentScoresTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentScoresTable
            // 
            this.StudentScoresTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentScoresTable.Location = new System.Drawing.Point(12, 45);
            this.StudentScoresTable.Name = "StudentScoresTable";
            this.StudentScoresTable.RowHeadersWidth = 51;
            this.StudentScoresTable.RowTemplate.Height = 29;
            this.StudentScoresTable.Size = new System.Drawing.Size(411, 393);
            this.StudentScoresTable.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(16, 15);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(24, 20);
            this.lastname.TabIndex = 1;
            this.lastname.Text = "ID";
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Location = new System.Drawing.Point(46, 12);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(377, 27);
            this.LastnameTextBox.TabIndex = 2;
            this.LastnameTextBox.TextChanged += new System.EventHandler(this.LastnameTextBox_TextChanged);
            // 
            // StudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.LastnameTextBox);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.StudentScoresTable);
            this.Name = "StudentScores";
            this.Text = "StudentScores";
            ((System.ComponentModel.ISupportInitialize)(this.StudentScoresTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentScoresTable;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox LastnameTextBox;
    }
}