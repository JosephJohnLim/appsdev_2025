namespace SimpleIphone
{
    public partial class Form1 : Form
    {
        string[] iPhoneModels = { "iPhone 16 Pro Max (256GB)", "iPhone 16 Pro (128GB)", "iPhone 15 plus (128GB)", "iPhone 16 (128GB)", "iPhone 16e (128GB)" };
        double[] iPhonePrices = { 70000, 64990, 54990, 52990, 48990 };

        double appleCarePrice = 2500;
        double usbChargerPrice = 1990;
        double magSafePrice = 2490;
        public Form1()
        {
            InitializeComponent();
            string[] iPhoneModels = { "iPhone 16 Pro Max (256GB)", "iPhone 16 Pro (128GB)", "iPhone 15 plus (128GB)", "iPhone 16 (128GB)", "iPhone 16e (128GB)" };
            comboBox1.Items.AddRange(iPhoneModels);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
