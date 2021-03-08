using ConversorMoneda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtPeso.Text))
            {
                Pesos pesosEnTxt = Convert.ToDouble(this.txtPeso.Text);

                this.txtDolar.Text = ((Dolar)pesosEnTxt).GetCantidad().ToString();
                this.txtDolarBlue.Text = ((DolarBlue)pesosEnTxt).GetCantidad().ToString();
                this.txtDolarCCL.Text = ((DolarCCL)pesosEnTxt).GetCantidad().ToString();
                this.txtDolarAhorro.Text = ((DolarAhorro)pesosEnTxt).GetCantidad().ToString();
                this.txtDolarTurista.Text = ((DolarTurista)pesosEnTxt).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("El valor ingresado no es un valor valido", "Error", MessageBoxButtons.OK);
                this.txtDolar.Text = "";
                this.txtDolarBlue.Text = "";
                this.txtDolarCCL.Text = "";
                this.txtDolarAhorro.Text = "";
                this.txtDolarTurista.Text = "";
            }
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {
            frmConversor.SetCotizaciones();
        }

        public static void SetCotizaciones()
        {
            Pesos.SetCotizacion(0.010526);
            Dolar.SetCotizacion(1);
            DolarBlue.SetCotizacion(1.515);
            DolarCCL.SetCotizacion(1.5568);
            DolarAhorro.SetCotizacion(1.65);

            DolarTurista.SetCotizacion(4);
        }
    }
}
