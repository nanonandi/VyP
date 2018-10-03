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
        private readonly BaseDatos bd;

        public Encuesta(string nombre, string descripcion, bool activado, BaseDatos bas)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Activado = activado;
            bd = bas;
        }

        public void Puntuar(int puntuacion)
        {
            bd.GuardarPuntuacion(puntuacion);
        }
    }
}
