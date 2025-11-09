namespace charecter
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
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtInputChar = new System.Windows.Forms.TextBox();
            this.btnWordCount = new System.Windows.Forms.Button();
            this.btnCharCount = new System.Windows.Forms.Button();
            this.btnWordList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(69, 88);
            this.txtInputText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(666, 107);
            this.txtInputText.TabIndex = 0;
            this.txtInputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInputChar
            // 
            this.txtInputChar.Location = new System.Drawing.Point(69, 205);
            this.txtInputChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputChar.Multiline = true;
            this.txtInputChar.Name = "txtInputChar";
            this.txtInputChar.Size = new System.Drawing.Size(475, 50);
            this.txtInputChar.TabIndex = 1;
            // 
            // btnWordCount
            // 
            this.btnWordCount.Location = new System.Drawing.Point(548, 289);
            this.btnWordCount.Name = "btnWordCount";
            this.btnWordCount.Size = new System.Drawing.Size(187, 49);
            this.btnWordCount.TabIndex = 2;
            this.btnWordCount.Text = "تعداد کلمه";
            this.btnWordCount.UseVisualStyleBackColor = true;
            this.btnWordCount.Click += new System.EventHandler(this.btnWordCount_Click);
            // 
            // btnCharCount
            // 
            this.btnCharCount.Location = new System.Drawing.Point(310, 289);
            this.btnCharCount.Name = "btnCharCount";
            this.btnCharCount.Size = new System.Drawing.Size(187, 49);
            this.btnCharCount.TabIndex = 2;
            this.btnCharCount.Text = "تعداد حرف";
            this.btnCharCount.UseVisualStyleBackColor = true;
            this.btnCharCount.Click += new System.EventHandler(this.btnCharCount_Click);
            // 
            // btnWordList
            // 
            this.btnWordList.Location = new System.Drawing.Point(69, 289);
            this.btnWordList.Name = "btnWordList";
            this.btnWordList.Size = new System.Drawing.Size(187, 49);
            this.btnWordList.TabIndex = 2;
            this.btnWordList.Text = "لیست کلمات";
            this.btnWordList.UseVisualStyleBackColor = true;
            this.btnWordList.Click += new System.EventHandler(this.btnWordList_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(569, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "کاراکتر وارد کنید :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(745, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "متن :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWordList);
            this.Controls.Add(this.btnCharCount);
            this.Controls.Add(this.btnWordCount);
            this.Controls.Add(this.txtInputChar);
            this.Controls.Add(this.txtInputText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtInputChar;
        private System.Windows.Forms.Button btnWordCount;
        private System.Windows.Forms.Button btnCharCount;
        private System.Windows.Forms.Button btnWordList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

