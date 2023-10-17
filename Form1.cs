using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Visualizador_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Mostra a caixa de diálogo Abrir arquivo. Se o usuário clicar em OK, carregue o
            //imagem que o usuário escolheu.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Limpar a immagem
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Mostra a caixa de diálogo de cores. Se o usuário clicar em OK, altere o
            // Fundo do controle PictureBox na cor escolhida pelo usuário.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Fecha o form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o usuário marcar a caixa de seleção Stretch,
            // altera o PictureBox
            // Propriedade SizeMode para "Stretch". Se o usuário limpar
            // a caixa de seleção, altere-a para "Normal".
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
