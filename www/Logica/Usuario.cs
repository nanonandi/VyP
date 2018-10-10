using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Usuario
    {
        private string contraseña;
        private BaseDatos bd;

        public Usuario(int idUsuario, string cuenta, string eMail, BaseDatos bd)
        {
            this.idUsuario = idUsuario;
            this.cuenta = cuenta;
            this.eMail = eMail;
            this.bd = bd;
        }

        private int idUsuario;
        public int IdUsuario
        {
            get { return this.idUsuario; }
            set { this.idUsuario = value; }
        }

        private string cuenta;
        public string Cuenta
        {
            get { return cuenta; }
            set { this.cuenta = value; }
        }

        private string eMail;
        public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }

        public bool añadirEncuesta (string nombre, string descripcion)
        {
            Encuesta e = new Encuesta(nombre, descripcion,true,bd);
            bd.GuardarEncuesta(e);
            return false;
        }
        public override bool Equals(object obj)
        {
            Usuario item = obj as Usuario;

            if (this.idUsuario == item.IdUsuario)
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
