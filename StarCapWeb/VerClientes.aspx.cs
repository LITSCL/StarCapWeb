using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class VerClientes : System.Web.UI.Page
    {
        private ClienteDAL dalClientes = new ClienteDAL();

        private void CargarTabla(List<Cliente> clientes)
        {
            ClientesGrid.DataSource = clientes;
            ClientesGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(dalClientes.GetAll());
            }
        }

        protected void ClientesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                String rutEliminar = e.CommandArgument.ToString();
                dalClientes.Delete(rutEliminar);

                CargarTabla(dalClientes.GetAll());
            }
        }

        protected void NivelDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nivelSeleccionado = Convert.ToInt32(NivelDdl.SelectedValue);

            List<Cliente> clientesFiltrados = dalClientes.GetAll(nivelSeleccionado);

            CargarTabla(clientesFiltrados);
        }

        protected void TodosChx_CheckedChanged(object sender, EventArgs e)
        {
            NivelDdl.Enabled = !TodosChx.Checked;

            if (TodosChx.Checked)
            {
                CargarTabla(dalClientes.GetAll());
            }
        }
    }
}