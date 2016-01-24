namespace LawDocDB
{
    partial class MailSendForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginTxbx = new System.Windows.Forms.TextBox();
            this.PwdMskTxbx = new System.Windows.Forms.MaskedTextBox();
            this.toTxbx = new System.Windows.Forms.TextBox();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PwdLbl = new System.Windows.Forms.Label();
            this.ToLbl = new System.Windows.Forms.Label();
            this.MailTextTxbx = new System.Windows.Forms.TextBox();
            this.AttachFileBtn = new System.Windows.Forms.Button();
            this.SendMailBtn = new System.Windows.Forms.Button();
            this.AttachedFIleLbl = new System.Windows.Forms.Label();
            this.MailThemeTxbx = new System.Windows.Forms.TextBox();
            this.MailThemeLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AttachedFIleLbl);
            this.groupBox1.Controls.Add(this.SendMailBtn);
            this.groupBox1.Controls.Add(this.AttachFileBtn);
            this.groupBox1.Controls.Add(this.MailTextTxbx);
            this.groupBox1.Controls.Add(this.MailThemeLbl);
            this.groupBox1.Controls.Add(this.ToLbl);
            this.groupBox1.Controls.Add(this.PwdLbl);
            this.groupBox1.Controls.Add(this.LoginLbl);
            this.groupBox1.Controls.Add(this.MailThemeTxbx);
            this.groupBox1.Controls.Add(this.toTxbx);
            this.groupBox1.Controls.Add(this.PwdMskTxbx);
            this.groupBox1.Controls.Add(this.LoginTxbx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Надсилання e-mail листа :";
            // 
            // LoginTxbx
            // 
            this.LoginTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginTxbx.Location = new System.Drawing.Point(223, 28);
            this.LoginTxbx.Name = "LoginTxbx";
            this.LoginTxbx.Size = new System.Drawing.Size(185, 20);
            this.LoginTxbx.TabIndex = 0;
            // 
            // PwdMskTxbx
            // 
            this.PwdMskTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PwdMskTxbx.Location = new System.Drawing.Point(223, 55);
            this.PwdMskTxbx.Name = "PwdMskTxbx";
            this.PwdMskTxbx.PasswordChar = '*';
            this.PwdMskTxbx.Size = new System.Drawing.Size(185, 20);
            this.PwdMskTxbx.TabIndex = 1;
            // 
            // toTxbx
            // 
            this.toTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.toTxbx.Location = new System.Drawing.Point(223, 81);
            this.toTxbx.Name = "toTxbx";
            this.toTxbx.Size = new System.Drawing.Size(185, 20);
            this.toTxbx.TabIndex = 2;
            // 
            // LoginLbl
            // 
            this.LoginLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(182, 31);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(37, 13);
            this.LoginLbl.TabIndex = 3;
            this.LoginLbl.Text = "Логін:";
            // 
            // PwdLbl
            // 
            this.PwdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PwdLbl.AutoSize = true;
            this.PwdLbl.Location = new System.Drawing.Point(169, 58);
            this.PwdLbl.Name = "PwdLbl";
            this.PwdLbl.Size = new System.Drawing.Size(48, 13);
            this.PwdLbl.TabIndex = 3;
            this.PwdLbl.Text = "Пароль:";
            // 
            // ToLbl
            // 
            this.ToLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ToLbl.AutoSize = true;
            this.ToLbl.Location = new System.Drawing.Point(181, 84);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(36, 13);
            this.ToLbl.TabIndex = 3;
            this.ToLbl.Text = "Кому:";
            // 
            // MailTextTxbx
            // 
            this.MailTextTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTextTxbx.Location = new System.Drawing.Point(12, 141);
            this.MailTextTxbx.Multiline = true;
            this.MailTextTxbx.Name = "MailTextTxbx";
            this.MailTextTxbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MailTextTxbx.Size = new System.Drawing.Size(584, 207);
            this.MailTextTxbx.TabIndex = 4;
            // 
            // AttachFileBtn
            // 
            this.AttachFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AttachFileBtn.Location = new System.Drawing.Point(13, 355);
            this.AttachFileBtn.Name = "AttachFileBtn";
            this.AttachFileBtn.Size = new System.Drawing.Size(110, 23);
            this.AttachFileBtn.TabIndex = 5;
            this.AttachFileBtn.Text = "Прикріпити файл";
            this.AttachFileBtn.UseVisualStyleBackColor = true;
            this.AttachFileBtn.Click += new System.EventHandler(this.AttachFileBtn_Click);
            // 
            // SendMailBtn
            // 
            this.SendMailBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SendMailBtn.Location = new System.Drawing.Point(238, 392);
            this.SendMailBtn.Name = "SendMailBtn";
            this.SendMailBtn.Size = new System.Drawing.Size(88, 27);
            this.SendMailBtn.TabIndex = 6;
            this.SendMailBtn.Text = "Надіслати";
            this.SendMailBtn.UseVisualStyleBackColor = true;
            this.SendMailBtn.Click += new System.EventHandler(this.SendMailBtn_Click);
            // 
            // AttachedFIleLbl
            // 
            this.AttachedFIleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AttachedFIleLbl.AutoSize = true;
            this.AttachedFIleLbl.Location = new System.Drawing.Point(129, 360);
            this.AttachedFIleLbl.Name = "AttachedFIleLbl";
            this.AttachedFIleLbl.Size = new System.Drawing.Size(116, 13);
            this.AttachedFIleLbl.TabIndex = 7;
            this.AttachedFIleLbl.Text = "Файл не прикріплено";
            // 
            // MailThemeTxbx
            // 
            this.MailThemeTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MailThemeTxbx.Location = new System.Drawing.Point(223, 107);
            this.MailThemeTxbx.Name = "MailThemeTxbx";
            this.MailThemeTxbx.Size = new System.Drawing.Size(185, 20);
            this.MailThemeTxbx.TabIndex = 2;
            // 
            // MailThemeLbl
            // 
            this.MailThemeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MailThemeLbl.AutoSize = true;
            this.MailThemeLbl.Location = new System.Drawing.Point(181, 110);
            this.MailThemeLbl.Name = "MailThemeLbl";
            this.MailThemeLbl.Size = new System.Drawing.Size(37, 13);
            this.MailThemeLbl.TabIndex = 3;
            this.MailThemeLbl.Text = "Тема:";
            // 
            // MailSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 431);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(297, 284);
            this.Name = "MailSendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailSendForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MailTextTxbx;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.Label PwdLbl;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.TextBox toTxbx;
        private System.Windows.Forms.MaskedTextBox PwdMskTxbx;
        private System.Windows.Forms.TextBox LoginTxbx;
        private System.Windows.Forms.Label AttachedFIleLbl;
        private System.Windows.Forms.Button SendMailBtn;
        private System.Windows.Forms.Button AttachFileBtn;
        private System.Windows.Forms.Label MailThemeLbl;
        private System.Windows.Forms.TextBox MailThemeTxbx;
    }
}