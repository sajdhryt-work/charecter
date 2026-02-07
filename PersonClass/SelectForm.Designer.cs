namespace PersonClass
{
    partial class SelectForm
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
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnShowTeachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(68, 71);
            this.btnShowStudents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(302, 74);
            this.btnShowStudents.TabIndex = 0;
            this.btnShowStudents.Text = "Studends";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudent_Click);
            // 
            // btnShowTeachers
            // 
            this.btnShowTeachers.Location = new System.Drawing.Point(72, 219);
            this.btnShowTeachers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowTeachers.Name = "btnShowTeachers";
            this.btnShowTeachers.Size = new System.Drawing.Size(302, 74);
            this.btnShowTeachers.TabIndex = 1;
            this.btnShowTeachers.Text = "Teachers";
            this.btnShowTeachers.UseVisualStyleBackColor = true;
            this.btnShowTeachers.Click += new System.EventHandler(this.btnShowTeachers_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 375);
            this.Controls.Add(this.btnShowTeachers);
            this.Controls.Add(this.btnShowStudents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SelectForm";
            this.Text = "frmFirst";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnShowTeachers;
    }
}