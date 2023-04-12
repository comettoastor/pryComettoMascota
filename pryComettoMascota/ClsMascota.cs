using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoMascota
{
    internal class ClsMascota
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
                pictureBox.Image = Properties.Resources.perro_comiendo;
            }
            else if (Tipo == "Gato")
            {
                pictureBox.Image = Properties.Resources.gato_comer;
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
                pictureBox.Image = Properties.Resources.perro_jugando;
            }
            else if (Tipo == "Gato")
            {
                pictureBox.Image = Properties.Resources.gato_jugar;
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
                pictureBox.Image = Properties.Resources.perro_cuidado;
            }
            else if (Tipo == "Gato")
            {
                pictureBox.Image = Properties.Resources.gato_cuidar;
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
