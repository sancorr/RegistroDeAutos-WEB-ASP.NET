using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
	public class AutoNegocio
	{
		private List<Vehiculo> lista = new List<Vehiculo>();
		public void Agregar(Vehiculo auto)
		{
			lista.Add(auto);
		}
		public List<Vehiculo> listarVehiculos()
		{
			try
			{
				if(lista == null)
				{
					lista = new List<Vehiculo>();
				}
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			
		}
	}
}
