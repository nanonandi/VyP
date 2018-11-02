using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Logica
{
    public class Usuario
    {
        private string contrasena;

        public Usuario(string cuenta, string eMail, string contrasena)
        {
            this.cuenta = cuenta;
            this.eMail = eMail;
            this.contrasena = Encriptar(contrasena);
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
            this.contrasena = cont;
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

            if (this.Cuenta == item.Cuenta)
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
            return Cuenta.GetHashCode();
        }

    }
}
