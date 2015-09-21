namespace My_Utilities
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNotePad = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuIteminsData = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuIteminsTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonPassCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPass = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxPass = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxRnd = new System.Windows.Forms.CheckBox();
            this.copyToBuf = new System.Windows.Forms.Button();
            this.rndClear = new System.Windows.Forms.Button();
            this.textBoxRnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.buttonSWAP = new System.Windows.Forms.Button();
            this.comboBoxMetric = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPass)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ToolStripMenuItemNotePad,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemNotePad
            // 
            this.ToolStripMenuItemNotePad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuIteminsData,
            this.ToolStripMenuIteminsTime,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemLoad});
            this.ToolStripMenuItemNotePad.Name = "ToolStripMenuItemNotePad";
            this.ToolStripMenuItemNotePad.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemNotePad.Text = "Блокнот";
            // 
            // ToolStripMenuIteminsData
            // 
            this.ToolStripMenuIteminsData.Name = "ToolStripMenuIteminsData";
            this.ToolStripMenuIteminsData.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.ToolStripMenuIteminsData.Size = new System.Drawing.Size(232, 22);
            this.ToolStripMenuIteminsData.Text = "Вставить дату";
            this.ToolStripMenuIteminsData.Click += new System.EventHandler(this.ToolStripMenuIteminsData_Click);
            // 
            // ToolStripMenuIteminsTime
            // 
            this.ToolStripMenuIteminsTime.Name = "ToolStripMenuIteminsTime";
            this.ToolStripMenuIteminsTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.ToolStripMenuIteminsTime.Size = new System.Drawing.Size(232, 22);
            this.ToolStripMenuIteminsTime.Text = "Вставить время";
            this.ToolStripMenuIteminsTime.Click += new System.EventHandler(this.ToolStripMenuIteminsTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(232, 22);
            this.ToolStripMenuItemSave.Text = "Сохранить";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemLoad
            // 
            this.ToolStripMenuItemLoad.Name = "ToolStripMenuItemLoad";
            this.ToolStripMenuItemLoad.Size = new System.Drawing.Size(232, 22);
            this.ToolStripMenuItemLoad.Text = "Загрузить";
            this.ToolStripMenuItemLoad.Click += new System.EventHandler(this.ToolStripMenuItemLoad_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 237);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxPass);
            this.tabPage4.Controls.Add(this.buttonPassCreate);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.numericUpDownPass);
            this.tabPage4.Controls.Add(this.checkedListBoxPass);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(276, 211);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пароли";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(8, 183);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(260, 20);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // buttonPassCreate
            // 
            this.buttonPassCreate.Location = new System.Drawing.Point(8, 154);
            this.buttonPassCreate.Name = "buttonPassCreate";
            this.buttonPassCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonPassCreate.TabIndex = 3;
            this.buttonPassCreate.Text = "Создать пароль";
            this.buttonPassCreate.UseVisualStyleBackColor = true;
            this.buttonPassCreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Длина пароля";
            // 
            // numericUpDownPass
            // 
            this.numericUpDownPass.Location = new System.Drawing.Point(3, 128);
            this.numericUpDownPass.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPass.Name = "numericUpDownPass";
            this.numericUpDownPass.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPass.TabIndex = 1;
            this.numericUpDownPass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkedListBoxPass
            // 
            this.checkedListBoxPass.CheckOnClick = true;
            this.checkedListBoxPass.FormattingEnabled = true;
            this.checkedListBoxPass.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: % : ? * ( ) & № # ` ~ \'"});
            this.checkedListBoxPass.Location = new System.Drawing.Point(8, 3);
            this.checkedListBoxPass.Name = "checkedListBoxPass";
            this.checkedListBoxPass.Size = new System.Drawing.Size(260, 109);
            this.checkedListBoxPass.TabIndex = 0;
            this.checkedListBoxPass.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPass_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(276, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блокнот";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxNotepad
            // 
            this.richTextBoxNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNotepad.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxNotepad.Name = "richTextBoxNotepad";
            this.richTextBoxNotepad.Size = new System.Drawing.Size(276, 211);
            this.richTextBoxNotepad.TabIndex = 0;
            this.richTextBoxNotepad.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxRnd);
            this.tabPage2.Controls.Add(this.copyToBuf);
            this.tabPage2.Controls.Add(this.rndClear);
            this.tabPage2.Controls.Add(this.textBoxRnd);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxRnd
            // 
            this.checkBoxRnd.AutoSize = true;
            this.checkBoxRnd.Location = new System.Drawing.Point(8, 92);
            this.checkBoxRnd.Name = "checkBoxRnd";
            this.checkBoxRnd.Size = new System.Drawing.Size(107, 17);
            this.checkBoxRnd.TabIndex = 9;
            this.checkBoxRnd.Text = "Без повторений";
            this.checkBoxRnd.UseVisualStyleBackColor = true;
            // 
            // copyToBuf
            // 
            this.copyToBuf.Location = new System.Drawing.Point(6, 159);
            this.copyToBuf.Name = "copyToBuf";
            this.copyToBuf.Size = new System.Drawing.Size(132, 23);
            this.copyToBuf.TabIndex = 8;
            this.copyToBuf.Text = "Копировать в буфер";
            this.copyToBuf.UseVisualStyleBackColor = true;
            this.copyToBuf.Click += new System.EventHandler(this.copyToBuf_Click);
            // 
            // rndClear
            // 
            this.rndClear.Location = new System.Drawing.Point(6, 115);
            this.rndClear.Name = "rndClear";
            this.rndClear.Size = new System.Drawing.Size(75, 23);
            this.rndClear.TabIndex = 7;
            this.rndClear.Text = "Очистить";
            this.rndClear.UseVisualStyleBackColor = true;
            this.rndClear.Click += new System.EventHandler(this.rndClear_Click);
            // 
            // textBoxRnd
            // 
            this.textBoxRnd.Location = new System.Drawing.Point(149, 101);
            this.textBoxRnd.Multiline = true;
            this.textBoxRnd.Name = "textBoxRnd";
            this.textBoxRnd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRnd.Size = new System.Drawing.Size(105, 102);
            this.textBoxRnd.TabIndex = 6;
            this.textBoxRnd.TextChanged += new System.EventHandler(this.textBoxRnd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "От";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(63, 61);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(63, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Случайность";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Задать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelCount);
            this.tabPage1.Controls.Add(this.buttonplus);
            this.tabPage1.Controls.Add(this.buttonminus);
            this.tabPage1.Controls.Add(this.buttonreset);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счётчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(70, 81);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "0";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.Location = new System.Drawing.Point(39, 6);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(75, 48);
            this.buttonplus.TabIndex = 2;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Location = new System.Drawing.Point(140, 63);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(75, 48);
            this.buttonminus.TabIndex = 1;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(39, 134);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(75, 48);
            this.buttonreset.TabIndex = 0;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = true;
            this.buttonreset.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBoxMetric);
            this.tabPage5.Controls.Add(this.buttonSWAP);
            this.tabPage5.Controls.Add(this.textBoxIn);
            this.tabPage5.Controls.Add(this.textBoxOut);
            this.tabPage5.Controls.Add(this.buttonConvert);
            this.tabPage5.Controls.Add(this.comboBoxTo);
            this.tabPage5.Controls.Add(this.comboBoxFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(325, 211);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конвертер";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "мили"});
            this.comboBoxFrom.Location = new System.Drawing.Point(3, 119);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFrom.TabIndex = 0;
            this.comboBoxFrom.Text = "мм";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "мили"});
            this.comboBoxTo.Location = new System.Drawing.Point(230, 119);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTo.TabIndex = 1;
            this.comboBoxTo.Text = "мм";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(109, 146);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(115, 20);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Конвертировать";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(230, 146);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(92, 20);
            this.textBoxOut.TabIndex = 3;
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(3, 146);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(100, 20);
            this.textBoxIn.TabIndex = 4;
            this.textBoxIn.Text = "1";
            // 
            // buttonSWAP
            // 
            this.buttonSWAP.Location = new System.Drawing.Point(109, 117);
            this.buttonSWAP.Name = "buttonSWAP";
            this.buttonSWAP.Size = new System.Drawing.Size(115, 23);
            this.buttonSWAP.TabIndex = 5;
            this.buttonSWAP.Text = "<->";
            this.buttonSWAP.UseVisualStyleBackColor = true;
            this.buttonSWAP.Click += new System.EventHandler(this.buttonSWAP_Click);
            // 
            // comboBoxMetric
            // 
            this.comboBoxMetric.FormattingEnabled = true;
            this.comboBoxMetric.Items.AddRange(new object[] {
            "Длина",
            "Вес"});
            this.comboBoxMetric.Location = new System.Drawing.Point(109, 90);
            this.comboBoxMetric.Name = "comboBoxMetric";
            this.comboBoxMetric.Size = new System.Drawing.Size(115, 21);
            this.comboBoxMetric.TabIndex = 6;
            this.comboBoxMetric.Text = "Длина";
            this.comboBoxMetric.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetric_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPass)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBoxRnd;
        private System.Windows.Forms.Button rndClear;
        private System.Windows.Forms.Button copyToBuf;
        private System.Windows.Forms.CheckBox checkBoxRnd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNotePad;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuIteminsData;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuIteminsTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBoxNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoad;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonPassCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPass;
        private System.Windows.Forms.CheckedListBox checkedListBoxPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Button buttonSWAP;
        private System.Windows.Forms.ComboBox comboBoxMetric;
    }
}

