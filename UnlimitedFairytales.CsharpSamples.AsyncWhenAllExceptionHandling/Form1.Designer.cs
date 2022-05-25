namespace UnlimitedFairytales.CsharpSamples.AsyncWhenAllExceptionHandling
{
    partial class Form1
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
            this.btnDoAsync = new System.Windows.Forms.Button();
            this.btnCountUp = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDoAsync
            // 
            this.btnDoAsync.Location = new System.Drawing.Point(12, 12);
            this.btnDoAsync.Name = "btnDoAsync";
            this.btnDoAsync.Size = new System.Drawing.Size(75, 23);
            this.btnDoAsync.TabIndex = 0;
            this.btnDoAsync.Text = "DoAsync";
            this.btnDoAsync.UseVisualStyleBackColor = true;
            this.btnDoAsync.Click += new System.EventHandler(this.btnDoAsync_Click);
            // 
            // btnCountUp
            // 
            this.btnCountUp.Location = new System.Drawing.Point(12, 41);
            this.btnCountUp.Name = "btnCountUp";
            this.btnCountUp.Size = new System.Drawing.Size(75, 23);
            this.btnCountUp.TabIndex = 1;
            this.btnCountUp.Text = "CountUp";
            this.btnCountUp.UseVisualStyleBackColor = true;
            this.btnCountUp.Click += new System.EventHandler(this.btnCountUp_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(93, 41);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(100, 23);
            this.txtCount.TabIndex = 2;
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Location = new System.Drawing.Point(93, 12);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(100, 23);
            this.btnChangeMode.TabIndex = 3;
            this.btnChangeMode.Text = "ChangeMode";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(199, 12);
            this.txtMode.Name = "txtMode";
            this.txtMode.ReadOnly = true;
            this.txtMode.Size = new System.Drawing.Size(100, 23);
            this.txtMode.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.btnChangeMode);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnCountUp);
            this.Controls.Add(this.btnDoAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDoAsync;
        private Button btnCountUp;
        private TextBox txtCount;
        private Button btnChangeMode;
        private TextBox txtMode;
    }
}