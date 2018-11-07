using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class ActDesactEnc : System.Web.UI.Page
    {

        BaseDatos db;
        Encuesta encuestaActiva;
        ListItem a;
        List<ListItem> itemsEncuestasTot = new List<ListItem>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["sesion"] == null)
            {
                Server.Transfer(".\\Seleccionar.aspx");
            }

            db = (BaseDatos)Session["db"];
            if (!IsPostBack)
            {
                itemsEncuestasTot.Add(new ListItem("Vacio", "0"));
                foreach (Encuesta en in db.Encuestas())
                {
                    itemsEncuestasTot.Add(new ListItem(en.Nombre, en.Descripcion));
                }

                Enc.DataSource = itemsEncuestasTot;
                Enc.DataBind();
            }
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {

            a = Enc.SelectedItem;
            db.GetEncuesta(a.Text).ActivarDesactivarEncuesta();

            Server.Transfer(".\\Menu.aspx");
        }

        
        protected void Enc_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Enc.SelectedItem;

            if (a.Text != "Vacio")
            {
                encuestaActiva = db.GetEncuesta(a.Text);

                if (encuestaActiva.Activo())
                {
                    Estado.Text = "Activa";
                    Aceptar.Text = "Desactivar";
                }
                else
                {
                    Estado.Text = "Inactiva";
                    Aceptar.Text = "Activar";
                }
            }
            else
            {
                Session["encuestaActiva"] = null;
                Estado.Text = "Seleccione Encuesta";
            }
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Menu.aspx");
        }
    }
}