namespace CS_ATM
{
    partial class Admin
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
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnBlockAccount = new System.Windows.Forms.Button();
            this.btnCancelBlock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(174, 54);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(127, 51);
            this.btnCheckBalance.TabIndex = 0;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            // 
            // btnBlockAccount
            // 
            this.btnBlockAccount.Location = new System.Drawing.Point(63, 144);
            this.btnBlockAccount.Name = "btnBlockAccount";
            this.btnBlockAccount.Size = new System.Drawing.Size(148, 51);
            this.btnBlockAccount.TabIndex = 1;
            this.btnBlockAccount.Text = "Block Account";
            this.btnBlockAccount.UseVisualStyleBackColor = true;
            // 
            // btnCancelBlock
            // 
            this.btnCancelBlock.Location = new System.Drawing.Point(257, 144);
            this.btnCancelBlock.Name = "btnCancelBlock";
            this.btnCancelBlock.Size = new System.Drawing.Size(148, 51);
            this.btnCancelBlock.TabIndex = 2;
            this.btnCancelBlock.Text = "Cancel Block";
            this.btnCancelBlock.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancelBlock);
            this.Controls.Add(this.btnBlockAccount);
            this.Controls.Add(this.btnCheckBalance);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnBlockAccount;
        private System.Windows.Forms.Button btnCancelBlock;
        private System.Windows.Forms.Button btnExit;
    }
}