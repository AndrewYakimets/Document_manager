using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Security.Principal;
//using System.Security.AccessControl;
using System.Net;
using System.Net.Mail;

namespace LawDocDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillListView(); // При завантаженні головної форми викликається метод, який заповнює компоненту ListView

            if(Properties.Settings.Default.UALanguage == true)
            {
                this.Text = "Менеджер документів";
                menuStrip1.Items[0].Text = "Файл";
                menuStrip1.Items[1].Text = "Вигляд";
                menuStrip1.Items[2].Text = "Налаштування";
                menuStrip1.Items[3].Text = "Виконати";
                menuStrip1.Items[4].Text = "Допомога";

                listView1.Columns[0].Text = "Назва";
                listView1.Columns[1].Text = "Розмір";
                listView1.Columns[2].Text = "Змінено";

                //---------------------------------------------------------------------------------------------------

                exitToolStripMenuItem.Text = "Вихід";

                виглядСпискуДокументівToolStripMenuItem.Text = "Вигляд списку документів";
                сортуватиСписокДокументівToolStripMenuItem.Text = "Сортувати список документів";

                фіфвToolStripMenuItem.Text = "Додати файл";
                видалитиФайлToolStripMenuItem.Text = "Видалити файл";
                відчинитиОсновнуДиректоріюToolStripMenuItem.Text = "Відчинити основну директорію";

                проПрогамуToolStripMenuItem.Text = "Про програму";
                технічнаПідтримкаToolStripMenuItem.Text = "Технічна підтримка";
                авторToolStripMenuItem.Text = "Автор";

                //---------------------------------------------------------------------------------------------------

                детальнийзаЗамовчуваннямToolStripMenuItem.Text = "Детальний (за замовчуванням)";
                зіToolStripMenuItem.Text = "В рядок";
                списокToolStripMenuItem.Text = "Список";
                зменшеноToolStripMenuItem.Text = "В стовпчик";
                плиткаToolStripMenuItem.Text = "Плитка";

                заЗростаннямToolStripMenuItem.Text = "За зростанням";
                заСпаданнямToolStripMenuItem.Text = "За спаданням";

                //---------------------------------------------------------------------------------------------------

                додатиToolStripMenuItem.Text = "Додати";
                видалитиToolStripMenuItem.Text = "Видалити";
                відчинитиОсновнуДиректоріюToolStripMenuItem1.Text = "Відчинити основну директорію";
                оновитиToolStripMenuItem.Text = "Оновити";

                //---------------------------------------------------------------------------------------------------

                groupBox1.Text = "Пошук";
                label1.Text = "Назва файлу :";
                btnFind.Text = "Знайти";
                checkBox1.Text = "Пошук в Google";
            }
            else if (Properties.Settings.Default.ENGLanguage == true)
            {
                this.Text = "Document manager";
                menuStrip1.Items[0].Text = "File";
                menuStrip1.Items[1].Text = "View";
                menuStrip1.Items[2].Text = "Settings";
                menuStrip1.Items[3].Text = "Execute";
                menuStrip1.Items[4].Text = "Help";

                listView1.Columns[0].Text = "Name";
                listView1.Columns[1].Text = "Size";
                listView1.Columns[2].Text = "Changed";

                //---------------------------------------------------------------------------------------------------

                exitToolStripMenuItem.Text = "Exit";

                виглядСпискуДокументівToolStripMenuItem.Text = "Document list view";
                сортуватиСписокДокументівToolStripMenuItem.Text = "Sort document list";

                фіфвToolStripMenuItem.Text = "Add file";
                видалитиФайлToolStripMenuItem.Text = "Delete file";
                відчинитиОсновнуДиректоріюToolStripMenuItem.Text = "Open main directory";

                проПрогамуToolStripMenuItem.Text = "About program";
                технічнаПідтримкаToolStripMenuItem.Text = "Technical support";
                авторToolStripMenuItem.Text = "Author";

                //---------------------------------------------------------------------------------------------------

                детальнийзаЗамовчуваннямToolStripMenuItem.Text = "Detail (default)";
                зіToolStripMenuItem.Text = "In line";
                списокToolStripMenuItem.Text = "List";
                зменшеноToolStripMenuItem.Text = "In column";
                плиткаToolStripMenuItem.Text = "Tile";

                заЗростаннямToolStripMenuItem.Text = "Ascending";
                заСпаданнямToolStripMenuItem.Text = "Descending";

                //---------------------------------------------------------------------------------------------------

                додатиToolStripMenuItem.Text = "Add";
                видалитиToolStripMenuItem.Text = "Delete";
                відчинитиОсновнуДиректоріюToolStripMenuItem1.Text = "Open main directiry";
                оновитиToolStripMenuItem.Text = "Refresh";

                //---------------------------------------------------------------------------------------------------

                groupBox1.Text = "Search";
                label1.Text = "File name :";
                btnFind.Text = "Find";
                checkBox1.Text = "Search in Google";
            }
            else if (Properties.Settings.Default.PLLanguage == true)
            {
                this.Text = "Menedżer dokumentowy";
                menuStrip1.Items[0].Text = "Plik";
                menuStrip1.Items[1].Text = "Widok";
                menuStrip1.Items[2].Text = "Ustawienia";
                menuStrip1.Items[3].Text = "Wykonać";
                menuStrip1.Items[4].Text = "Pomoc";

                listView1.Columns[0].Text = "Nazwa";
                listView1.Columns[1].Text = "Rozmiar";
                listView1.Columns[2].Text = "Zmienione";

                //---------------------------------------------------------------------------------------------------

                exitToolStripMenuItem.Text = "Wyjście";

                виглядСпискуДокументівToolStripMenuItem.Text = "Widok listy dokumentów";
                сортуватиСписокДокументівToolStripMenuItem.Text = "Sortuj listę dokumentów";

                фіфвToolStripMenuItem.Text = "Dodaj plik";
                видалитиФайлToolStripMenuItem.Text = "Usuń plik";
                відчинитиОсновнуДиректоріюToolStripMenuItem.Text = "Otwórz katalog główny";

                проПрогамуToolStripMenuItem.Text = "O programie";
                технічнаПідтримкаToolStripMenuItem.Text = "Wsparcie techniczne";
                авторToolStripMenuItem.Text = "Autor";

                //---------------------------------------------------------------------------------------------------

                детальнийзаЗамовчуваннямToolStripMenuItem.Text = "Szczegółowe (domyślnie)";
                зіToolStripMenuItem.Text = "W linii";
                списокToolStripMenuItem.Text = "Lista";
                зменшеноToolStripMenuItem.Text = "W kolumnie";
                плиткаToolStripMenuItem.Text = "Dachówka";

                заЗростаннямToolStripMenuItem.Text = "Rosnąco";
                заСпаданнямToolStripMenuItem.Text = "Malejąco";

                //---------------------------------------------------------------------------------------------------

                додатиToolStripMenuItem.Text = "Dodać";
                видалитиToolStripMenuItem.Text = "Usunąć";
                відчинитиОсновнуДиректоріюToolStripMenuItem1.Text = "Otwórz katalog główny";
                оновитиToolStripMenuItem.Text = "Odśwież";

                //---------------------------------------------------------------------------------------------------

                groupBox1.Text = "Poszukiwanie";
                label1.Text = "Nazwa pliku :";
                btnFind.Text = "Odnaleźć";
                checkBox1.Text = "Szukaj w Google";
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        bool markered = false;// Змінна - прапорець для роботи з пошуком файлів

        private void fillListView() // Mетод, який заповнює компоненту ListView
        {
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"//DOCDB"); // Ініціалізація змінної з шляхом до основної директорії
            FileInfo[] fiArray; // Ініціалізація масиву, для збереження інформації про файли

            //DirectorySecurity ds = new DirectorySecurity();
            //IdentityReference user = new NTAccount(SystemInformation.UserDomainName, SystemInformation.UserName); // Визначення користувача, який зараз працює

            //ds.SetOwner(user); // Власник - теперішній користувач

            //FileSystemAccessRule permissions = new FileSystemAccessRule(user, FileSystemRights.FullControl, AccessControlType.Allow);
            //ds.AddAccessRule(permissions); // Повний доступ теперішньому користувачу

            //IdentityReference user2 = new NTAccount(SystemInformation.UserDomainName, "Guest");
            //FileSystemAccessRule permissions2 = new FileSystemAccessRule(user2, FileSystemRights.Read | FileSystemRights.ListDirectory, AccessControlType.Allow);
            //ds.AddAccessRule(permissions2);// гостю доступ тiльки для читання

            //di.Create(ds);

            if (di.Exists) // Якщо існує директорія 'Application.StartupPath + @"//DOCDB"', то виконуємо наступний код
            {
                try
                {
                    fiArray = di.GetFiles(); // Отримання всіх файлів
                }
                catch
                {
                    return;
                }

                listView1.Items.Clear(); // Очищення ListView

                foreach (FileInfo fileInfo in fiArray) // Цикл заповнення файлами компоненти ListView
                {
                    ListViewItem lvi = new ListViewItem(fileInfo.Name);// Вивід назви файлу
                    lvi.SubItems.Add((Math.Round(fileInfo.Length / 1024.0)).ToString() + " КB"); // Розмір файлу
                    lvi.SubItems.Add(fileInfo.LastWriteTime.ToString()); // Дати останньої зміни 

                    string filenameExtension = Path.GetExtension(fileInfo.Name).ToLower();// Отримання розширення файлу

                    switch (filenameExtension) // Умова перевірки розширення файлу, щоб присвоїти йому відповідну іконку
                    {
                        case ".txt":
                            {
                                lvi.ImageIndex = 0;
                                break;
                            }
                        case ".doc":
                            {
                                lvi.ImageIndex = 1;
                                break;
                            }
                        case ".docx":
                            {
                                lvi.ImageIndex = 1;
                                break;
                            }
                        case ".xls":
                            {
                                lvi.ImageIndex = 2;
                                break;
                            }
                        case ".xlsx":
                            {
                                lvi.ImageIndex = 2;
                                break;
                            }
                        case ".jpg":
                            {
                                lvi.ImageIndex = 4;
                                break;
                            }
                        case ".jpeg":
                            {
                                lvi.ImageIndex = 4;
                                break;
                            }
                        case ".gif":
                            {
                                lvi.ImageIndex = 4;
                                break;
                            }
                        case ".tiff":
                            {
                                lvi.ImageIndex = 4;
                                break;
                            }
                        case ".bmp":
                            {
                                lvi.ImageIndex = 4;
                                break;
                            }
                        case ".png":
                            {
                                lvi.ImageIndex = 4;
                                break;
                            }
                        case ".psd":
                            {
                                lvi.ImageIndex = 4;
                                break;
                            }
                        case ".pdf":
                            {
                                lvi.ImageIndex = 5;
                                break;
                            }

                        default:
                            {
                                lvi.ImageIndex = 3;
                                break;
                            }
                    }

                    listView1.Items.Add(lvi); // Заповнення ListView

                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Налаштування стовпців ListView на автоматичну зміну ширини
                }
            }
            else // інакшу створюємо цю директорію і виводимо файли, які вона ніби має
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + @"//DOCDB");
                fillListView();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e) // Метод, де описано код, який виконується при натисканні 
        {                                                               // ЛКМ на будь-який файл, що відображається у ListView
            try
            {
                string p = Application.StartupPath + @"//DOCDB//" + listView1.FocusedItem.Text; // Змінна, що вміщає адресу на натиснутий файл
                string s = Path.GetExtension(p).ToLower(); // Отримання розширення файлу з цієї адреси

                // Умов, що перевіряють розширення натиснутого файлу та виконують відповідні процеси, щоб відкрити ці файли
                if (s == ".txt") 
                {
                    Process.Start(p);
                }
                else if (s == ".doc" || s == ".docx")
                {
                    Process.Start(p);
                }
                else if (s == ".xls" || s == ".xlsx")
                {
                    Process.Start(p);
                }
                else if (s == ".pdf")
                {
                    Process.Start(p);
                }
                else if (s == ".jpg" || s == ".jpeg" || s == ".bmp" || s == ".gif" || s == ".psd" || s == ".png")
                {
                    Process.Start(p);
                }
            }
            catch (Exception Exc) // Якщо щось піде не так, то вискочить повідомлення про відповідну помилку
            {
                MessageBox.Show(Exc.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AddFIle() // Метод додавання нового файлу до директорії DOCDB
        {
            ofd.InitialDirectory = @"C:\"; // Директорія, яка за замовчуванням відкривається при виклику діалогового вікна
            if (Properties.Settings.Default.UALanguage == true)
                ofd.Title = "Будь ласка, вкажіть файл, який ви бажаєте додалити:";
            else if (Properties.Settings.Default.ENGLanguage == true)
                ofd.Title = "Please, choose the file you want to add:";
            else if (Properties.Settings.Default.PLLanguage == true)
                ofd.Title = "Proszę, wybierz plik, który chcesz dodać:";

            ofd.Filter = "txt files (*.txt)|*.txt" + 
                         "|word doc (*.doc)|*.doc" + 
                         "|word docx (*.docx)|*.docx" +
                         "|Excel 97-2003 (*.xls)" +
                         "|Excel 2007-2014 (*.xlsx)" +
                         "|JPEG file (*.jpg)|*.jpg" +
                         "|PNG file (*.png)|*.png" +
                         "|PSD file (*.psd)|*.psd" +
                         "|PDF file (*.pdf)|*.pdf" +
                         "|GIF file (*.gif)|*.gif" +
                         "|BMP file (*.bmp)|*.bmp" +
                         "|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK) // Якщо діалог завершився успішно, то виконується наступний код
            {
                string path = ofd.SafeFileName; // Запис у змінну назви збереженого файлу
                string pathname = Path.GetDirectoryName(ofd.FileName); // Отримання шляху збереженого файлу у змінну
                string dest = Application.StartupPath + @"//DOCDB//"; // Оголошення змінної з шляхом основної директорії


                string sourceFile = System.IO.Path.Combine(pathname, path); // Зміннв, яка містить комбінацію повної адреси файлу, що додається + його ім'я
                string destFile = System.IO.Path.Combine(dest, path); // Зміннв, яка містить комбінацію адреси основної директорії і назви файлу, що додається
                System.IO.File.Copy(sourceFile, destFile, true); // Комбінуємо це все і, в результаті, копіюємо (Додаємо) файл

                fillListView(); // Оновлення ListView
                this.Refresh(); // Оновлення основної форми
            }
        }

        void DeleteCurrentFile(string FileName) // Метод видалення обраного файлу через контекстне меню
        {
            string path = Application.StartupPath + @"//DOCDB//" + FileName; // Запис шдяху де він знаходиться

            System.IO.File.Delete(path); // Виклик методу і передача шляху до хайлу як параметр

            fillListView(); // Оновлення ListView
            this.Refresh(); // Оновлення основної форми
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        // Виконавчий код для пунктів говлоного меню
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void детальнийзаЗамовчуваннямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void зіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void зменшеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void плиткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void заЗростаннямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
        }

        private void заСпаданнямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Descending;
        }

        private void видалитиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = Application.StartupPath + @"//DOCDB//";
            if (Properties.Settings.Default.UALanguage == true)
                ofd.Title = "Будь ласка, вкажіть файл, який ви бажаєте видалити:";
            else if (Properties.Settings.Default.ENGLanguage == true)
                ofd.Title = "Please, choose the file you want to delete:";
            else if (Properties.Settings.Default.PLLanguage == true)
                ofd.Title = "Proszę, wybierz plik, który chcesz usunąć:";

            ofd.Filter = "txt files (*.txt)|*.txt" +
              "|word doc (*.doc)|*.doc" +
              "|word docx (*.docx)|*.docx" +
              "|Excel 97-2003 (*.xls)" +
              "|Excel 2007-2014 (*.xlsx)" +
              "|JPEG file (*.jpg)|*.jpg" +
              "|PNG file (*.png)|*.png" +
              "|PSD file (*.psd)|*.psd" +
              "|PDF file (*.pdf)|*.pdf" +
              "|GIF file (*.gif)|*.gif" +
              "|BMP file (*.bmp)|*.bmp" +
              "|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                System.IO.File.Delete(path);

                fillListView();
                this.Refresh();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        // Виконавчий код контекстного меню
        //---------------------------------------------------------------------------------------------------------------------------------------------------------

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFIle();
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CurrentFileName = listView1.FocusedItem.Text;

            DeleteCurrentFile(CurrentFileName);
        }

        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillListView();
            this.Refresh();
        }

        private void відчинитиОсновнуДиректоріюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"//DOCDB//");
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        // Продовження коду для головного меню
        //---------------------------------------------------------------------------------------------------------------------------------------------------------

        private void технічнаПідтримкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UALanguage == true)
            {
                MessageBox.Show("   Якщо у вас виникли питання, щодо використання даного програмного забезпечення," +
                                " то Ви можете звернутись до розробника за електронною адресою: \n\n" +
                                @"                          andriyakimets@gmail.com", "Технічна підтримка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Properties.Settings.Default.ENGLanguage == true)
            {

                MessageBox.Show("   If you have any questions regarding the use of this software," +
                                           " you can contact the developer by the following email: \n\n" +
                                           @"                          andriyakimets@gmail.com", "Technical support", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Properties.Settings.Default.PLLanguage == true)
            {

                MessageBox.Show("   Jeśli masz jakiekolwiek pytania dotyczące korzystania z tego oprogramowania," +
                                           " można skontaktować się z deweloperem brzmienie email: \n\n" +
                                           @"                          andriyakimets@gmail.com", "Wsparcie techniczne", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void проПрогамуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UALanguage == true)
            {
                MessageBox.Show("   Дана програма призначена для зберігання в одному місці всіх необхідних документів (і зображень)."
                                 + "Також, за допомогою неї можна відкриваті ці документи (зображення). Щоб легко знаходити потрібні документи,"
                                 + " можна скористатися пошуком. Також, можливо виконати пошук будь-якої інформації за допомогою Google.",
                                 "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Properties.Settings.Default.ENGLanguage == true)
            {
                MessageBox.Show("   This program is designed to store in one place all the required documents (and images)."
                                 + " Also, you can use it to open these documents (images). You can use the search to find"
                                 + " your documens easily. It may also search any information via Google.",
                                 "About programm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Properties.Settings.Default.PLLanguage == true)
            {
                MessageBox.Show("   Program ten przeznaczony jest do przechowywania w jednym miejscu wszystkie wymagane dokumenty (i obraz)."
                                 + "Ponadto, można użyć go do otwarcia tych dokumentów (obraz). Możesz skorzystać z wyszukiwarki, aby łatwo "
                                 + "odnaleźć swoje dokumenty. Może też szukać jakichkolwiek informacji za pośrednictwem Google.",
                                 "O programie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UALanguage == true)
                MessageBox.Show("Автор: Якімець Андрій\n\n         Львів, 2015", "Про автора", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (Properties.Settings.Default.ENGLanguage == true)
                MessageBox.Show("Author: Andrew Yakimets\n\n         Lviv, 2015", "About author", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (Properties.Settings.Default.PLLanguage == true)
                MessageBox.Show("Autor: Andrew Yakimets\n\n         Lwów, 2015", "O autorze", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnFind_Click(object sender, EventArgs e) // Метод для виконання пошуку файлу або в Google при натискані кнопки
        {
            ListViewItem lv = listView1.FindItemWithText(txbxSearchText.Text); // Запис тексту для пошуку у змінну

            try
            {
                if (checkBox1.Checked == false) // Якщо не обрано пошук в Google
                {
                    if (txbxSearchText.Text == "") // Перевірка чи не пустий textBox
                    {
                        if (Properties.Settings.Default.UALanguage == true)
                            MessageBox.Show("Ви не ввели назву файлу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (Properties.Settings.Default.ENGLanguage == true)
                            MessageBox.Show("You did not enter the file name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (Properties.Settings.Default.PLLanguage == true)
                            MessageBox.Show("Nie wprowadzono nazwy pliku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (lv == null) // Перевірка чи існує файл з таким іменем
                    {
                        if (Properties.Settings.Default.UALanguage == true)
                            MessageBox.Show("Не вдалося знайти файл з такою назвою!", "Пошук файлу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (Properties.Settings.Default.ENGLanguage == true)
                            MessageBox.Show("Can not find a file with such name!", "File search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (Properties.Settings.Default.PLLanguage == true)
                            MessageBox.Show("Nie można odnaleźć pliku o tej samej nazwie!", "Wyszukiwarka pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else // Якщо все добре, то
                    {
                        if (markered == false) // Перевіряємо чи змінна - прапорець true. Це зроблено для того, щоб при повторному пошуку знайдені
                        {                      // файли не накопичувались на початку списку. Інакше - це матиме неестетичний вигляд
                            listView1.Items.Remove(lv); // Видаляємо з поточної позиції файл
                            listView1.Items.Insert(0, lv); // Переміщаємо на першу позицію

                            lv.BackColor = Color.Yellow; // Виділяємо його жовтим кольором
                            lv.Selected = true;// Виділяємо знайдений файл
                            markered = true; // Присвоюємо змінній прапорцю true
                        }
                        else
                        {
                            fillListView(); // Оновлюємо список файлів ListView
                                            // Повторюємо теж, що було трохи вище
                            listView1.Items.Remove(lv);
                            listView1.Items.Insert(0, lv);

                            lv.BackColor = Color.Yellow;
                            lv.Selected = true;
                        }
                    }
                }
                else // Якщо обрано пошук в Google
                {
                    if (txbxSearchText.Text == "") // Якщо поле для вводу не пусте
                    {
                        if (Properties.Settings.Default.UALanguage == true)
                            MessageBox.Show("Ви не ввели текст того, що бажаєте знайти!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (Properties.Settings.Default.ENGLanguage == true)
                            MessageBox.Show("You did not input any text of that thing you want to find!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (Properties.Settings.Default.PLLanguage == true)
                            MessageBox.Show("Nie zrobił wejście dowolny tekst tej rzeczy, którą chcesz znaleźć!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else // То відкривається браузер із сторінкою Google, де виконується пошук набраної інформації
                    {
                        Process.Start("https://www.google.com/search?q=" + txbxSearchText.Text);
                    }
                }
            }
            catch (Exception ex) // Якщо щось піде не так, то вискочить повідомлення про відповідну помилку
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) // Метод, який закриває програму повністю при закритті головної форми
        {
            Application.Exit();
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm SF = new SettingsForm();
            SF.ShowDialog();
        }

        private void надіслатиЛистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailSendForm msf = new MailSendForm();

            msf.ShowDialog();
        }

        //private void CheckTheDoubleRun()
        //{
        //    bool onlyInstance;
        //    Mutex mtx = new Mutex(true, "LawDocDB", out onlyInstance);

        //    if (onlyInstance) // Перевіряємо, чи не запущена програма
        //    {
        //        Application.Run();
        //    }
        //    else // Якщо так, то виводимо відповідне повідомлення
        //    {
        //        if (Properties.Settings.Default.UALanguage == true)
        //            MessageBox.Show("Програму вже запущено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //        else if (Properties.Settings.Default.ENGLanguage == true)
        //            MessageBox.Show("This programm is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //        else if (Properties.Settings.Default.ENGLanguage == true)
        //            MessageBox.Show("Program jest już uruchomiony!", "błąd", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    }
        //}
    }
}
