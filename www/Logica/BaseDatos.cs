using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class BaseDatos
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
                
                this.tablaEncuestas = new List<Encuesta>();
            }
        }

        public bool estaUsuario(Usuario u)
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

        public bool estaEncuesta(Encuesta e)
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

        public bool guardarPuntuacion (Encuesta e, int punt)
        {
            return false;
        }


    }
}
