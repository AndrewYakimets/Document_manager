using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawDocDB
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveSettBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (UARb.Checked == true)
                {
                    if (MessageBox.Show("Налаштування набудуть чинності після перезавантаження програми. Ви непроти перезавантажити її?", "Налаштування",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        Application.Restart();
                }
                else if (ENGRb.Checked == true)
                {
                    if (MessageBox.Show("Setting will take effect after program restart. Would you like to restart it?", "Settings",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        Application.Restart();
                }
                else if (PLRb.Checked == true)
                {
                    if (MessageBox.Show("Ustawienie zacznie obowiązywać po ponownym uruchomieniu programu. Czy chciałbyś, aby uruchomić go ponownie?", "Ustawienia",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        Application.Restart();
                }
                else
                {
                    MessageBox.Show("Please, choose the interface lenguage!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UALanguage == true)
            {
                this.Text = "Налаштування";
                groupBox1.Text = "Мова інтерфейсу :";
                SaveSettBtn.Text = "Зберегти";
            }
            else if (Properties.Settings.Default.ENGLanguage == true)
            {
                this.Text = "Settings";
                groupBox1.Text = "Interface language :";
                SaveSettBtn.Text = "Save";
            }
            else if (Properties.Settings.Default.PLLanguage == true)
            {
                this.Text = "Ustawienia";
                groupBox1.Text = "Przemówienie interfejsowe :";
                SaveSettBtn.Text = "Zapisz";
            }
        }
    }
}
