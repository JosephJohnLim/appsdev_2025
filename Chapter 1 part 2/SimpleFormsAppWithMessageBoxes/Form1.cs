namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string middleName = textBox2.Text;
            string lastName = textBox3.Text;
            string suffix = textBox4.Text;

            string fullName = firstName;

            if (!string.IsNullOrEmpty(middleName))
            {
                fullName += " " + middleName;
            }
            fullName += " " + lastName;

            if (!string.IsNullOrEmpty(suffix))
            {
                fullName += " " + suffix;
            }

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Hello There!\n" + fullName, "Greetings");
            }
        }
    }
}
