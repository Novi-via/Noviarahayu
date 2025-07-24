namespace knkn 
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

        //ketika tombol Add diklik, menambahkan tugas ke listbox
        private void button5_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.ToString(); //memasukkan nama tugas
            string todaytask = textBox10.Text.ToString(); //memasukkan nama tugas yang urgent
            string reminder = textBox3.Text.ToString(); //memasukkan tanggal

            //jika checkbox dicentang, maka tugas masuk di due today listbox
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(task); //untuk menambahkan tugas
                listBox1.Items.Add(todaytask);
            }
            //jika checkbox tidak dicentang, maka tugas masuk ke reminder listbox
            else
            {
                listBox2.Items.Add(task);
                listBox2.Items.Add(reminder);
            }

            //untuk membersihkan semua isi textbox 
            textBox1.Clear();
            textBox1.Focus();

            textBox10.Clear();
            textBox10.Focus();

            textBox3.Clear();
            textBox3.Focus();
        }

        //ketika tombol Clear diklik, menghapus isi semua textbox dan listbox
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
