using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

namespace LawDocDB
{
    public partial class MailSendForm : Form
    {
        public MailSendForm()
        {
            InitializeComponent();
        }

        string AttachedFileName = null;
        string AttachedFilePath = null;

        Attachment attach;

        public static void SendMail(string smtpServer, string from, string password,
                                    string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mail.Sent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendMailBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                string Login = LoginTxbx.Text.ToString().Trim();
                string Password = PwdMskTxbx.Text.ToString();
                string MailTo = toTxbx.Text.ToString().Trim();

                SendMail("smtp.gmail.com", Login, Password, MailTo, MailThemeTxbx.Text.ToString(), MailTextTxbx.Text.ToString(), "C:\\IFRToolLog.txt");

            //    //Указываем SMTP сервер и авторизуемся.
            //    SmtpClient Smtp_Client = new SmtpClient("smtp.gmail.com", 25);
            //    Smtp_Client.Credentials = new NetworkCredential(Login, Password);
            //    //Выключаем или включаем SSL - (например для гугла должен быть включен).
            //    Smtp_Client.EnableSsl = true;

            //    //Приступаем к формированию самого письма
            //    MailMessage Message = new MailMessage();
            //    Message.From = new MailAddress(Login);// от кого
            //    Message.To.Add(new MailAddress(MailTo));// кому
            //    Message.Subject = MailThemeTxbx.Text.ToString();
            //    Message.Body = MailTextTxbx.Text.ToString();

            //    ////Теперь прикрепим файл к сообщению...
                
            //    //if (attach.ContentDisposition != null)
            //    //    Message.Attachments.Add(attach);
            //    //else
            //    //{
            //    //    //...
            //    //}

            //    Smtp_Client.Send(Message);//непосредственно само отправление...
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    MessageBox.Show("Повідомлення успішно надіслано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    string AttachedFileName = null;
            //    string AttachedFilePath = null;
            //    string Login = null;
            //    string Password = null;
            //    string MailTo = null;

            //    LoginTxbx.Text = null;
            //    PwdMskTxbx.Text = null;
            //    toTxbx.Text = null;
            //    MailThemeTxbx.Text = null;
            //    MailTextTxbx.Text = null;
            //}
        }

        private void AttachFileBtn_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();

            //ofd.InitialDirectory = @"C:\"; // Директорія, яка за замовчуванням відкривається при виклику діалогового вікна
            //if (Properties.Settings.Default.UALanguage == true)
            //    ofd.Title = "Будь ласка, вкажіть файл, який ви бажаєте додалити:";
            //else if (Properties.Settings.Default.ENGLanguage == true)
            //    ofd.Title = "Please, choose the file you want to add:";
            //else if (Properties.Settings.Default.PLLanguage == true)
            //    ofd.Title = "Proszę, wybierz plik, który chcesz dodać:";

            //ofd.Filter = "txt files (*.txt)|*.txt" +
            //             "|word doc (*.doc)|*.doc" +
            //             "|word docx (*.docx)|*.docx" +
            //             "|Excel 97-2003 (*.xls)" +
            //             "|Excel 2007-2014 (*.xlsx)" +
            //             "|JPEG file (*.jpg)|*.jpg" +
            //             "|PNG file (*.png)|*.png" +
            //             "|PSD file (*.psd)|*.psd" +
            //             "|PDF file (*.pdf)|*.pdf" +
            //             "|GIF file (*.gif)|*.gif" +
            //             "|BMP file (*.bmp)|*.bmp" +
            //             "|All files (*.*)|*.*";

            //if (ofd.ShowDialog() == DialogResult.OK) // Якщо діалог завершився успішно, то виконується наступний код
            //{
            //    AttachedFileName = ofd.SafeFileName; // Запис у змінну назви збереженого файлу
            //    AttachedFilePath = Path.GetDirectoryName(ofd.FileName); // Отримання шляху збереженого файлу у змінну

            //    AttachedFIleLbl.Text = AttachedFileName.ToString();

            //    attach = new Attachment(AttachedFilePath, MediaTypeNames.Application.Octet);

            //    ContentDisposition disposition = attach.ContentDisposition;
            //    disposition.CreationDate = System.IO.File.GetCreationTime(AttachedFilePath);
            //    disposition.ModificationDate = System.IO.File.GetLastWriteTime(AttachedFilePath);
            //    disposition.ReadDate = System.IO.File.GetLastAccessTime(AttachedFilePath);
            //}
            
        }
    }
}
