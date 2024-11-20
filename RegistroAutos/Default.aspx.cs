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
	public partial class Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				if(Session["listaVehiculos"] == null)
				{
					AutoNegocio negocio = new AutoNegocio();
					Session.Add("listaVehiculos", negocio.listarVehiculos());
				}
				dgvRegistros.DataSource = Session["listaVehiculos"];
				dgvRegistros.DataBind();
			}
		}

		protected void dgvRegistros_SelectedIndexChanged(object sender, EventArgs e)
		{
			var id = dgvRegistros.SelectedDataKey.Value.ToString();
			Response.Redirect("AddForm.aspx?id=" + id);
		}
	}
}