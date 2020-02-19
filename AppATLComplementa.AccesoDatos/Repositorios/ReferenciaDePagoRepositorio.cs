﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppATLComplementa.Negocio.Dominio;
using AppATLComplementa.Nucleo.Repositorios;


namespace AppATLComplementa.AccesoDatos.Repositorios
{
    public class ReferenciaDePagoRepositorio : Repositorio<ReferenciaDePago>, IReferenciaDePagoRepositorio
    {
        public ReferenciaDePagoRepositorio(ATLComplementaContexto contexto) : base(contexto)
        {
        }

        public ATLComplementaContexto ATLComplementaContexto
        {
            get { return Context as ATLComplementaContexto; }
        }

        public IEnumerable<ReferenciaDePago> TraerPorCliente(int cliente)
        {
            return ATLComplementaContexto.ReferenciasDePago.Where(r => r.CliClave==cliente).ToList();
        }

    }
}
