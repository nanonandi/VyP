using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class BaseDatos
    {
        private List <Usuario> tablaUsuarios = new List<Usuario>();

        public BaseDatos()
        {

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
            if (tablaUsuarios.Contains(u))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
