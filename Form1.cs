using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_1
{
    public partial class Form1 : Form
    {
        Geometria objetoGeoemtria1 = new Geometria(Color.FromArgb(23, 176, 241));
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //Madar llamar el metodo (sumar), mediante un objeto
            Geometria objetoGeoemtria = new Geometria(Color.Fuchsia);
            objetoGeoemtria.CargaElColorDelObjeto(this);
            lblREsultado.Text = objetoGeoemtria.Sumar(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();                                            
        }

        private void btnSumar2_Click(object sender, EventArgs e)
        {
            
            objetoGeoemtria1.CargaElColorDelObjeto(this);
            lblREsultado.Text = objetoGeoemtria1.Sumar(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
        }

        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Llmar mi objeto de clase Geometria
            Graphics g = CreateGraphics();
            objetoGeoemtria1.Dibujo(g, e.X, e.Y);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            objetoGeoemtria1.REfresh(this);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (objetoGeoemtria1.Probar(e.Location))
            {
                MessageBox.Show("sobre un rectangulo");
            }
        }
    }
}
