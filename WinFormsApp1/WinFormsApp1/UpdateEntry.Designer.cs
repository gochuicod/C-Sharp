
namespace WinFormsApp1
{
    partial class UpdateEntry
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
            this.studentDataUpdate = new System.Windows.Forms.DataGridView();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxScore = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataUpdate
            // 
            this.studentDataUpdate.AllowUserToAddRows = false;
            this.studentDataUpdate.AllowUserToDeleteRows = false;
            this.studentDataUpdate.AllowUserToResizeColumns = false;
            this.studentDataUpdate.AllowUserToResizeRows = false;
            this.studentDataUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataUpdate.Location = new System.Drawing.Point(12, 79);
            this.studentDataUpdate.Name = "studentDataUpdate";
            this.studentDataUpdate.RowHeadersWidth = 51;
            this.studentDataUpdate.RowTemplate.Height = 29;
            this.studentDataUpdate.Size = new System.Drawing.Size(546, 434);
            this.studentDataUpdate.TabIndex = 3;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(12, 12);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(140, 27);
            this.txtBoxID.TabIndex = 4;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(158, 12);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(160, 27);
            this.txtBoxFirstName.TabIndex = 5;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(324, 12);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(172, 27);
            this.txtBoxLastName.TabIndex = 6;
            // 
            // txtBoxScore
            // 
            this.txtBoxScore.Location = new System.Drawing.Point(502, 12);
            this.txtBoxScore.Name = "txtBoxScore";
            this.txtBoxScore.Size = new System.Drawing.Size(56, 27);
            this.txtBoxScore.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(546, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 525);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxScore);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.studentDataUpdate);
            this.Name = "UpdateEntry";
            this.Text = "Update Entry";
            this.Load += new System.EventHandler(this.UpdateEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDataUpdate;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxScore;
        private System.Windows.Forms.Button btnUpdate;
    }
}