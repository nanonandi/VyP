using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Encuesta
    {
        private int id;
        public int Id
        {
            get { return this.id; }
        }
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

        public Encuesta(int id, string nombre, string descripcion, bool activado)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.activado = activado;
        }

        public void Puntuar(int puntuacion)
        {
            bd.GuardarPuntuacion(this, puntuacion);
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
        public override bool Equals(object obj)
        {
            Encuesta item = obj as Encuesta;

            if (this.id == item.Id)
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
            return this.id;
        }
    }
}
