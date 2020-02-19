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
        public Double RefPagTotal { get; set; }
        public Double RefPagRedondeo { get; set; }
        public Double RefPagTotalRedondeado { get; set; }
        public short RefPagDocumentos { get; set; }
        public short EmpPerClave { get; set; }
        public string RefPagHostName { get; set; }
        public string RefPagReferencia { get; set; }
        public short RefPagCancelada { get; set; }
        public short CajTipDocClave { get; set; }
        public int RefPagDocumentoClave { get; set; }
        public int CliClave { get; set; }
    }
}
