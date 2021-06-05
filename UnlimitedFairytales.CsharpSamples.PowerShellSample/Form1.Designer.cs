
namespace UnlimitedFairytales.CsharpSamples.PowerShellSample
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
            this.btnGetChildItem = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnCd = new System.Windows.Forms.Button();
            this.txtCdParameter = new System.Windows.Forms.TextBox();
            this.txtCurrentDirectoryOfPs = new System.Windows.Forms.TextBox();
            this.btnShowEnv = new System.Windows.Forms.Button();
            this.btnCdHome = new System.Windows.Forms.Button();
            this.btnGetMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetChildItem
            // 
            this.btnGetChildItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetChildItem.Location = new System.Drawing.Point(694, 12);
            this.btnGetChildItem.Name = "btnGetChildItem";
            this.btnGetChildItem.Size = new System.Drawing.Size(94, 23);
            this.btnGetChildItem.TabIndex = 0;
            this.btnGetChildItem.Text = "Get-ChildItem";
            this.btnGetChildItem.UseVisualStyleBackColor = true;
            this.btnGetChildItem.Click += new System.EventHandler(this.btnGetChildItem_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 100);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(776, 338);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "";
            // 
            // btnCd
            // 
            this.btnCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCd.Location = new System.Drawing.Point(694, 41);
            this.btnCd.Name = "btnCd";
            this.btnCd.Size = new System.Drawing.Size(94, 23);
            this.btnCd.TabIndex = 2;
            this.btnCd.Text = "cd";
            this.btnCd.UseVisualStyleBackColor = true;
            this.btnCd.Click += new System.EventHandler(this.btnCd_Click);
            // 
            // txtCdParameter
            // 
            this.txtCdParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCdParameter.Location = new System.Drawing.Point(12, 42);
            this.txtCdParameter.Name = "txtCdParameter";
            this.txtCdParameter.Size = new System.Drawing.Size(676, 23);
            this.txtCdParameter.TabIndex = 3;
            // 
            // txtCurrentDirectoryOfPs
            // 
            this.txtCurrentDirectoryOfPs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentDirectoryOfPs.Location = new System.Drawing.Point(12, 12);
            this.txtCurrentDirectoryOfPs.Name = "txtCurrentDirectoryOfPs";
            this.txtCurrentDirectoryOfPs.ReadOnly = true;
            this.txtCurrentDirectoryOfPs.Size = new System.Drawing.Size(676, 23);
            this.txtCurrentDirectoryOfPs.TabIndex = 4;
            // 
            // btnShowEnv
            // 
            this.btnShowEnv.Location = new System.Drawing.Point(12, 71);
            this.btnShowEnv.Name = "btnShowEnv";
            this.btnShowEnv.Size = new System.Drawing.Size(118, 23);
            this.btnShowEnv.TabIndex = 5;
            this.btnShowEnv.Text = "Get-ChildItem env:";
            this.btnShowEnv.UseVisualStyleBackColor = true;
            this.btnShowEnv.Click += new System.EventHandler(this.btnShowEnv_Click);
            // 
            // btnCdHome
            // 
            this.btnCdHome.Location = new System.Drawing.Point(136, 71);
            this.btnCdHome.Name = "btnCdHome";
            this.btnCdHome.Size = new System.Drawing.Size(141, 23);
            this.btnCdHome.TabIndex = 6;
            this.btnCdHome.Text = "cd $env:USERPROFILE";
            this.btnCdHome.UseVisualStyleBackColor = true;
            this.btnCdHome.Click += new System.EventHandler(this.btnCdHome_Click);
            // 
            // btnGetMember
            // 
            this.btnGetMember.Location = new System.Drawing.Point(283, 71);
            this.btnGetMember.Name = "btnGetMember";
            this.btnGetMember.Size = new System.Drawing.Size(328, 23);
            this.btnGetMember.TabIndex = 7;
            this.btnGetMember.Text = "Get-ChildItem | Get-Member -MemberType Properties";
            this.btnGetMember.UseVisualStyleBackColor = true;
            this.btnGetMember.Click += new System.EventHandler(this.btnGetMember_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetMember);
            this.Controls.Add(this.btnCdHome);
            this.Controls.Add(this.btnShowEnv);
            this.Controls.Add(this.txtCurrentDirectoryOfPs);
            this.Controls.Add(this.txtCdParameter);
            this.Controls.Add(this.btnCd);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGetChildItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetChildItem;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnCd;
        private System.Windows.Forms.TextBox txtCdParameter;
        private System.Windows.Forms.TextBox txtCurrentDirectoryOfPs;
        private System.Windows.Forms.Button btnShowEnv;
        private System.Windows.Forms.Button btnCdHome;
        private System.Windows.Forms.Button btnGetMember;
    }
}

