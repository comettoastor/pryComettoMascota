using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryComettoMascota
{
    public partial class frmPrincipal : Form
    {
        List<clsMascota> lstMascotas = new List<clsMascota>();
        int indice;

        public void Limpiar()
        {
            txtNombre.Text = "";
            cmbTipo.SelectedIndex = -1;
            nudEdad.Value = 0;
            lblNombre.Text = "";
            lblEdad.Text = "";
            prbAlimentar.Value = 100;
            prbJugar.Value = 100;
            prbCuidar.Value = 100;
            mrcAcciones.Enabled = false;
            tmrNecesidades.Enabled = false;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            clsMascota objMascota = new clsMascota();
            if (objMascota.Crear(txtNombre, cmbTipo, nudEdad, lstMascotasForm, mrcAcciones) == 1)
            {
                lstMascotas.Add(objMascota);
                this.Controls.Add(objMascota.picMascota);
                lstMascotasForm.Items.Clear();
                foreach (clsMascota mascota in lstMascotas)
                {
                    lstMascotasForm.Items.Add(mascota.Nombre + " | " + mascota.Tipo + " | " + mascota.Edad);
                }
            }
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            lstMascotas[indice].Alimentar(prbAlimentar);
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            lstMascotas[indice].Jugar(prbJugar);
        }

        private void btnCuidar_Click(object sender, EventArgs e)
        {
            lstMascotas[indice].Cuidar(prbCuidar);
        }

        private void tmrNecesidades_Tick(object sender, EventArgs e)
        {
            if (clsMascota.Necesidades(prbAlimentar, prbJugar, prbCuidar, tmrNecesidades) == 1)
            {
                Limpiar();
            }
        }

        private void lstMascotasForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = lstMascotasForm.SelectedIndex;
            if (indice != -1)
            {
                lstMascotas[indice].Cambio(indice, lstMascotasForm, btnEliminar, lblNombre, lblEdad, mrcAcciones, prbAlimentar, prbJugar, prbCuidar, tmrNecesidades);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(lstMascotas[indice].picMascota);
            lstMascotas[indice].picMascota.Dispose();
            lstMascotas.RemoveAt(indice);
            lstMascotasForm.Items.Clear();
            foreach (clsMascota mascota in lstMascotas)
            {
                lstMascotasForm.Items.Add(mascota.Nombre + " | " + mascota.Tipo + " | " + mascota.Edad);
            }
            Limpiar();
            btnEliminar.Enabled = false;
        }
    }
}
