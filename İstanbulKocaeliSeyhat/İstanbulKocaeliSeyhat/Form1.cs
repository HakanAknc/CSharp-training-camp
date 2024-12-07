namespace İstanbulKocaeliSeyhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yönetici" && textBox2.Text == "1234")
            {
                Form3 seyhat = new Form3();
                seyhat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş Yaptınız Tekrar Deneyin!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}