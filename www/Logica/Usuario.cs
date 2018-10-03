using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Usuario
    {
        private string contrasena;

        public Usuario(int idUsuario, string cuenta, string eMail)
        {
            this.idUsuario = idUsuario;
            this.cuenta = cuenta;
            this.eMail = eMail;
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

    }
}
