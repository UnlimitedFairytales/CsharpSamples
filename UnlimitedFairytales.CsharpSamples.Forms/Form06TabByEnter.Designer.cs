namespace UnlimitedFairytales.CsharpSamples.Forms
{
    partial class Form06TabByEnter
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
            this.rdoProcessDialogKey = new System.Windows.Forms.RadioButton();
            this.rdoKeyDown = new System.Windows.Forms.RadioButton();
            this.rdoKeyUp = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisabled = new System.Windows.Forms.TextBox();
            this.txtWithMessageBox = new System.Windows.Forms.TextBox();
            this.txtHiragana = new System.Windows.Forms.TextBox();
            this.txtMultiline = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoProcessDialogKey
            // 
            this.rdoProcessDialogKey.AutoSize = true;
            this.rdoProcessDialogKey.Location = new System.Drawing.Point(13, 13);
            this.rdoProcessDialogKey.Name = "rdoProcessDialogKey";
            this.rdoProcessDialogKey.Size = new System.Drawing.Size(115, 16);
            this.rdoProcessDialogKey.TabIndex = 0;
            this.rdoProcessDialogKey.TabStop = true;
            this.rdoProcessDialogKey.Text = "ProcessDialogKey";
            this.rdoProcessDialogKey.UseVisualStyleBackColor = true;
            // 
            // rdoKeyDown
            // 
            this.rdoKeyDown.AutoSize = true;
            this.rdoKeyDown.Location = new System.Drawing.Point(134, 13);
            this.rdoKeyDown.Name = "rdoKeyDown";
            this.rdoKeyDown.Size = new System.Drawing.Size(70, 16);
            this.rdoKeyDown.TabIndex = 1;
            this.rdoKeyDown.TabStop = true;
            this.rdoKeyDown.Text = "KeyDown";
            this.rdoKeyDown.UseVisualStyleBackColor = true;
            // 
            // rdoKeyUp
            // 
            this.rdoKeyUp.AutoSize = true;
            this.rdoKeyUp.Location = new System.Drawing.Point(210, 13);
            this.rdoKeyUp.Name = "rdoKeyUp";
            this.rdoKeyUp.Size = new System.Drawing.Size(56, 16);
            this.rdoKeyUp.TabIndex = 2;
            this.rdoKeyUp.TabStop = true;
            this.rdoKeyUp.Text = "KeyUp";
            this.rdoKeyUp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "*  Keydown and keyup need keypreview=true";
            // 
            // txtDisabled
            // 
            this.txtDisabled.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtDisabled.Location = new System.Drawing.Point(12, 35);
            this.txtDisabled.Name = "txtDisabled";
            this.txtDisabled.Size = new System.Drawing.Size(100, 19);
            this.txtDisabled.TabIndex = 10;
            // 
            // txtWithMessageBox
            // 
            this.txtWithMessageBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtWithMessageBox.Location = new System.Drawing.Point(12, 60);
            this.txtWithMessageBox.Name = "txtWithMessageBox";
            this.txtWithMessageBox.Size = new System.Drawing.Size(100, 19);
            this.txtWithMessageBox.TabIndex = 11;
            this.txtWithMessageBox.Validated += new System.EventHandler(this.txtWithMessageBox_Validated);
            // 
            // txtHiragana
            // 
            this.txtHiragana.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtHiragana.Location = new System.Drawing.Point(12, 85);
            this.txtHiragana.Name = "txtHiragana";
            this.txtHiragana.Size = new System.Drawing.Size(100, 19);
            this.txtHiragana.TabIndex = 12;
            // 
            // txtMultiline
            // 
            this.txtMultiline.Location = new System.Drawing.Point(12, 110);
            this.txtMultiline.Multiline = true;
            this.txtMultiline.Name = "txtMultiline";
            this.txtMultiline.Size = new System.Drawing.Size(100, 45);
            this.txtMultiline.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form06TabByEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMultiline);
            this.Controls.Add(this.txtHiragana);
            this.Controls.Add(this.txtWithMessageBox);
            this.Controls.Add(this.txtDisabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoKeyUp);
            this.Controls.Add(this.rdoKeyDown);
            this.Controls.Add(this.rdoProcessDialogKey);
            this.KeyPreview = true;
            this.Name = "Form06TabByEnter";
            this.Text = "Form06TabByEnter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoProcessDialogKey;
        private System.Windows.Forms.RadioButton rdoKeyDown;
        private System.Windows.Forms.RadioButton rdoKeyUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisabled;
        private System.Windows.Forms.TextBox txtWithMessageBox;
        private System.Windows.Forms.TextBox txtHiragana;
        private System.Windows.Forms.TextBox txtMultiline;
        private System.Windows.Forms.Button button1;
    }
}