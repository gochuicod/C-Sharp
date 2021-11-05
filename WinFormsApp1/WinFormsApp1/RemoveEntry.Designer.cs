
namespace WinFormsApp1
{
    partial class RemoveEntry
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.removeBox = new System.Windows.Forms.TextBox();
            this.studentDataRemove = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeBox
            // 
            this.removeBox.Location = new System.Drawing.Point(42, 19);
            this.removeBox.Name = "removeBox";
            this.removeBox.Size = new System.Drawing.Size(418, 27);
            this.removeBox.TabIndex = 1;
            // 
            // studentDataRemove
            // 
            this.studentDataRemove.AllowUserToAddRows = false;
            this.studentDataRemove.AllowUserToDeleteRows = false;
            this.studentDataRemove.AllowUserToResizeColumns = false;
            this.studentDataRemove.AllowUserToResizeRows = false;
            this.studentDataRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataRemove.Location = new System.Drawing.Point(12, 54);
            this.studentDataRemove.Name = "studentDataRemove";
            this.studentDataRemove.RowHeadersWidth = 51;
            this.studentDataRemove.RowTemplate.Height = 29;
            this.studentDataRemove.Size = new System.Drawing.Size(546, 434);
            this.studentDataRemove.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // RemoveEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 509);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.studentDataRemove);
            this.Controls.Add(this.removeBox);
            this.Controls.Add(this.btnDelete);
            this.Name = "RemoveEntry";
            this.Text = "Remove Specific Entry";
            this.Load += new System.EventHandler(this.RemoveEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox removeBox;
        private System.Windows.Forms.DataGridView studentDataRemove;
        private System.Windows.Forms.Label lblID;
    }
}