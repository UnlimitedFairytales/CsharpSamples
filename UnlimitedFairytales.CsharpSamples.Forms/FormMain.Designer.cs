namespace UnlimitedFairytales.CsharpSamples.Forms
{
    partial class FormMain
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
            this.btnFormCommon = new System.Windows.Forms.Button();
            this.btnFormDgv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFormCommon
            // 
            this.btnFormCommon.Location = new System.Drawing.Point(12, 12);
            this.btnFormCommon.Name = "btnFormCommon";
            this.btnFormCommon.Size = new System.Drawing.Size(113, 23);
            this.btnFormCommon.TabIndex = 0;
            this.btnFormCommon.Text = "FormCommon";
            this.btnFormCommon.UseVisualStyleBackColor = true;
            this.btnFormCommon.Click += new System.EventHandler(this.btnFormCommon_Click);
            // 
            // btnFormDgv
            // 
            this.btnFormDgv.Location = new System.Drawing.Point(131, 12);
            this.btnFormDgv.Name = "btnFormDgv";
            this.btnFormDgv.Size = new System.Drawing.Size(113, 23);
            this.btnFormDgv.TabIndex = 1;
            this.btnFormDgv.Text = "FormDgv";
            this.btnFormDgv.UseVisualStyleBackColor = true;
            this.btnFormDgv.Click += new System.EventHandler(this.btnFormDgv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "未整理Tips\r\n\r\n【フォームデザイナとDesignMode】\r\nフォームデザイナの実態は、32bitによる実行である\r\n継承元FormのLoadイベントハンド" +
    "ラまでは呼ばれる(自分のLoadイベントハンドラは対象外)\r\nフォームデザイナに不具合が出る場合、DesignModeプロパティを判定して避ければよい\r\n\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFormDgv);
            this.Controls.Add(this.btnFormCommon);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormCommon;
        private System.Windows.Forms.Button btnFormDgv;
        private System.Windows.Forms.Label label1;
    }
}