using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Utilities
{
    public partial class MainForm : Form
    {

        int count = 0;
        Random rnd;
        char[] spec_chars = new char[] {'%', ':', '?', '*', '(', ')', '&', '№', '#', '`', '~'};
        Dictionary<string, double> metrica;

        public MainForm()
        {
            InitializeComponent();
            metrica = new Dictionary<string, double>();
            metrica.Add("мм", 1);
            metrica.Add("см", 10);
            metrica.Add("дм", 100);
            metrica.Add("м", 1000);
            metrica.Add("км", 1000000);
            metrica.Add("мили", 1609344);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Мои утилиты' содержит ряд небольших программ, которые могут пригоиться в жизни,\n а главное - научит меня программированию на С#. Автор - GenGod.", "О программе.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            labelCount.Text = count.ToString();
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            labelCount.Text = count--.ToString();
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            labelCount.Text = count++.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rnd = new Random();
            String str;
            str = Convert.ToString(rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)));
            label1.Text = str + "\n";
            if (checkBoxRnd.Checked)
            {
                int y = 0;
                while (textBoxRnd.Text.IndexOf(str) != -1)
                {
                    str = Convert.ToString(rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)));
                    y++;
                    if (y > (Convert.ToInt32(numericUpDown2.Value) - Convert.ToInt32(numericUpDown1.Value)))
                        break;
                }
                if (y <= (Convert.ToInt32(numericUpDown2.Value) - Convert.ToInt32(numericUpDown1.Value)))
                {
                    label1.Text = str + "\n";
                    textBoxRnd.AppendText(label1.Text);
                }
            }
            else textBoxRnd.AppendText(label1.Text);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void rndClear_Click(object sender, EventArgs e)
        {
            textBoxRnd.Clear();
        }

        private void copyToBuf_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxRnd.Text);
        }

        private void ToolStripMenuIteminsData_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void ToolStripMenuIteminsTime_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            try {
                richTextBoxNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка!", "Ошибка при сохранении файла!");
            }
        }

        private void loadNotepad()
        {
            try
            {
                richTextBoxNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка!", "Ошибкапри загрузке файла!");
            }
        }

        private void ToolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            loadNotepad();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadNotepad();
            checkedListBoxPass.SetItemChecked(0, true);
            checkedListBoxPass.SetItemChecked(1, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            if (checkedListBoxPass.CheckedItems.Count == 0) return;
            else
            {
                string password = "";
                for (int i = 0; i < numericUpDownPass.Value; i++)
                {
                    int n = rnd.Next(0, checkedListBoxPass.CheckedItems.Count);
                    string s = checkedListBoxPass.CheckedItems[n].ToString();
                    switch (s)
                    {
                        case "Цифры":
                            password += rnd.Next(10).ToString();
                            break;
                        case "Прописные буквы":
                            password += Convert.ToChar(rnd.Next(65, 88));
                            break;
                        case "Строчные буквы":
                            password += Convert.ToChar(rnd.Next(97, 122));
                            break;
                        default:
                            password += spec_chars[Convert.ToInt32(rnd.Next(spec_chars.Length))];
                            break;
                    }
                    textBoxPass.Text = password;
                    Clipboard.SetText(password);
                }
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxPass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[comboBoxFrom.Text];
            double m2 = metrica[comboBoxTo.Text];
            double n = Convert.ToDouble(textBoxIn.Text);
            textBoxOut.Text = (n * m1 / m2).ToString();

        }

        private void buttonSWAP_Click(object sender, EventArgs e)
        {
            string t = comboBoxFrom.Text;
            comboBoxFrom.Text = comboBoxFrom.Text;
            comboBoxTo.Text = t;
        }

        private void comboBoxMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMetric.Text)
            {
                case "Длина":
                    metrica.Clear();
                    metrica.Add("мм", 1);
                    metrica.Add("см", 10);
                    metrica.Add("дм", 100);
                    metrica.Add("м", 1000);
                    metrica.Add("км", 1000000);
                    metrica.Add("мили", 1609344);
                    comboBoxFrom.Items.Clear();
                    comboBoxTo.Items.Clear();
                    comboBoxFrom.Items.Add("мм");
                    comboBoxFrom.Items.Add("см");
                    comboBoxFrom.Items.Add("дм");
                    comboBoxFrom.Items.Add("м");
                    comboBoxFrom.Items.Add("км");
                    comboBoxFrom.Items.Add("мили");
                    comboBoxTo.Items.Add("мм");
                    comboBoxTo.Items.Add("см");
                    comboBoxTo.Items.Add("дм");
                    comboBoxTo.Items.Add("м");
                    comboBoxTo.Items.Add("км");
                    comboBoxTo.Items.Add("мили");
                    comboBoxFrom.Text = "мм";
                    comboBoxTo.Text = "мм";
                    break;
                case "Вес":
                    metrica.Clear();
                    metrica.Add("г", 1);
                    metrica.Add("кг", 1000);
                    metrica.Add("т", 1000000);
                    metrica.Add("фунты", 453.6);
                    metrica.Add("унции", 28.35);
                    comboBoxFrom.Items.Clear();
                    comboBoxTo.Items.Clear();
                    comboBoxFrom.Items.Add("г");
                    comboBoxFrom.Items.Add("кг");
                    comboBoxFrom.Items.Add("т");
                    comboBoxFrom.Items.Add("фунты");
                    comboBoxFrom.Items.Add("унции");
                    comboBoxTo.Items.Add("г");
                    comboBoxTo.Items.Add("кг");
                    comboBoxTo.Items.Add("т");
                    comboBoxTo.Items.Add("фунты");
                    comboBoxTo.Items.Add("унции");
                    comboBoxFrom.Text = "г";
                    comboBoxTo.Text = "г";
                    break;
                default:
                    break;
            }
        }
    }
}
