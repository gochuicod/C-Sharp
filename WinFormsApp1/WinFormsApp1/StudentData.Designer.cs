
namespace WinFormsApp1
{
    partial class StudentData
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
            this.studentDataSearch = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBoxLabel = new System.Windows.Forms.Label();
            this.studentDataChoices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataSearch
            // 
            this.studentDataSearch.AllowUserToAddRows = false;
            this.studentDataSearch.AllowUserToDeleteRows = false;
            this.studentDataSearch.AllowUserToResizeColumns = false;
            this.studentDataSearch.AllowUserToResizeRows = false;
            this.studentDataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataSearch.Location = new System.Drawing.Point(12, 45);
            this.studentDataSearch.Name = "studentDataSearch";
            this.studentDataSearch.RowHeadersWidth = 51;
            this.studentDataSearch.RowTemplate.Height = 29;
            this.studentDataSearch.Size = new System.Drawing.Size(428, 434);
            this.studentDataSearch.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(169, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(212, 27);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBoxLabel
            // 
            this.searchBoxLabel.AutoSize = true;
            this.searchBoxLabel.Location = new System.Drawing.Point(387, 15);
            this.searchBoxLabel.Name = "searchBoxLabel";
            this.searchBoxLabel.Size = new System.Drawing.Size(53, 20);
            this.searchBoxLabel.TabIndex = 3;
            this.searchBoxLabel.Text = "Search";
            // 
            // studentDataChoices
            // 
            this.studentDataChoices.FormattingEnabled = true;
            this.studentDataChoices.Location = new System.Drawing.Point(12, 11);
            this.studentDataChoices.Name = "studentDataChoices";
            this.studentDataChoices.Size = new System.Drawing.Size(151, 28);
            this.studentDataChoices.TabIndex = 4;
            // 
            // StudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 489);
            this.Controls.Add(this.studentDataChoices);
            this.Controls.Add(this.searchBoxLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.studentDataSearch);
            this.Name = "StudentData";
            this.Text = "Student Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView studentDataSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchBoxLabel;
        private System.Windows.Forms.ComboBox studentDataChoices;
    }
}