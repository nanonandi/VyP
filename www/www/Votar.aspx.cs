using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class Votar : System.Web.UI.Page
    {
        BaseDatos db;
        Encuesta en;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = (BaseDatos)Session["db"];
            en = (Encuesta)Session["encuestaActiva"];
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (db.EstaEncuesta(en.Nombre))
            {
                en.Puntuar(1);
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (db.EstaEncuesta(en.Nombre))
            {
                en.Puntuar(2);
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (db.EstaEncuesta(en.Nombre))
            {
                en.Puntuar(3);
            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if (db.EstaEncuesta(en.Nombre))
            {
                en.Puntuar(4);
            }
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            if (db.EstaEncuesta(en.Nombre))
            {
                en.Puntuar(5);
            }
        }
    }
}