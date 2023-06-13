using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace correcao
{
    public partial class Avaliacao : Form
    {
        public Avaliacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            string[] gabarito = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B"};

            int contador = 0;
            
            if (gabarito[0] == textBox1.Text )
            {
                contador++;
            }
            if (gabarito[1] == textBox2.Text)
            {
                contador++;
            }
            if (gabarito[2] == textBox3.Text)
            {
                contador++;
            }
            if (gabarito[3] == textBox4.Text)
            {
                contador++;
            }
            if (gabarito[4] == textBox5.Text)
            {
                contador++;
            }
            if (gabarito[5] == textBox6.Text)
            {
                contador++;
            }
            if (gabarito[6] == textBox7.Text)
            {
                contador++;
            }
            if (gabarito[7] == textBox8.Text)
            {
                contador++;
            }
            if (gabarito[8] == textBox9.Text)
            {
                contador++;
            }
            if (gabarito[9] == textBox10.Text)
            {
                contador++;
            }

            lb_resultado.Text = "Resultado: " + contador.ToString() + " acertos.";

        }
    }
}
