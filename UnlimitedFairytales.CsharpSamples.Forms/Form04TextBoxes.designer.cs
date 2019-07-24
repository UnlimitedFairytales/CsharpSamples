namespace UnlimitedFairytales.CsharpSamples.Forms
{
	partial class Form04TextBoxes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form04TextBoxes));
			this.txtOriginal = new System.Windows.Forms.TextBox();
			this.txtOriginal_rich = new System.Windows.Forms.RichTextBox();
			this.btnLf = new System.Windows.Forms.Button();
			this.btnCr = new System.Windows.Forms.Button();
			this.btnCrLf = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTxt1 = new System.Windows.Forms.TextBox();
			this.txtRic1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTxt2 = new System.Windows.Forms.TextBox();
			this.txtRic2 = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRic1_rich = new System.Windows.Forms.RichTextBox();
			this.txtTxt1_rich = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtRic2_rich = new System.Windows.Forms.RichTextBox();
			this.txtTxt2_rich = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnModifiedToFalse = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtOriginal
			// 
			this.txtOriginal.Location = new System.Drawing.Point(316, 81);
			this.txtOriginal.Multiline = true;
			this.txtOriginal.Name = "txtOriginal";
			this.txtOriginal.Size = new System.Drawing.Size(100, 96);
			this.txtOriginal.TabIndex = 1;
			this.txtOriginal.ModifiedChanged += new System.EventHandler(this.txtOriginal_ModifiedChanged);
			// 
			// txtOriginal_rich
			// 
			this.txtOriginal_rich.Location = new System.Drawing.Point(316, 316);
			this.txtOriginal_rich.Name = "txtOriginal_rich";
			this.txtOriginal_rich.Size = new System.Drawing.Size(100, 96);
			this.txtOriginal_rich.TabIndex = 2;
			this.txtOriginal_rich.Text = "";
			this.txtOriginal_rich.ModifiedChanged += new System.EventHandler(this.txtOriginal_rich_ModifiedChanged);
			// 
			// btnLf
			// 
			this.btnLf.Location = new System.Drawing.Point(12, 81);
			this.btnLf.Name = "btnLf";
			this.btnLf.Size = new System.Drawing.Size(75, 23);
			this.btnLf.TabIndex = 3;
			this.btnLf.Text = "改行LF";
			this.btnLf.UseVisualStyleBackColor = true;
			this.btnLf.Click += new System.EventHandler(this.btnLf_Click);
			// 
			// btnCr
			// 
			this.btnCr.Location = new System.Drawing.Point(12, 110);
			this.btnCr.Name = "btnCr";
			this.btnCr.Size = new System.Drawing.Size(75, 23);
			this.btnCr.TabIndex = 4;
			this.btnCr.Text = "改行CR";
			this.btnCr.UseVisualStyleBackColor = true;
			this.btnCr.Click += new System.EventHandler(this.btnCr_Click);
			// 
			// btnCrLf
			// 
			this.btnCrLf.Location = new System.Drawing.Point(12, 139);
			this.btnCrLf.Name = "btnCrLf";
			this.btnCrLf.Size = new System.Drawing.Size(75, 23);
			this.btnCrLf.TabIndex = 5;
			this.btnCrLf.Text = "改行CRLF";
			this.btnCrLf.UseVisualStyleBackColor = true;
			this.btnCrLf.Click += new System.EventHandler(this.btnCrLf_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(314, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "オリジナル\r\nTextBox";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(420, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "Text経由";
			// 
			// txtTxt1
			// 
			this.txtTxt1.Location = new System.Drawing.Point(422, 32);
			this.txtTxt1.Multiline = true;
			this.txtTxt1.Name = "txtTxt1";
			this.txtTxt1.Size = new System.Drawing.Size(100, 96);
			this.txtTxt1.TabIndex = 8;
			this.txtTxt1.ModifiedChanged += new System.EventHandler(this.txtTxt1_ModifiedChanged);
			// 
			// txtRic1
			// 
			this.txtRic1.Location = new System.Drawing.Point(422, 134);
			this.txtRic1.Name = "txtRic1";
			this.txtRic1.Size = new System.Drawing.Size(100, 96);
			this.txtRic1.TabIndex = 9;
			this.txtRic1.Text = "";
			this.txtRic1.ModifiedChanged += new System.EventHandler(this.txtRic1_ModifiedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(526, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "Copy&&Paste";
			// 
			// txtTxt2
			// 
			this.txtTxt2.Location = new System.Drawing.Point(528, 32);
			this.txtTxt2.Multiline = true;
			this.txtTxt2.Name = "txtTxt2";
			this.txtTxt2.Size = new System.Drawing.Size(100, 96);
			this.txtTxt2.TabIndex = 11;
			this.txtTxt2.ModifiedChanged += new System.EventHandler(this.txtTxt2_ModifiedChanged);
			// 
			// txtRic2
			// 
			this.txtRic2.Location = new System.Drawing.Point(528, 134);
			this.txtRic2.Name = "txtRic2";
			this.txtRic2.Size = new System.Drawing.Size(100, 96);
			this.txtRic2.TabIndex = 12;
			this.txtRic2.Text = "";
			this.txtRic2.ModifiedChanged += new System.EventHandler(this.txtRic2_ModifiedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(314, 289);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 24);
			this.label4.TabIndex = 13;
			this.label4.Text = "オリジナル\r\nRichTextBox";
			// 
			// txtRic1_rich
			// 
			this.txtRic1_rich.Location = new System.Drawing.Point(422, 367);
			this.txtRic1_rich.Name = "txtRic1_rich";
			this.txtRic1_rich.Size = new System.Drawing.Size(100, 96);
			this.txtRic1_rich.TabIndex = 16;
			this.txtRic1_rich.Text = "";
			this.txtRic1_rich.ModifiedChanged += new System.EventHandler(this.txtRic1_rich_ModifiedChanged);
			// 
			// txtTxt1_rich
			// 
			this.txtTxt1_rich.Location = new System.Drawing.Point(422, 265);
			this.txtTxt1_rich.Multiline = true;
			this.txtTxt1_rich.Name = "txtTxt1_rich";
			this.txtTxt1_rich.Size = new System.Drawing.Size(100, 96);
			this.txtTxt1_rich.TabIndex = 15;
			this.txtTxt1_rich.ModifiedChanged += new System.EventHandler(this.txtTxt1_rich_ModifiedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(420, 250);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "Text経由";
			// 
			// txtRic2_rich
			// 
			this.txtRic2_rich.Location = new System.Drawing.Point(528, 367);
			this.txtRic2_rich.Name = "txtRic2_rich";
			this.txtRic2_rich.Size = new System.Drawing.Size(100, 96);
			this.txtRic2_rich.TabIndex = 19;
			this.txtRic2_rich.Text = "";
			this.txtRic2_rich.ModifiedChanged += new System.EventHandler(this.txtRic2_rich_ModifiedChanged);
			// 
			// txtTxt2_rich
			// 
			this.txtTxt2_rich.Location = new System.Drawing.Point(528, 265);
			this.txtTxt2_rich.Multiline = true;
			this.txtTxt2_rich.Name = "txtTxt2_rich";
			this.txtTxt2_rich.Size = new System.Drawing.Size(100, 96);
			this.txtTxt2_rich.TabIndex = 18;
			this.txtTxt2_rich.ModifiedChanged += new System.EventHandler(this.txtTxt2_rich_ModifiedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(526, 250);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 12);
			this.label6.TabIndex = 17;
			this.label6.Text = "Copy&&Paste";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 165);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(290, 288);
			this.label7.TabIndex = 20;
			this.label7.Text = resources.GetString("label7.Text");
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(171, 12);
			this.label8.TabIndex = 21;
			this.label8.Text = "Modifiedの場合、背景色がAquaに";
			// 
			// btnModifiedToFalse
			// 
			this.btnModifiedToFalse.Location = new System.Drawing.Point(93, 81);
			this.btnModifiedToFalse.Name = "btnModifiedToFalse";
			this.btnModifiedToFalse.Size = new System.Drawing.Size(90, 23);
			this.btnModifiedToFalse.TabIndex = 22;
			this.btnModifiedToFalse.Text = "Modified=false";
			this.btnModifiedToFalse.UseVisualStyleBackColor = true;
			this.btnModifiedToFalse.Click += new System.EventHandler(this.btnModifiedToFalse_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(368, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 12);
			this.label9.TabIndex = 23;
			this.label9.Text = "TextBox";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(345, 218);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 12);
			this.label10.TabIndex = 24;
			this.label10.Text = "RichTextBox";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(368, 268);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 12);
			this.label11.TabIndex = 25;
			this.label11.Text = "TextBox";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(345, 451);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 12);
			this.label12.TabIndex = 26;
			this.label12.Text = "RichTextBox";
			// 
			// Form04TextBoxes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnModifiedToFalse);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtRic2_rich);
			this.Controls.Add(this.txtTxt2_rich);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtRic1_rich);
			this.Controls.Add(this.txtTxt1_rich);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtRic2);
			this.Controls.Add(this.txtTxt2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtRic1);
			this.Controls.Add(this.txtTxt1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCrLf);
			this.Controls.Add(this.btnCr);
			this.Controls.Add(this.btnLf);
			this.Controls.Add(this.txtOriginal_rich);
			this.Controls.Add(this.txtOriginal);
			this.Name = "Form04TextBoxes";
			this.Text = "Form04TextBoxs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtOriginal;
		private System.Windows.Forms.RichTextBox txtOriginal_rich;
		private System.Windows.Forms.Button btnLf;
		private System.Windows.Forms.Button btnCr;
		private System.Windows.Forms.Button btnCrLf;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTxt1;
		private System.Windows.Forms.RichTextBox txtRic1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTxt2;
		private System.Windows.Forms.RichTextBox txtRic2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtRic1_rich;
		private System.Windows.Forms.TextBox txtTxt1_rich;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox txtRic2_rich;
		private System.Windows.Forms.TextBox txtTxt2_rich;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnModifiedToFalse;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
	}
}