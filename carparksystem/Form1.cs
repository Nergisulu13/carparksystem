namespace carparksystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carparkclass.yetkigiris x = new carparkclass.yetkigiris(textBox1.Text, textBox2.Text);
            if (x.YetkiliGirisKontrol(textBox1.Text, textBox2.Text))
            {
                Form2 YetkiliGiris = new Form2();
                YetkiliGiris.Show();
            }
            else
                MessageBox.Show("Yanl�� kullan�c� ad� veya �ifre girdiniz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carparkclass.admingiris x = new carparkclass.admingiris(textBox3.Text, textBox4.Text);
            if (x.AdminGirisKontrol(textBox3.Text, textBox4.Text))
            {
                Form3 AdminGiris = new Form3();
                AdminGiris.Show();
            }
            else
                MessageBox.Show("Yanl�� kullan�c� ad� veya �ifre girdiniz.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            carparkclass.kullan�c�giris x = new carparkclass.kullan�c�giris(textBox5.Text, textBox6.Text);
            if (x.KullaniciGirisKontrol(textBox5.Text, textBox6.Text))
            {
                Form4 KullaniciGiris = new Form4();
                KullaniciGiris.Show();
            }
            else
                MessageBox.Show("Yanl�� kullan�c� ad� veya �ifre girdiniz.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carparkclass.kullan�c�uyeol x = new carparkclass.kullan�c�uyeol(textBox9.Text, textBox10.Text);
            Form4 KullaniciGiris = new Form4();
            KullaniciGiris.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}