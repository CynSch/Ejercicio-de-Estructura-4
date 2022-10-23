using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_4
{
    internal class Telefono
    {
        //Al menos 1
        public string Tipo { get; set; } //CASA/TRABAJO/OTRO
        public int CodigoDePais { get; set; } //2 cifras
        public int CodigoDeArea { get; set; } //2 cifras
        public int NumeroDeTelefono { get; set; } //6-8 cifras

    }
}
