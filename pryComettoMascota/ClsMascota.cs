using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        
        public int Crear(TextBox txtNombre, ComboBox cmbTipo, NumericUpDown nudEdad, ListBox lstMascotasForm, GroupBox mrcAcciones)
        {
            if (txtNombre.Text != "" && cmbTipo.SelectedIndex != -1 && nudEdad.Text != "")
            {
                Nombre = txtNombre.Text;
                Tipo = cmbTipo.Text;
                Edad = nudEdad.Value.ToString();

                picMascota = new PictureBox();
                picMascota.Size = new Size(300, 300);
                picMascota.SizeMode = PictureBoxSizeMode.StretchImage;
                picMascota.Location = new Point(12, 12);

                mrcAcciones.Enabled = true;

                return 1;
            }
            else
            {
                MessageBox.Show("Error - Faltan datos por completar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void Alimentar(ProgressBar necesidad)
        {
            if (Tipo == "Perro")
            {
                picMascota.ImageLocation = "perro_comiendo.gif";
            }
            else if (Tipo == "Gato")
            {
                picMascota.ImageLocation = "gato_comer.gif";
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

        public void Jugar(ProgressBar necesidad)
        {
            if (Tipo == "Perro")
            {
                picMascota.ImageLocation = "perro_jugando.gif";
            }
            else if (Tipo == "Gato")
            {
                picMascota.ImageLocation = "gato_jugar.gif";
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

        public void Cuidar(ProgressBar necesidad)
        {
            if (Tipo == "Perro")
            {
                picMascota.ImageLocation = "perro_cuidado.gif";
            }
            else if (Tipo == "Gato")
            {
                picMascota.ImageLocation = "gato_cuidar.gif";
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

        public static int Necesidades(ProgressBar prbAlimentar, ProgressBar prbJugar, ProgressBar prbCuidar, Timer tmrNecesidades)
        {
            Random random = new Random();
            int valor_random = random.Next(1, 5);
            if (prbAlimentar.Value - valor_random < 0)
            {
                prbAlimentar.Value = 0;
                tmrNecesidades.Enabled = false;
                tmrNecesidades.Dispose();
                MessageBox.Show("Perdiste!");
                return 1;
            }
            else
            {
                prbAlimentar.Value = prbAlimentar.Value - valor_random;
            }
            valor_random = random.Next(1, 5);
            if (prbJugar.Value - valor_random < 0)
            {
                prbJugar.Value = 0;
                tmrNecesidades.Enabled = false;
                tmrNecesidades.Dispose();
                MessageBox.Show("Perdiste!");
                return 1;
            }
            else
            {
                prbJugar.Value = prbJugar.Value - valor_random;
            }
            valor_random = random.Next(1, 5);
            if (prbCuidar.Value - valor_random < 0)
            {
                prbCuidar.Value = 0;
                tmrNecesidades.Enabled = false;
                tmrNecesidades.Dispose();
                MessageBox.Show("Perdiste!");
                return 1;
            }
            else
            {
                prbCuidar.Value = prbCuidar.Value - valor_random;
            }
            return 0;
        }

        public void Cambio(int indice, ListBox lstMascotasForm, Button btnEliminar, Label lblNombre, Label lblEdad, GroupBox mrcAcciones, ProgressBar prbAlimentar, ProgressBar prbJugar, ProgressBar prbCuidar, Timer tmrNecesidades)
        {
            btnEliminar.Enabled = true;
            if (Tipo == "Perro")
            {
                picMascota.ImageLocation = "perro_imagen.jpg";
                picMascota.BringToFront();
            }
            else if (Tipo == "Gato")
            {
                picMascota.ImageLocation = "gato_imagen.gif";
                picMascota.BringToFront();
            }

            lblNombre.Text = Nombre;
            lblEdad.Text = Edad;
            lblNombre.Visible = true;
            lblEdad.Visible = true;
            lblNombre.BringToFront();
            lblEdad.BringToFront();

            mrcAcciones.Enabled = true;

            prbAlimentar.Value = 100;
            prbJugar.Value = 100;
            prbCuidar.Value = 100;

            tmrNecesidades.Enabled = true;
        }
    }
}
