using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppATLComplementa.Negocio.Dominio;

namespace AppATLComplementa
{
    public partial class Form1 : Form
    {
        Cliente cliente = new Cliente();
        public Form1()
        {
            InitializeComponent();
            cntClaveTextBox.Focus();
        }
        private void TraerDatos(int predio)
        {
            using (var unidadDeTrabajo = new UnidadDeTrabajo(new ATLComplementaContexto()))
            {
                //var referencias = unidadDeTrabajo.ReferenciaDePago.TraerTodos();
                clienteBindingSource.DataSource = unidadDeTrabajo.Cliente.TraerPredio(predio);
                cliente = (Cliente)clienteBindingSource.Current;
                referenciaDePagoBindingSource.DataSource = unidadDeTrabajo.ReferenciaDePago.TraerPorCliente(cliente.CntClave);
            }
        }

        private void cntClaveTextBox_Leave(object sender, EventArgs e)
        {
            TraerDatos(int.Parse(cntClaveTextBox.Text));
        }
    }
}
