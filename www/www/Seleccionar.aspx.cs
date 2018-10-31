using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace www
{
    public partial class Seleccionar : System.Web.UI.Page
    {
        List<ListItem> itemsEncuestas = new List<ListItem>();

        BaseDatos db;

        
        protected void Page_Load(object sender, EventArgs e)
        {

            Encuesta encuestaActiva = null;

            db = (BaseDatos)Session["db"];
            if (db == null)
            {
                db = new BaseDatos();
                Session["db"] = db;
            }




        if (!IsPostBack) {
                foreach (Encuesta en in db.EncuestasActivas())
                {
                    itemsEncuestas.Add(new ListItem(en.Nombre, ((int)en.Id).ToString()));
                }

                enc.DataSource = itemsEncuestas;
                enc.DataBind();
            }

            
        }

        

        protected void AccEncuesta_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Votar.aspx");
        }

        protected void Verdesc_Click(object sender, EventArgs e)
        {
            desc.Text = enc.SelectedItem.Text;
        }
    }
}