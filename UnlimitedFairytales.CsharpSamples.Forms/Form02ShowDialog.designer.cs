﻿namespace UnlimitedFairytales.CsharpSamples.Forms
{
	partial class Form02ShowDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form02ShowDialog));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "未設定";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(12, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "OK";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new System.Drawing.Point(12, 70);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(137, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "キャンセル";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.button4.Location = new System.Drawing.Point(12, 99);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(137, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "中止";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.DialogResult = System.Windows.Forms.DialogResult.Retry;
			this.button5.Location = new System.Drawing.Point(12, 128);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(137, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "再試行";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.button6.Location = new System.Drawing.Point(12, 157);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(137, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "無視";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.button7.Location = new System.Drawing.Point(12, 186);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(137, 23);
			this.button7.TabIndex = 6;
			this.button7.Text = "はい";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.DialogResult = System.Windows.Forms.DialogResult.No;
			this.button8.Location = new System.Drawing.Point(12, 215);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(137, 23);
			this.button8.TabIndex = 7;
			this.button8.Text = "いいえ";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(419, 60);
			this.label1.TabIndex = 8;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// Form02ShowDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form02ShowDialog";
			this.Text = "Form02ShowDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label1;
	}
}