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
                MessageBox.Show("Falta de informa��es.");
            }
            else
            {
                Utilizador.Nome = textBox1.Text;
                Utilizador.Email = textBox2.Text;
                Utilizador.Password = textBox3.Text;

                MessageBox.Show("Foi Registado com Sucesso.");
                button2.Visible = true;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
            }
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
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
    }
}