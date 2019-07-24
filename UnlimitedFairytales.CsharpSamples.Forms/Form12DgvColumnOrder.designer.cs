namespace UnlimitedFairytales.CsharpSamples.Forms
{
	partial class Form12DgvColumnOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column3_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column4_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Column5_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_1,
            this.Column1_2,
            this.Column1_3,
            this.Column1_4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(616, 60);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Column1_1
            // 
            this.Column1_1.DataPropertyName = "A";
            this.Column1_1.HeaderText = "Column1=A";
            this.Column1_1.Name = "Column1_1";
            // 
            // Column1_2
            // 
            this.Column1_2.DataPropertyName = "B";
            this.Column1_2.HeaderText = "Column2=B";
            this.Column1_2.Name = "Column1_2";
            // 
            // Column1_3
            // 
            this.Column1_3.DataPropertyName = "C";
            this.Column1_3.HeaderText = "Column3=C";
            this.Column1_3.Name = "Column1_3";
            // 
            // Column1_4
            // 
            this.Column1_4.DataPropertyName = "D";
            this.Column1_4.HeaderText = "Column4=D";
            this.Column1_4.Name = "Column1_4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "元順序ABCD、DataSource順序DACB。動作不定";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2_1,
            this.Column2_2,
            this.Column2_3,
            this.Column2_4});
            this.dataGridView2.Location = new System.Drawing.Point(12, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(616, 60);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // Column2_1
            // 
            this.Column2_1.DataPropertyName = "A";
            this.Column2_1.HeaderText = "Column1=A";
            this.Column2_1.Name = "Column2_1";
            // 
            // Column2_2
            // 
            this.Column2_2.DataPropertyName = "B";
            this.Column2_2.HeaderText = "Column2=B";
            this.Column2_2.Name = "Column2_2";
            // 
            // Column2_3
            // 
            this.Column2_3.DataPropertyName = "C";
            this.Column2_3.HeaderText = "Column3=C";
            this.Column2_3.Name = "Column2_3";
            // 
            // Column2_4
            // 
            this.Column2_4.DataPropertyName = "D";
            this.Column2_4.HeaderText = "Column4=D";
            this.Column2_4.Name = "Column2_4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "元順序ABCD、DataSource順序DAECB。動作不定";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "元順序ABXD、DataSource順序DACB。動作不定";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3_1,
            this.Column3_2,
            this.Column3_3,
            this.Column3_4});
            this.dataGridView3.Location = new System.Drawing.Point(12, 180);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 21;
            this.dataGridView3.Size = new System.Drawing.Size(616, 60);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellEnter);
            // 
            // Column3_1
            // 
            this.Column3_1.DataPropertyName = "A";
            this.Column3_1.HeaderText = "Column1=A";
            this.Column3_1.Name = "Column3_1";
            // 
            // Column3_2
            // 
            this.Column3_2.DataPropertyName = "B";
            this.Column3_2.HeaderText = "Column2=B";
            this.Column3_2.Name = "Column3_2";
            // 
            // Column3_3
            // 
            this.Column3_3.HeaderText = "Column3";
            this.Column3_3.Name = "Column3_3";
            // 
            // Column3_4
            // 
            this.Column3_4.DataPropertyName = "D";
            this.Column3_4.HeaderText = "Column4=D";
            this.Column3_4.Name = "Column3_4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "元順序ABXD、DataSource順序DAECB。動作不定";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4_1,
            this.Column4_2,
            this.Column4_3,
            this.Column4_4});
            this.dataGridView4.Location = new System.Drawing.Point(12, 258);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 21;
            this.dataGridView4.Size = new System.Drawing.Size(616, 60);
            this.dataGridView4.TabIndex = 7;
            this.dataGridView4.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellEnter);
            // 
            // Column4_1
            // 
            this.Column4_1.DataPropertyName = "A";
            this.Column4_1.HeaderText = "Column1=A";
            this.Column4_1.Name = "Column4_1";
            // 
            // Column4_2
            // 
            this.Column4_2.DataPropertyName = "B";
            this.Column4_2.HeaderText = "Column2=B";
            this.Column4_2.Name = "Column4_2";
            // 
            // Column4_3
            // 
            this.Column4_3.HeaderText = "Column3";
            this.Column4_3.Name = "Column4_3";
            // 
            // Column4_4
            // 
            this.Column4_4.DataPropertyName = "D";
            this.Column4_4.HeaderText = "Column4=D";
            this.Column4_4.Name = "Column4_4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "元順序ABXD、DataSource順序DAECB、DisplayIndex順序(EC3421)";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5_1,
            this.Column5_2,
            this.Column5_3,
            this.Column5_4});
            this.dataGridView5.Location = new System.Drawing.Point(12, 336);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 21;
            this.dataGridView5.Size = new System.Drawing.Size(616, 60);
            this.dataGridView5.TabIndex = 9;
            this.dataGridView5.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellEnter);
            // 
            // Column5_1
            // 
            this.Column5_1.DataPropertyName = "A";
            this.Column5_1.HeaderText = "Column1=A";
            this.Column5_1.Name = "Column5_1";
            // 
            // Column5_2
            // 
            this.Column5_2.DataPropertyName = "B";
            this.Column5_2.HeaderText = "Column2=B";
            this.Column5_2.Name = "Column5_2";
            // 
            // Column5_3
            // 
            this.Column5_3.HeaderText = "Column3";
            this.Column5_3.Name = "Column5_3";
            // 
            // Column5_4
            // 
            this.Column5_4.DataPropertyName = "D";
            this.Column5_4.HeaderText = "Column4=D";
            this.Column5_4.Name = "Column5_4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "【バインド　列順序】\r\nIndexの順序は、非バインド列、その後にバインドデータに従う順番で採番し直される\r\nDisplayIndexの順序は動作環境により異なる" +
    "(fw2.0とfw2.0SP1で挙動が異なる)\r\nデータバインドした時は、列のDisplayIndexは必ず指定する事";
            // 
            // btnBind
            // 
            this.btnBind.Location = new System.Drawing.Point(553, 403);
            this.btnBind.Name = "btnBind";
            this.btnBind.Size = new System.Drawing.Size(75, 23);
            this.btnBind.TabIndex = 11;
            this.btnBind.Text = "バインド";
            this.btnBind.UseVisualStyleBackColor = true;
            this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
            // 
            // Form12DgvColumnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.btnBind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12DgvColumnOrder";
            this.Text = "Form12DgvColumnOrder";
            this.Load += new System.EventHandler(this.Form07DgvColumnOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1_3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1_4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2_3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2_4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3_3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3_4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4_3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4_4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5_3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5_4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnBind;
	}
}