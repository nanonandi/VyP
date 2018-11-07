using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class Resultados : System.Web.UI.Page
    {

        BaseDatos db;
        Encuesta encuestaActiva;
        List<ListItem> itemsEncuestasTot = new List<ListItem>();
        List<ListItem> itemsResultados = new List<ListItem>();
        List<ListItem> itemsComentarios = new List<ListItem>();
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

        ListItem a;
        protected void Enc_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Enc.SelectedItem;

            if (a.Text != "Vacio")
            {
                encuestaActiva = db.GetEncuesta(a.Text);
                result.Text = encuestaActiva.Puntuacion.ToString();
            }
            else
            {
                Session["encuestaActiva"] = null;
                result.Text = "Seleccione Encuesta";
            }
            itemsResultados = new List<ListItem>();
            itemsComentarios = new List<ListItem>();
            if (encuestaActiva != null)
            {
                
                if (encuestaActiva.Puntuaciones != null)
                {
                    foreach (int en in encuestaActiva.Puntuaciones)
                    {
                        itemsResultados.Add(new ListItem(en.ToString()));
                    }
                    


                    if (encuestaActiva.Puntuaciones != null)
                    {
                        foreach (string en in encuestaActiva.Comentarios)
                        {
                            itemsComentarios.Add(new ListItem(en));
                        }
                    }

                }

            }
            ResultadosList.DataSource = itemsResultados;
            ResultadosList.DataBind();
            ComentariosList.DataSource = itemsComentarios;
            ComentariosList.DataBind();
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Menu.aspx");
        }

        protected void ResultadosList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}