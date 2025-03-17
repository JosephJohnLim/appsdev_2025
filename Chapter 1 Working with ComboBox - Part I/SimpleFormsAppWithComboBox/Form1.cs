namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foodCuisine = { "Japanese", "Filipino", "Italian", "Korean"};
            comboBox1.Items.AddRange(foodCuisine);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] JapaneseFood = { "Onigiri", "Tofu", "Udon" };
            string[] FilipinoFood = { "Menudo", "Tinola", "Adobo" };
            string[] ItalianFood = { "Lasagna", "Tiramisu", "Pizza Margherita" };
            string[] KoreanFood = { "Kimchi", "Bibimbap", "Tteok" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(JapaneseFood);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(FilipinoFood);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Italian"))
            {
                checkedListBox1.Items.AddRange(ItalianFood);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox1.Items.AddRange(KoreanFood);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
