namespace LawDocDB
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виконатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxSearchText = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відчинитиОсновнуДиректоріюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виглядСпискуДокументівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.детальнийзаЗамовчуваннямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зменшеноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плиткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуватиСписокДокументівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заЗростаннямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заСпаданнямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фіфвToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відчинитиОсновнуДиректоріюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрогамуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.технічнаПідтримкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.надіслатиЛистаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(730, 387);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Назва";
            this.columnHeader1.Width = 348;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Розмір";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Змінено";
            this.columnHeader3.Width = 255;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.відчинитиОсновнуДиректоріюToolStripMenuItem1,
            this.оновитиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 92);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "page_white_text.png");
            this.imageList1.Images.SetKeyName(1, "page_white_word.png");
            this.imageList1.Images.SetKeyName(2, "page_white_excel.png");
            this.imageList1.Images.SetKeyName(3, "page.png");
            this.imageList1.Images.SetKeyName(4, "picture.png");
            this.imageList1.Images.SetKeyName(5, "Adobe_Acrobat_Icon_16.png");
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // виглядToolStripMenuItem
            // 
            this.виглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.виглядСпискуДокументівToolStripMenuItem,
            this.сортуватиСписокДокументівToolStripMenuItem});
            this.виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
            this.виглядToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.виглядToolStripMenuItem.Text = "Вигляд";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрогамуToolStripMenuItem,
            this.технічнаПідтримкаToolStripMenuItem,
            this.авторToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.виглядToolStripMenuItem,
            this.налаштуванняToolStripMenuItem,
            this.виконатиToolStripMenuItem,
            this.допомогаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // виконатиToolStripMenuItem
            // 
            this.виконатиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фіфвToolStripMenuItem,
            this.видалитиФайлToolStripMenuItem,
            this.відчинитиОсновнуДиректоріюToolStripMenuItem,
            this.надіслатиЛистаToolStripMenuItem});
            this.виконатиToolStripMenuItem.Name = "виконатиToolStripMenuItem";
            this.виконатиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.виконатиToolStripMenuItem.Text = "Виконати";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 74);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbxSearchText);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук :";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(548, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Пошук в Google";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва файлу :";
            // 
            // txbxSearchText
            // 
            this.txbxSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxSearchText.Location = new System.Drawing.Point(188, 19);
            this.txbxSearchText.Name = "txbxSearchText";
            this.txbxSearchText.Size = new System.Drawing.Size(354, 20);
            this.txbxSearchText.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFind.Location = new System.Drawing.Point(320, 45);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Знайти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.add;
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.delete;
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // відчинитиОсновнуДиректоріюToolStripMenuItem1
            // 
            this.відчинитиОсновнуДиректоріюToolStripMenuItem1.Image = global::LawDocDB.Properties.Resources.arrow_right;
            this.відчинитиОсновнуДиректоріюToolStripMenuItem1.Name = "відчинитиОсновнуДиректоріюToolStripMenuItem1";
            this.відчинитиОсновнуДиректоріюToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.відчинитиОсновнуДиректоріюToolStripMenuItem1.Text = "Відчинити основну директорію";
            this.відчинитиОсновнуДиректоріюToolStripMenuItem1.Click += new System.EventHandler(this.відчинитиОсновнуДиректоріюToolStripMenuItem_Click);
            // 
            // оновитиToolStripMenuItem
            // 
            this.оновитиToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.arrow_rotate_clockwise;
            this.оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            this.оновитиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.оновитиToolStripMenuItem.Text = "Оновити";
            this.оновитиToolStripMenuItem.Click += new System.EventHandler(this.оновитиToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.door_in;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // виглядСпискуДокументівToolStripMenuItem
            // 
            this.виглядСпискуДокументівToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.детальнийзаЗамовчуваннямToolStripMenuItem,
            this.зіToolStripMenuItem,
            this.списокToolStripMenuItem,
            this.зменшеноToolStripMenuItem,
            this.плиткаToolStripMenuItem});
            this.виглядСпискуДокументівToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.application_view_list;
            this.виглядСпискуДокументівToolStripMenuItem.Name = "виглядСпискуДокументівToolStripMenuItem";
            this.виглядСпискуДокументівToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.виглядСпискуДокументівToolStripMenuItem.Text = "Вигляд списку документів";
            // 
            // детальнийзаЗамовчуваннямToolStripMenuItem
            // 
            this.детальнийзаЗамовчуваннямToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.tick;
            this.детальнийзаЗамовчуваннямToolStripMenuItem.Name = "детальнийзаЗамовчуваннямToolStripMenuItem";
            this.детальнийзаЗамовчуваннямToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.детальнийзаЗамовчуваннямToolStripMenuItem.Text = "Детальний (за замовчуванням)";
            this.детальнийзаЗамовчуваннямToolStripMenuItem.Click += new System.EventHandler(this.детальнийзаЗамовчуваннямToolStripMenuItem_Click);
            // 
            // зіToolStripMenuItem
            // 
            this.зіToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("зіToolStripMenuItem.Image")));
            this.зіToolStripMenuItem.Name = "зіToolStripMenuItem";
            this.зіToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.зіToolStripMenuItem.Text = "В рядок";
            this.зіToolStripMenuItem.Click += new System.EventHandler(this.зіToolStripMenuItem_Click);
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("списокToolStripMenuItem.Image")));
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // зменшеноToolStripMenuItem
            // 
            this.зменшеноToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("зменшеноToolStripMenuItem.Image")));
            this.зменшеноToolStripMenuItem.Name = "зменшеноToolStripMenuItem";
            this.зменшеноToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.зменшеноToolStripMenuItem.Text = "В стовпчик";
            this.зменшеноToolStripMenuItem.Click += new System.EventHandler(this.зменшеноToolStripMenuItem_Click);
            // 
            // плиткаToolStripMenuItem
            // 
            this.плиткаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("плиткаToolStripMenuItem.Image")));
            this.плиткаToolStripMenuItem.Name = "плиткаToolStripMenuItem";
            this.плиткаToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.плиткаToolStripMenuItem.Text = "Плитка";
            this.плиткаToolStripMenuItem.Click += new System.EventHandler(this.плиткаToolStripMenuItem_Click);
            // 
            // сортуватиСписокДокументівToolStripMenuItem
            // 
            this.сортуватиСписокДокументівToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заЗростаннямToolStripMenuItem,
            this.заСпаданнямToolStripMenuItem});
            this.сортуватиСписокДокументівToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.table_sort;
            this.сортуватиСписокДокументівToolStripMenuItem.Name = "сортуватиСписокДокументівToolStripMenuItem";
            this.сортуватиСписокДокументівToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.сортуватиСписокДокументівToolStripMenuItem.Text = "Сортувати список документів";
            // 
            // заЗростаннямToolStripMenuItem
            // 
            this.заЗростаннямToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заЗростаннямToolStripMenuItem.Image")));
            this.заЗростаннямToolStripMenuItem.Name = "заЗростаннямToolStripMenuItem";
            this.заЗростаннямToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.заЗростаннямToolStripMenuItem.Text = "За зростанням";
            this.заЗростаннямToolStripMenuItem.Click += new System.EventHandler(this.заЗростаннямToolStripMenuItem_Click);
            // 
            // заСпаданнямToolStripMenuItem
            // 
            this.заСпаданнямToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заСпаданнямToolStripMenuItem.Image")));
            this.заСпаданнямToolStripMenuItem.Name = "заСпаданнямToolStripMenuItem";
            this.заСпаданнямToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.заСпаданнямToolStripMenuItem.Text = "За спаданням";
            this.заСпаданнямToolStripMenuItem.Click += new System.EventHandler(this.заСпаданнямToolStripMenuItem_Click);
            // 
            // фіфвToolStripMenuItem
            // 
            this.фіфвToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.add;
            this.фіфвToolStripMenuItem.Name = "фіфвToolStripMenuItem";
            this.фіфвToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.фіфвToolStripMenuItem.Text = "Додати файл";
            this.фіфвToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // видалитиФайлToolStripMenuItem
            // 
            this.видалитиФайлToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.delete;
            this.видалитиФайлToolStripMenuItem.Name = "видалитиФайлToolStripMenuItem";
            this.видалитиФайлToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.видалитиФайлToolStripMenuItem.Text = "Видалити файл";
            this.видалитиФайлToolStripMenuItem.Click += new System.EventHandler(this.видалитиФайлToolStripMenuItem_Click);
            // 
            // відчинитиОсновнуДиректоріюToolStripMenuItem
            // 
            this.відчинитиОсновнуДиректоріюToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.arrow_right;
            this.відчинитиОсновнуДиректоріюToolStripMenuItem.Name = "відчинитиОсновнуДиректоріюToolStripMenuItem";
            this.відчинитиОсновнуДиректоріюToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.відчинитиОсновнуДиректоріюToolStripMenuItem.Text = "Відчинити основну директорію";
            this.відчинитиОсновнуДиректоріюToolStripMenuItem.Click += new System.EventHandler(this.відчинитиОсновнуДиректоріюToolStripMenuItem_Click);
            // 
            // проПрогамуToolStripMenuItem
            // 
            this.проПрогамуToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.information;
            this.проПрогамуToolStripMenuItem.Name = "проПрогамуToolStripMenuItem";
            this.проПрогамуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.проПрогамуToolStripMenuItem.Text = "Про прогаму";
            this.проПрогамуToolStripMenuItem.Click += new System.EventHandler(this.проПрогамуToolStripMenuItem_Click);
            // 
            // технічнаПідтримкаToolStripMenuItem
            // 
            this.технічнаПідтримкаToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.asterisk_orange;
            this.технічнаПідтримкаToolStripMenuItem.Name = "технічнаПідтримкаToolStripMenuItem";
            this.технічнаПідтримкаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.технічнаПідтримкаToolStripMenuItem.Text = "Технічна підтримка";
            this.технічнаПідтримкаToolStripMenuItem.Click += new System.EventHandler(this.технічнаПідтримкаToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Image = global::LawDocDB.Properties.Resources.user_suit;
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // надіслатиЛистаToolStripMenuItem
            // 
            this.надіслатиЛистаToolStripMenuItem.Name = "надіслатиЛистаToolStripMenuItem";
            this.надіслатиЛистаToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.надіслатиЛистаToolStripMenuItem.Text = "Надіслати листа";
            this.надіслатиЛистаToolStripMenuItem.Click += new System.EventHandler(this.надіслатиЛистаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер документів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виглядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виглядСпискуДокументівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem детальнийзаЗамовчуваннямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зменшеноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плиткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуватиСписокДокументівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заЗростаннямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заСпаданнямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрогамуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem технічнаПідтримкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem виконатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фіфвToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відчинитиОсновнуДиректоріюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відчинитиОсновнуДиректоріюToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxSearchText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem видалитиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem надіслатиЛистаToolStripMenuItem;
    }
}

