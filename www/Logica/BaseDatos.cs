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
            this.tablaUsuarios = new List<Usuario>();
            this.tablaEncuestas = new List<Encuesta>();
            //meter un usuario para hacer pruebas

            Usuario u1 = new Usuario(0, "cero", "cero@cero.com", "hola");
            Usuario u2 = new Usuario(1, "uno", "uno@uno.com", "adios");
            tablaUsuarios.Add(u1);
            tablaUsuarios.Add(u2);

            Encuesta e1 = new Encuesta(0, "Encuesta 1", "Esta encuesta es la primera", true);
            Encuesta e2 = new Encuesta(1, "Encuesta 2", "Esta encuesta es el segundo", true);
            tablaEncuestas.Add(e1);
            tablaEncuestas.Add(e2);

        }

        public List<Encuesta> Encuestas()
        {
            return tablaEncuestas;
        }

        public List<Encuesta> EncuestasActivas()
        {
            List<Encuesta> activas = new List<Encuesta>();
            foreach(Encuesta en in tablaEncuestas)
            {
                if (en.Activo())
                {
                    activas.Add(en);
                }
            }
            return activas;
        }

        public bool EstaUsuario(int id)
        {
            bool devolver = false;
            foreach (Usuario us in tablaUsuarios)
            {
                if (us.IdUsuario == id)
                {
                    devolver = true;
                }
            }

            return devolver;
        }

        public bool EstaEncuesta(int id)
        {
            bool devolver = false;
            foreach (Encuesta en in tablaEncuestas)
            {
                if (en.Id == id)
                {
                    devolver = true;
                }
            }

            return devolver;
        }

        public bool GuardarUsuario(Usuario u)
        {
            if (EstaUsuario(u.IdUsuario) == false)
            {
                tablaUsuarios.Add(u);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool GuardarEncuesta(Encuesta e)
        {
            if (EstaEncuesta(e.Id) == false)
            {
                tablaEncuestas.Add(e);
                return true;
            }
            else
            {
                return false;
            }

        }

        //Usuario leeUsuario (string cuenta){}
        //List<Encuesta> leeEncuestasActivas(){}

    }
}
