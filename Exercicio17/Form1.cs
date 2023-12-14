using System.Diagnostics.Eventing.Reader;

namespace Exercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Foi registado com sucesso");
            }
            else
            {
                Utilizador.Nome = textBox1.Text;
                Utilizador.Email = textBox2.Text;
                Utilizador.Password = textBox3.Text;

                MessageBox.Show("Foi Registado com Sucesso");
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}