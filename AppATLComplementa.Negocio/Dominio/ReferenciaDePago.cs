using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppATLComplementa.Negocio.Dominio
{
    public class ReferenciaDePago
    {
        public int RefPagClave { get; set; }
        public DateTime RefPagEmision { get; set; }
        public DateTime RefPagVencimiento { get; set; }
        public float RefPagTotal { get; set; }
        public float RefPagRedondeo { get; set; }
        public float RefPagTotalRedondeado { get; set; }
        public int RefPagDocumentos { get; set; }
        public int EmpPerClave { get; set; }
        public string RefPagHostName { get; set; }
        public string RefPagReferencia { get; set; }
        public int RefPagCancelada { get; set; }
        public int CajTipDocClave { get; set; }
        public int RefPagDocumentoClave { get; set; }
        public int CliClave { get; set; }
    }
}
