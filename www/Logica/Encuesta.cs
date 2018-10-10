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
        string Nombre { get; set; }
        string Descripcion { get; set; }
        bool Activado { get; set; }
        private BaseDatos bd;

        public Encuesta(string nombre, string descripcion, bool activado, BaseDatos bd)
        {

            Nombre = nombre;
            Descripcion = descripcion;
            Activado = activado;
            this.bd = bd;
        }

        public void Puntuar(int puntuacion)
        {
            bd.GuardarPuntuacion(this, puntuacion);
        }

        public void ModificarEncuesta(string n, string d)
        {
            if(n != null)
            {
                Nombre = n;
            }
            if(d != null)
            {
                Descripcion = d;
            }
        }

        public void ActivarDesactivarEncuesta()
        {
            if (Activado)
            {
                Activado = false;
            }
            else
            {
                Activado = true;
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
    }
}
