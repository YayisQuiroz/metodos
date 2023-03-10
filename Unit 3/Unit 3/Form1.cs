using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        contacto[] a;
        

        private void button1_Click(object sender, EventArgs e)
        {
            a = new contacto[(int)numericUpDown1.Value];
            if (i < a.Length)
            {
                a[i] = new contacto();
                a[i].nombre = NOM.Text;
                a[i].apellidoP = APEP.Text;
                a[i].apellidoM = APEM.Text;
                a[i].fn = FCH.Value; 
                a[i].Numero = TEL.Text;
                a[i].Correo = COE.Text;

                TABLA.Rows.Add(a[i].nombre, a[i].apellidoP, a[i].apellidoM, a[i].fn, a[i].Edad, a[i].Numero, a[i].Correo);
                NOM.Clear();
                APEP.Clear();
                APEM.Clear();
                FCH.Value = DateTime.Now;
                TEL.Clear();
                COE.Clear();
                i++;
            }
            
        }
    }
}
