using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoMascota
{
    internal class clsMascota
    {
        //nombre, la edad y el tipo de animal. Luego, crear métodos para alimentar, jugar y cuidar a la mascota.
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Tipo { get; set; }
        public PictureBox picMascota { get; set; }
        
        public static void Alimentar(PictureBox pictureBox, string Tipo, ProgressBar necesidad)
        {
            if (Tipo == "Perro")
            {
                pictureBox.ImageLocation = "perro_comiendo.gif";
            }
            else if (Tipo == "Gato")
            {
                pictureBox.ImageLocation = "gato_comer.gif";
            }
            if (necesidad.Value + 10 > 100)
            {
                necesidad.Value = 100;
            }
            else
            {
                necesidad.Value = necesidad.Value + 10;
            }
        }
        public static void Jugar(PictureBox pictureBox, string Tipo, ProgressBar necesidad)
        {
            if (Tipo == "Perro")
            {
                pictureBox.ImageLocation = "perro_jugando.gif";
            }
            else if (Tipo == "Gato")
            {
                pictureBox.ImageLocation = "gato_jugar.gif";
            }
            if (necesidad.Value + 10 > 100)
            {
                necesidad.Value = 100;
            }
            else
            {
                necesidad.Value = necesidad.Value + 10;
            }
        }
        public static void Cuidar(PictureBox pictureBox, string Tipo, ProgressBar necesidad)
        {
            if (Tipo == "Perro")
            {
                pictureBox.ImageLocation = "perro_cuidado.gif";
            }
            else if (Tipo == "Gato")
            {
                pictureBox.ImageLocation = "gato_cuidar.gif";
            }
            if (necesidad.Value + 10 > 100)
            {
                necesidad.Value = 100;
            }
            else
            {
                necesidad.Value = necesidad.Value + 10;
            }
        }
    }
}
