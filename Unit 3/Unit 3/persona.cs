using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3
{
    internal class persona
    {
        protected String Nombre;
        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        protected String ApellidoP;
        public String apellidoP
        {
            get { return ApellidoP; }
            set { ApellidoP = value; }
        }
        protected String ApellidoM;
        public String apellidoM
        {
            get{ return ApellidoM; }
            set { ApellidoM = value; }
        }
        protected DateTime? FN;
        public DateTime? fn
        {
            get { return FN; }
            set { FN = value; }
        }
        public int Edad
        {
            get
            {
                int edad = (DateTime.Now.Year - FN.Value.Year);
                return edad;
            }
        }


        public persona()
        {
            Nombre = String.Empty;
            ApellidoP = String.Empty;
            ApellidoM = String.Empty;
            FN = null;
        }
        public persona(string Nombre, string ApellidoP, string ApellidoM, DateTime? FN)
        {
            this.Nombre = Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;
            this.FN = FN;
        }
        public override string ToString()
        {
            return Nombre.ToUpper() + " " + ApellidoP.ToUpper() + " " + ApellidoM.ToUpper() + " " + FN + " " + Edad;
        }

        //~persona()
        //{
        //    // esto es un destructor en la clase persona 
        //}

    }
}
