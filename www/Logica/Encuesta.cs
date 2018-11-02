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
            get { return puntuacion.Sum()/puntuacion.Count; }
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
