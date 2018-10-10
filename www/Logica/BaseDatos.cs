using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BaseDatos
    {
        private List<Usuario> tablaUsuarios; 
        private List<Encuesta> tablaEncuestas; 

        public BaseDatos()
        {
            this.tablaUsuarios  = new List<Usuario>(); 
            this.tablaEncuestas = new List<Encuesta>();
        }

        public BaseDatos (List <Object> o)
        {
            if (o.First().GetType()==Type.GetType("Usuario"))
            {
                
                //añadir constructor
            }

            if (o.First().GetType() == Type.GetType("Encuesta"))
            {

                //añadir constructor
            }
        }

        public bool EstaUsuario(Usuario u)
        {
            if (tablaUsuarios.Contains(u))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EstaEncuesta(Encuesta e)
        {
            if (tablaEncuestas.Contains(e))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GuardarPuntuacion (Encuesta e, int punt)
        {
            return false;
        }

        public bool GuardarEncuesta(Encuesta e)
        {
            return false;
        }

    }
}
