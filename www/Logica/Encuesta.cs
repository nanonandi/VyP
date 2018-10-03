using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
    {
    class Encuesta
        {
        string Nombre { get; set; }
        string Descripcion { get; set; }
        bool Activado { get; set; }
        int Puntuacion { get; set; }

        public Encuesta(string nombre, string descripcion, bool activado)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Activado = activado;
        }
    }
}
