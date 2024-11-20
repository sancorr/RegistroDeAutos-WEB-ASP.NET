using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace RegistroAutos
{
	public partial class AddForm: Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				if(Request.QueryString["id"] != null)
				{
					int id = int.Parse(Request.QueryString["id"].ToString());

					List<Vehiculo> temp = (List<Vehiculo>)Session["listaVehiculos"];

					Vehiculo seleccionado = temp.Find(v => v.Id == id);

					autoID.Text = seleccionado.Id.ToString();
					autoID.ReadOnly = true;
					autoModelo.Text = seleccionado.Modelo;
					autoMarca.Text = seleccionado.Marca;
					autoFecha.Text = seleccionado.FechaFabricacion.ToString("yyyy-MM-dd");
					chkUsado.Checked = seleccionado.Usado;
					chkImportado.Checked = seleccionado.Importado;

					btnConfirmar.Visible = false;
					btnModificar.Visible = true;
					btnEliminar.Visible = true;
				}
				else
				{
					btnConfirmar.Visible = true;
					btnModificar.Visible = false;
					btnEliminar.Visible = false;
				}
			}
		}
		
		protected void btnConfirmar_Click(object sender, EventArgs e)
		{
			Vehiculo vehiculo = new Vehiculo();

			vehiculo.Id = int.Parse(autoID.Text);
			vehiculo.Modelo = autoModelo.Text;
			vehiculo.Marca = autoMarca.Text;
			vehiculo.FechaFabricacion = DateTime.Parse(autoFecha.Text);
			vehiculo.Usado = chkUsado.Checked;
			vehiculo.Importado = chkImportado.Checked;

			if(Session["listaVehiculos"] == null)
			{
				Session["listaVehiculos"] = new List<Vehiculo>();
			}

			List<Vehiculo> temp = (List<Vehiculo>)Session["listaVehiculos"];
			Vehiculo repetido = temp.Find(x => x.Id == vehiculo.Id);
			if (repetido == null)
			{
				temp.Add(vehiculo);
				Response.Redirect("Default.aspx");
			}
			else
			{
				lblError.Visible = true;
			}
		}

		protected void btnModificar_Click(object sender, EventArgs e)
		{
			if(Request.QueryString["id"] != null)
			{
				
				int id = int.Parse(Request.QueryString["id"].ToString());
				List<Vehiculo> temp = (List<Vehiculo>)Session["listaVehiculos"];
				Vehiculo seleccionado = temp.Find(v => v.Id == id);

				if(seleccionado != null)
				{
					seleccionado.Modelo = autoModelo.Text;
					seleccionado.Marca = autoMarca.Text;
					seleccionado.FechaFabricacion = DateTime.Parse(autoFecha.Text);
					seleccionado.Usado = chkUsado.Checked;
					seleccionado.Importado = chkImportado.Checked;

					Session["listaVehiculos"] = temp;
					
					Response.Redirect("Default.aspx");
				}

			}

		}

		protected void btnEliminar_Click(object sender, EventArgs e)
		{
			if (Request.QueryString["id"] != null)
			{
				
				int id = int.Parse(Request.QueryString["id"].ToString());
				List<Vehiculo> temp = (List<Vehiculo>)Session["listaVehiculos"];
				Vehiculo seleccionado = temp.Find(v => v.Id == id);

				temp.Remove(seleccionado);

				Session["listaVehiculos"] = temp;

				Response.Redirect("Default.aspx");
			}
		}
	}
}