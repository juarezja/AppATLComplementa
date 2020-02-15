using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppATLComplementa.AccesoDatos;
using AppATLComplementa.Negocio.Dominio;


namespace AppATLComplementa
{
    public partial class Form1 : Form
    {
        ATLComplementaContexto complementa;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var unidadDeTrabajo = new UnidadDeTrabajo(new ATLComplementaContexto()))
            {
                //var referencias = unidadDeTrabajo.ReferenciaDePago.TraerTodos();
                referenciaDePagoBindingSource.DataSource = unidadDeTrabajo.ReferenciaDePago.TraerTodos();
            }
        }
    }
}
