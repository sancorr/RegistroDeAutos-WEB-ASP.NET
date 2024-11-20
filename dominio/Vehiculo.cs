using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Vehiculo
    {
		public int Id { get; set; }
		public string Modelo { get; set; }
		public string Marca { get; set; }
		public DateTime FechaFabricacion { get; set; }
		public bool Usado { get; set; }
		public bool Importado { get; set; }
	}
}
