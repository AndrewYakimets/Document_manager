namespace LawDocDB
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveSettBtn = new System.Windows.Forms.Button();
            this.PLRb = new System.Windows.Forms.RadioButton();
            this.ENGRb = new System.Windows.Forms.RadioButton();
            this.UARb = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PLRb);
            this.groupBox1.Controls.Add(this.ENGRb);
            this.groupBox1.Controls.Add(this.UARb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мова інтерфейсу :";
            // 
            // SaveSettBtn
            // 
            this.SaveSettBtn.Location = new System.Drawing.Point(60, 130);
            this.SaveSettBtn.Name = "SaveSettBtn";
            this.SaveSettBtn.Size = new System.Drawing.Size(108, 23);
            this.SaveSettBtn.TabIndex = 1;
            this.SaveSettBtn.Text = "Зберегти";
            this.SaveSettBtn.UseVisualStyleBackColor = true;
            this.SaveSettBtn.Click += new System.EventHandler(this.SaveSettBtn_Click);
            // 
            // PLRb
            // 
            this.PLRb.AutoSize = true;
            this.PLRb.Checked = global::LawDocDB.Properties.Settings.Default.PLLanguage;
            this.PLRb.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LawDocDB.Properties.Settings.Default, "PLLanguage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PLRb.Location = new System.Drawing.Point(48, 77);
            this.PLRb.Name = "PLRb";
            this.PLRb.Size = new System.Drawing.Size(53, 17);
            this.PLRb.TabIndex = 0;
            this.PLRb.Text = "Polski";
            this.PLRb.UseVisualStyleBackColor = true;
            // 
            // ENGRb
            // 
            this.ENGRb.AutoSize = true;
            this.ENGRb.Checked = global::LawDocDB.Properties.Settings.Default.ENGLanguage;
            this.ENGRb.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LawDocDB.Properties.Settings.Default, "ENGLanguage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ENGRb.Location = new System.Drawing.Point(48, 54);
            this.ENGRb.Name = "ENGRb";
            this.ENGRb.Size = new System.Drawing.Size(59, 17);
            this.ENGRb.TabIndex = 0;
            this.ENGRb.Text = "English";
            this.ENGRb.UseVisualStyleBackColor = true;
            // 
            // UARb
            // 
            this.UARb.AutoSize = true;
            this.UARb.Checked = global::LawDocDB.Properties.Settings.Default.UALanguage;
            this.UARb.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LawDocDB.Properties.Settings.Default, "UALanguage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UARb.Location = new System.Drawing.Point(48, 31);
            this.UARb.Name = "UARb";
            this.UARb.Size = new System.Drawing.Size(84, 17);
            this.UARb.TabIndex = 0;
            this.UARb.TabStop = true;
            this.UARb.Text = "Українська";
            this.UARb.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 164);
            this.Controls.Add(this.SaveSettBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveSettBtn;
        private System.Windows.Forms.RadioButton PLRb;
        private System.Windows.Forms.RadioButton ENGRb;
        private System.Windows.Forms.RadioButton UARb;
    }
}