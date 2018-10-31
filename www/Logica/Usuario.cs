using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Logica
{
    public class Usuario
    {
        private string contrasena;

        public Usuario(int idUsuario, string cuenta, string eMail, string contrasena)
        {
            this.idUsuario = idUsuario;
            this.cuenta = cuenta;
            this.eMail = eMail;
            Encriptar(contrasena);
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

        public void AsignarContrasena (string contra)
        {
            string cont = Encriptar(contra);
            this.contrasena = contra;
        }

        public bool ComprobarContrasena(string contra)
        {
            string cont = Encriptar(contra);
            return this.contrasena.Equals(cont);
        }

        private string Encriptar(string password)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            SHA256 mySHA256 = SHA256.Create();
            bytes = mySHA256.ComputeHash(bytes);
            return (System.Text.Encoding.ASCII.GetString(bytes));
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

        public override int GetHashCode()
        {
            return this.idUsuario;
        }

    }
}
