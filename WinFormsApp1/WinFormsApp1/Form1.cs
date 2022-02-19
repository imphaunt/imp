namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2;
            if (textBox1.Text != "")
                f2 = new Form2(textBox1.Text);
            else
                f2 = new Form2();
            f2.ShowDialog();
            label1.Text = f2.name;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}