using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTiposAlertas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sou uma mensagem super simples 😄 ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sou um alerta com título", "Sou o Título");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Vamos estudar C#?", "Bora?", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Legal!!! Bora Estudar!", "Eba!!!!");
            }
            else if (retorno == DialogResult.No)
                MessageBox.Show(" :( ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show(
                "Segue o @prof.tiagotas?",
                "Serei o Título",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ouviu o Som do Windows?",
                "Deu algo Errado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
