using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Encuesta
    {
       
        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
        }
        private string descripcion;
        public string Descripcion
        {
            get{ return this.descripcion; }
        }
        private bool activado;
        public bool Activo()
        {
            return activado;
        }
        private List<int> puntuacion = new List<int>();
        public int Puntuacion
        {
            get { if (puntuacion.Count > 0)
                {
                    return puntuacion.Sum() / puntuacion.Count;
                }
                else { return 0; }  }
        }

        private List<string> comentarios = new List<string>();
        public List<string> Comentarios
        {
            get
            {
                if (comentarios.Count > 0)
                {
                    return comentarios;
                }
                else { return null; }
            }
        }

        private List<DateTime> fechas = new List<DateTime>();
        public List<DateTime> Fechas
        {
            get
            {
                if (fechas.Count > 0)
                {
                    return fechas;
                }
                else { return null; }
            }

        }

        public void Fechar(DateTime fech)
        {
            this.fechas.Add(fech);
        }

        public void Comentar(string comentario)
        {
            this.comentarios.Add(comentario);
        }



        public List<int> Puntuaciones
        {
            get
            {
                if (puntuacion.Count > 0)
                {
                    return puntuacion;
                }
                else { return null; }
            }
        }


        public Encuesta(string nombre, string descripcion, bool activado)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.activado = activado;
        }

        public void Puntuar(int puntuacion)
        {
            this.puntuacion.Add(puntuacion);
        }

        public void ModificarEncuesta(string n, string d)
        {
            if (n != null)
            {
                nombre = n;
            }
            if (d != null)
            {
                descripcion = d;
            }
        }

        public void ActivarDesactivarEncuesta()
        {
            if (Activo())
            {
                activado = false;
            }
            else
            {
                activado = true;
            }
        }

        public int NumeroVotos()
        {
            return puntuacion.Count;
        }

        public override bool Equals(object obj)
        {
            Encuesta item = obj as Encuesta;

            if (this.Nombre == item.Nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode();
        }

       
        
    }
}
