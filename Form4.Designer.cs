namespace CS_ATM
{
    partial class Deposite
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtfReceipt = new System.Windows.Forms.RichTextBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(55, 62);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Enter Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(132, 59);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(107, 117);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(143, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirmation of Admin";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDeposite
            // 
            this.btnDeposite.Location = new System.Drawing.Point(75, 175);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Size = new System.Drawing.Size(75, 23);
            this.btnDeposite.TabIndex = 4;
            this.btnDeposite.Text = "Deposite";
            this.btnDeposite.UseVisualStyleBackColor = true;
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.btnAccept);
            this.panelAdmin.Controls.Add(this.txtPassword);
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Location = new System.Drawing.Point(281, 31);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(170, 109);
            this.panelAdmin.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin\'s Password";
            // 
            // rtfReceipt
            // 
            this.rtfReceipt.Location = new System.Drawing.Point(477, 12);
            this.rtfReceipt.Name = "rtfReceipt";
            this.rtfReceipt.Size = new System.Drawing.Size(276, 171);
            this.rtfReceipt.TabIndex = 7;
            this.rtfReceipt.Text = "";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(173, 175);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(75, 23);
            this.btnReceipt.TabIndex = 8;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(263, 175);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(66, 75);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Deposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 279);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.rtfReceipt);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeposite);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Deposite";
            this.Text = "Deposite";
            this.Load += new System.EventHandler(this.Deposite_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDeposite;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtfReceipt;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAccept;
    }
}