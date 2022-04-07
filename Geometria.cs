using System;
using System.Drawing;
using System.Windows.Forms;

namespace ED_1
{
    class Geometria
    {
        //campo
        Color color;
        static Random rnd = new Random();
        Rectangle rectangle;
        //propiedad


        //Metodo para obtemer la locacion del Form
        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public Point LocacionForm(Form form)
        {
            return form.Location;
        }
        /// <summary>
        /// Método para sumar dos números enteros. 
        /// </summary>
        /// <param name="x">Primer número entero a sumar.</param>
        /// <param name="y"> Segundo número entero a sumar.  </param>
        /// <returns>Un número entero</returns>
        public int Sumar(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Método para asignar al Formulario, el color de ncimiento del objeto.
        /// </summary>
        /// <param name="f">Form que adquirira el color del objeto.</param>
        public void CargaElColorDelObjeto(Form f) {
            f.BackColor = color;
        }       
        public void Dibujo(Graphics graphics,int puntoEnX, int puntoEnY) {           

            Color colorRandomizado = RandomColor();

            using (Brush brush = new SolidBrush(Color.FromArgb(100,RandomColor()))) {
                graphics.FillRectangle(brush, new Rectangle(puntoEnX,puntoEnY,50,50));               
            }
        }
        
        public static Color RandomColor() {
            return Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        //Miembro de tipo constructor
        /// <summary>
        /// Inicializador del objeto.
        /// </summary>
        /// <param name="color">Carga un Color.</param>
        public Geometria(Color color) {
            this.color = color;
        }

        public void REfresh(Form form) {
            form.Refresh();
        }

        public bool Probar(Point location) {
            return rectangle.Contains(location);
        }

    }
}
