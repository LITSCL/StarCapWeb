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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Bebida> bebidas = new BebidaDAL().GetAll();
            CafeDdl.DataSource = bebidas;
            CafeDdl.DataTextField = "Nombre";
            CafeDdl.DataValueField = "Codigo";
            CafeDdl.DataBind();
        }

        protected void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string nombre = NombreTxt.Text.Trim();
                string rut = RutTxt.Text.Trim();
                string codigoBebida = CafeDdl.SelectedValue;
                int nivelCliente = Convert.ToInt32(TipoRdl.SelectedValue);

                Cliente c = new Cliente();
                c.Nombre = nombre;
                c.Rut = rut;
                c.CodigoBebidaFavorita = codigoBebida;
                c.Nivel = nivelCliente;

                new ClienteDAL().Save(c);
            }
            else
            {

            }
        }

        protected void CustomValidatorRutTxt_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String rut = RutTxt.Text.Trim();

            if (rut == string.Empty)
            {
                CustomValidatorRutTxt.ErrorMessage = "Debes ingresar el rut";
                args.IsValid = false;
            }
            else
            {
                string[] rutArray = rut.Split('-');
                if (rutArray.Length == 2)
                {
                    if (rutArray[1].Length != 1)
                    {
                        CustomValidatorRutTxt.ErrorMessage = "El digito verificador debe tener un caracter";
                        args.IsValid = false;
                    }
                    else
                    {
                        args.IsValid = true;
                    }
                }
                else
                {
                    CustomValidatorRutTxt.ErrorMessage = "El rut debe poseer un guión";
                    args.IsValid = false;
                }
            }
        }
    }
}