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

            Usuario u1 = new Usuario("cero", "cero@cero.com", "hola");
            Usuario u2 = new Usuario("uno", "uno@uno.com", "adios");
            tablaUsuarios.Add(u1);
            tablaUsuarios.Add(u2);

            Encuesta e1 = new Encuesta("Encuesta 1", "Esta encuesta es la primera", true);
            Encuesta e2 = new Encuesta("Encuesta 2", "Esta encuesta es el segundo", true);
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

        public bool EstaUsuario(string id)
        {
            bool devolver = false;
            foreach (Usuario us in tablaUsuarios)
            {
                if (us.Cuenta == id)
                {
                    devolver = true;
                }
            }

            return devolver;
        }

        public bool EstaEncuesta(string id)
        {
            bool devolver = false;
            foreach (Encuesta en in tablaEncuestas)
            {
                if (en.Nombre == id)
                {
                    devolver = true;
                }
            }

            return devolver;
        }

        public Encuesta GetEncuesta(string id)
        {
            Encuesta devolver = null;
            foreach (Encuesta en in tablaEncuestas)
            {
                if (en.Nombre == id)
                {
                    devolver = en;
                    break;
                }
            }

            return devolver;
        }

        public Usuario GetUsuario(string id)
        {
            Usuario devolver = null;
            foreach (Usuario us in tablaUsuarios)
            {
                if (us.Cuenta == id)
                {
                    devolver = us;
                    break;
                }
            }

            return devolver;
        }

        public bool GuardarUsuario(Usuario u)
        {
            if (EstaUsuario(u.Cuenta) == false)
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
            if (EstaEncuesta(e.Nombre) == false)
            {
                tablaEncuestas.Add(e);
                return true;
            }
            else
            {
                return false;
            }

        }

        public int NumUsuarios()
        {
            return tablaUsuarios.Count();
        }

        public int NumEncuestas()
        {
            return tablaEncuestas.Count();
        }

        public int NumEncuestasActivas()
        {
            return EncuestasActivas().Count;
        }

        //Usuario leeUsuario (string cuenta){}
        //List<Encuesta> leeEncuestasActivas(){}

    }
}
