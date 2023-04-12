using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoMascota
{
    public partial class frmPrincipal : Form
    {
        List<ClsMascota> lstMascotas = new List<ClsMascota>();
        int indice;

        public void Limpiar()
        {
            txtNombre.Text = "";
            cmbTipo.SelectedIndex = -1;
            nudEdad.Value = 0;
            lblNombre.Text = "";
            lblEdad.Text = "";
            picAccion.Image = null;
            prbAlimentar.Value = 100;
            prbJugar.Value = 100;
            prbCuidar.Value = 100;
            mrcAcciones.Enabled = false;
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            lstMascotasForm.Items.Clear();

            ClsMascota clsMascota = new ClsMascota();
            clsMascota.Nombre = txtNombre.Text;
            clsMascota.Tipo = cmbTipo.Text;
            clsMascota.Edad = nudEdad.Value.ToString();

            clsMascota.picMascota = new PictureBox();
            clsMascota.picMascota.Size = new Size(300,300);
            clsMascota.picMascota.SizeMode = PictureBoxSizeMode.StretchImage;
            clsMascota.picMascota.Location = new Point(12,12);

            lstMascotas.Add(clsMascota);

            foreach (ClsMascota mascota in lstMascotas)
            {
                lstMascotasForm.Items.Add(mascota.Nombre + " | " + mascota.Tipo + " | " + mascota.Edad);
            }            
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            ClsMascota.Alimentar(lstMascotas[indice].picMascota, lstMascotas[indice].Tipo, prbAlimentar);
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            ClsMascota.Jugar(picAccion, lstMascotas[indice].Tipo, prbJugar);
        }

        private void btnCuidar_Click(object sender, EventArgs e)
        {
            ClsMascota.Cuidar(picAccion, lstMascotas[indice].Tipo, prbCuidar);
        }

        private void tmrNecesidades_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int valor_random = random.Next(1, 5);
            if (prbAlimentar.Value - valor_random < 0)
            {
                prbAlimentar.Value = 0;
                tmrNecesidades.Enabled = false;
                tmrNecesidades.Dispose();
                MessageBox.Show("Perdiste!");
                Limpiar();
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
                Limpiar();
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
                Limpiar();
            }
            else
            {
                prbCuidar.Value = prbCuidar.Value - valor_random;
            }
        }

        private void lstMascotasForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = lstMascotasForm.SelectedIndex;

            if (lstMascotas[indice].Tipo == "Perro")
            {
                picAccion.Image = Properties.Resources.perro_imagen;
            }
            else if (lstMascotas[indice].Tipo == "Gato")
            {
                picAccion.Image = Properties.Resources.gato_imagen;
            }

            lblNombre.Text = lstMascotas[indice].Nombre;
            lblEdad.Text = lstMascotas[indice].Edad;
            lblNombre.Visible = true;
            lblEdad.Visible = true;

            mrcAcciones.Enabled = true;

            prbAlimentar.Value = 100;
            prbJugar.Value = 100;
            prbCuidar.Value = 100;

            tmrNecesidades.Enabled = true;
        }
    }
}
