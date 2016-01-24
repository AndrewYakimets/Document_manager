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
    public partial class IdentificationForm : Form
    {
        public IdentificationForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e) // Метод визначення користувача, який виконується при натисканні кнопки
        {
            try
            {
                if (textBox1.Text == "" || maskedTextBox1.Text == "") // Перевіряється, чи пусті поля для вводу
                {
                    if (Properties.Settings.Default.UALanguage == true)
                        MessageBox.Show("Поля для введення пусті!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (Properties.Settings.Default.ENGLanguage == true)
                        MessageBox.Show("Entry fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (Properties.Settings.Default.PLLanguage == true)
                        MessageBox.Show("Pole wprowadzania pusty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }// Якщо містяться логін і пароль клієнта або розробника, то відкриваємо головну форму
                else if (textBox1.Text.Contains("admin") && maskedTextBox1.Text.Contains("1") || textBox1.Text.Contains("garhion") && maskedTextBox1.Text.Contains("shell"))
                {
                    if (Properties.Settings.Default.UALanguage == true)
                        MessageBox.Show("Вітаю вас, " + textBox1.Text + "!");
                    else if (Properties.Settings.Default.ENGLanguage == true)
                        MessageBox.Show("Welcome, " + textBox1.Text + "!");
                    else if (Properties.Settings.Default.PLLanguage == true)
                        MessageBox.Show("Powitanie, " + textBox1.Text + "!");


                    textBox1.Text = "";
                    maskedTextBox1.Text = "";

                    MainForm f = new MainForm();
                    f.ShowDialog();
                    this.Hide();
                }
                else // Інакше виводимо повідомлення про неправильний логін і пароль
                {
                    if (Properties.Settings.Default.UALanguage == true)
                        MessageBox.Show("Логін і/або пароль введені неправильно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (Properties.Settings.Default.ENGLanguage == true)
                        MessageBox.Show("Login and/or password have been inputted incorrectly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (Properties.Settings.Default.PLLanguage == true)
                        MessageBox.Show("Logowanie i / lub hasło zostały wprowadzone niepoprawnie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)  // Якщо щось піде не так, то вискочить повідомлення про відповідну помилку
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdentificationForm_FormClosed(object sender, FormClosedEventArgs e)  // Метод, який закриває програму повністю при закритті даної форми
        {
            Application.Exit();
        }

        private void IdentificationForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UALanguage == true)
            {
                this.Text = "Ідентифікація";
                groupBox1.Text = "Введіть дані для ідентифікації:";
                label1.Text = "Логін:";
                label2.Text = "Пароль:";
                btnEnter.Text = "Увійти";

            }
            else if (Properties.Settings.Default.ENGLanguage == true)
            {
                this.Text = "Identification";
                groupBox1.Text = "Input data for identification:";
                label1.Text = "Login:";
                label2.Text = "Password:";
                btnEnter.Text = "Enter";
            }
            else if (Properties.Settings.Default.PLLanguage == true)
            {
                this.Text = "Identyfikacja";
                groupBox1.Text = "Dane wejściowe do identyfikacji:";
                label1.Text = "Login:";
                label2.Text = "     Hasło:";
                btnEnter.Text = "Wpisać";
            }
        }
    }
}
