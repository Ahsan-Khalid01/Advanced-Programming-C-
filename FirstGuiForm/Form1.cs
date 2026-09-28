namespace FirstGuiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(username1.Text) && !string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Login SuccessFull");
            }
            else {
                MessageBox.Show("UserName or Password is Empty");

            }

        }
    }
}
