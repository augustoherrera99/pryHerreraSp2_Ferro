using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pryHerreraAugustoSp2_Ferro
{
    public partial class frcBoleteria : Form
    {
        public frcBoleteria()
        {
            InitializeComponent();
        }

        private void frcBoleteria_Load(object sender, EventArgs e)
        {
            txtDistancia.Text = "";
            numDias.Value = 1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float Precio = 0;
            float Distancia = float.Parse(txtDistancia.Text);
            int Estancia = int.Parse(numDias.Text);

            Precio = Distancia * 5;

            if (Distancia >= 100 && Estancia >= 7)
            {
                Precio = Precio * 0.5f;
                MessageBox.Show("El precio de su boleto es de $" + Precio.ToString() + "\r\n" + "\r\n" + "(Descuento del 50%)", "Monto a pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDistancia.Text = "";
                numDias.Value = 1;  
            }
            else
            {
                MessageBox.Show("El precio de su boleto es de $" + Precio.ToString(), "Monto a pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDistancia.Text = "";
                numDias.Value = 1;
            }
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }
    }
}
