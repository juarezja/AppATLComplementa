using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppATLComplementa.Negocio.Dominio
{
	public class Cliente
    {
		public int CliClave { get; set; }
		public int CntClave { get; set; }
		public short CliNumDer { get; set; }
		public short CliNumToma { get; set; }
		public int CliDependencia { get; set; }
		public short GirClave { get; set; }
		public short MatTubClave { get; set; }
		public int MedClave { get; set; }
		public int CorClave { get; set; }
		public short EdoComClave { get; set; }
		public short EdoTomClave { get; set; }
		public short EdoSerClave { get; set; }
		public short NivTarClave { get; set; }
		public short TipAbaClave { get; set; }
		public short TipDreClave { get; set; }
		public short TipEdiClave { get; set; }
		public short TipSerClave { get; set; }
		public int DirClave { get; set; }
		public int CliDirEntrega { get; set; }
		public int CliDirFactura { get; set; }
		public int CliPerClave { get; set; }
		public int CliIndPropietario { get; set; }
		public int CliIndResponsable { get; set; }
		public int CliIndFiscal { get; set; }
		public string CliComentario { get; set; }
		public DateTime CliFechaAlta { get; set; }
		public DateTime CliFechaRegistro { get; set; }
		public short CliHabitantes { get; set; }
		public Double CliHidConsumoFijo { get; set; }
		public Double CliHidConsumoAcum { get; set; }
		public Double CliHidConsumoPromedio { get; set; }
		public short CliHidDiametroDeDescarga { get; set; }
		public short CliHidDiametroDeToma { get; set; }
		public Double CliMetrosConstruidos { get; set; }
		public Double CliDrenajeExtra { get; set; }
		public int CliEsMedido { get; set; }
		public string CliLLave1 { get; set; }
		public string CliLLave2 { get; set; }
		public string CliLLave3 { get; set; }
		public string CliLLave4 { get; set; }
		public string CliLLave5 { get; set; }
		public short CliAdi01Clave { get; set; }
		public short CliAdi02Clave { get; set; }
		public short CliAdi03Clave { get; set; }
		public short CliAdi04Clave { get; set; }
		public short CliAdi05Clave { get; set; }
		public short CliAdi06Clave { get; set; }
		public short CliAdi07Clave { get; set; }
		public short CliAdi08Clave { get; set; }
		public short CliAdi09Clave { get; set; }
		public short CliAdi10Clave { get; set; }
		public Double CliAdi11 { get; set; }
		public Double CliAdi12 { get; set; }
		public Double CliAdi13 { get; set; }
		public Double CliAdi14 { get; set; }
		public Double CliAdi15 { get; set; }
		public string CliAdi16 { get; set; }
		public string CliAdi17 { get; set; }
		public string CliAdi18 { get; set; }
		public string CliAdi19 { get; set; }
		public string CliAdi20 { get; set; }
		public short CliPeriodosDeAdeudo { get; set; }
		public Double CliSaldoTotal { get; set; }
		public Double CliSaldoFacturacion { get; set; }
		public Double CliSaldoConvenios { get; set; }
		public Double CliSaldoOtros { get; set; }
		public Double CliSaldoACuenta { get; set; }
		public int CliCoordenadaX { get; set; }
		public int CliCoordenadaY { get; set; }
		public int CliCoordenadaZ { get; set; }
		public short PerClave { get; set; }
		public short ColClave { get; set; }
		public short CalClave { get; set; }
		public short RutClave { get; set; }
		public short Rn1Clave { get; set; }
		public short Rn2Clave { get; set; }
		public short RutSecuencia { get; set; }
		public Double CliMjoCtaBase { get; set; }
		public Double CliMjoCtaIVA { get; set; }
		public short CliUltimoPeriodoPagado { get; set; }
		public string CliComentLectura { get; set; }
		public int CliDirNotificacion { get; set; }
		public short CliMedidorDentro { get; set; }
		public short MetPagClave { get; set; }
		public string EmpMetodoDePagoCuenta { get; set; }
		public int SecHidClave { get; set; }
		public string CliPrecintoSerie { get; set; }
		public string CliPrecintoColor { get; set; }
		public short PreColClave { get; set; }
		public int CliPrecintoOrden { get; set; }
		public short? LecAleClave { get; set; }
		public string CliPasswordInternet { get; set; }

		public virtual ClientePersona ClientePersona { get; set; }
	}
}
