using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Methods_of_possible_directions_for_Zoytendijk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Выбираем количество ограничений - первый элемент в списке значений комбобокса (1 ограничение)
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = 0;
            foreach (Control item in Controls)
            {
                foreach (Control item2 in Controls)
                {
                    //MessageBox.Show(item.Name, (j++).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (item2.Name.Contains("ID"))
                    {
                        //MessageBox.Show(item2.Name, "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controls.Remove(item2);
                    }
                }
                    //Controls.Remove(item);
            }

            // В случае изменения ограничений, выбираем индекс выбранного элемента
            for (int i = 0; i <= comboBox1.SelectedIndex; i++)
            {
                // Создание подписей и текстбоксов к ним по ограничениям
                TextBox dynamicTextBox = new TextBox();
                TextBox dynamicTextBox2 = new TextBox();
                Label dynamicLabel = new Label();
                ComboBox dynamicCombobox = new ComboBox();

                // Присваивание ID
                dynamicTextBox.Name = "ID" + i;
                dynamicTextBox2.Name = "ID" + i;
                dynamicLabel.Name = "ID" + i;
                dynamicCombobox.Name = "ID" + i;

                // Текст на них
                dynamicTextBox.Text = "Hello " + i;
                dynamicTextBox2.Text = "0";
                dynamicLabel.Text = "g" + (i + 1) + "(x):";

                // Добавление в каждый комбобокс вариантов на выбор условия ограничения
                dynamicCombobox.Items.Add("≥");
                dynamicCombobox.Items.Add("=");
                dynamicCombobox.Items.Add("≤");

                // Расположение на экране
                dynamicTextBox.Location = new Point(70, 55 + i * 27 + 1);
                dynamicTextBox2.Location = new Point(215, 55 + i * 27 + 1);
                dynamicLabel.Location = new Point(15, 60 + i * 27 + 1);
                dynamicCombobox.Location = new Point(175, 55 + i * 27 + 1);

                // Выбор размера текст- и комбобоксов
                dynamicTextBox.Size = new Size(100, 20);
                dynamicTextBox2.Size = new Size(50, 20);
                dynamicCombobox.Size = new Size(35, 20);
                // Автосайз для лейблов (без него лейблы находят на текстбоксы)
                dynamicLabel.AutoSize = true;

                // Выбор первого элемента
                dynamicCombobox.SelectedIndex = 0;

                // Добавить лейбл и текстбокс для него
                Controls.Add(dynamicTextBox);
                Controls.Add(dynamicTextBox2);
                Controls.Add(dynamicLabel);
                Controls.Add(dynamicCombobox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все переменные выражаются через x1, x2. Все математические операции выражаются через общепринятые символы +, -, *, /, ^. Корень квадратный √¯ ≡ sqrt, степень корня ≡ x ^ (2 / 3), (x - 1) ^ (1 / 3). Число π ≡ pi, число e ≡ exp(1), ∞ ≡ infinity. e^x = exp(x), log5(x) ≡ log(x, 5). Тригонометрические функции: cos(x), sin(x), tg(x), ctg(x), arccos(x), arcsin(x), arctg(x), arcctg(x)", "Правила ввода функции", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
