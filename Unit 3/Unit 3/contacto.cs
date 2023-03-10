using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3
{
    internal class contacto : persona
    {
        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public contacto() : base()
        {
            numero = string.Empty;
            correo = string.Empty;
        }
        public contacto(string Nombre, string ApellidoP, string ApellidoM, DateTime? FN, string telefono, 
            string correo) : base(Nombre,ApellidoP,ApellidoM,FN)
        {
            this.correo = correo;
            this.Numero = telefono;
        }
        public override string ToString()
        {
            return base.ToString() + " " + numero + " " + correo;
        }
        //~contacto()
        //{
        //    // esto es un destructor en la clase contacto
        //}


    }
}
