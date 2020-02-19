using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AppATLComplementa.Negocio.Dominio
{
	public class ClientePersona
	{
		public ClientePersona()
		{
			Clientes = new ObservableCollection<Cliente>();
		}

		public int CliPerClave { get; set; }
		public string CliPerNombre { get; set; }
		public string CliPerPaterno { get; set; }
		public string CliPerMaterno { get; set; }
		public string CliPerNombreOrazon { get; set; }
		public short PerGenClave { get; set; }
		public short EmpPerTipClave { get; set; }
		public string CliPerIfe { get; set; }
		public string CliPerRFC { get; set; }
		public string CliPerCURP { get; set; }
		public short TelTipClave { get; set; }
		public short TelTipClave2 { get; set; }
		public short TelTipClave3 { get; set; }
		public short TelTipClave4 { get; set; }
		public string CliPerTelefono1 { get; set; }
		public string CliPerTelefono2 { get; set; }
		public string CliPerTelefono3 { get; set; }
		public string CliPerTelefono4 { get; set; }
		public DateTime? CliPerFechaNacimiento { get; set; }
		public string CliPerEmail01 { get; set; }
		public string CliPerEmail02 { get; set; }
		public short CliPerEnviaCFD { get; set; }
		public string CliPerTelefonoForaneo { get; set; }
		public string CliPerExtension { get; set; }
		public int CliClaveMigracion { get; set; }

		public virtual ObservableCollection<Cliente> Clientes { get; set; }
	}
}
