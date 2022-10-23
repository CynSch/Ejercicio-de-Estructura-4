using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_4
{
    internal class LeerArchivo
    {
        internal static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Persona.txt");

            while(!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                //Documento|Nombre|Apellido|Tipo,codigoPais,codigoArea,numero;Tipo,codigoPais,codigoArea,numero

                string[] datos = linea.Split('|');
                Persona persona = new Persona();
                persona.Documento = int.Parse(datos[0]);
                persona.Nombre = datos[1];
                persona.Apellido = datos[2];

                Persona.Todas.Add(persona);

                string[] telefonos = datos[3].Split(';');
                foreach (string telefono in telefonos)
                {
                    Telefono telefono1 = new Telefono();
                    telefono1.Tipo = telefono.Split(',')[0];
                    telefono1.CodigoDePais = int.Parse(telefono.Split(',')[1]);
                    telefono1.CodigoDeArea = int.Parse(telefono.Split(',')[2]);
                    telefono1.NumeroDeTelefono = int.Parse(telefono.Split(',')[3]);
                    persona.Telefonos.Add(telefono1);
                }

                
                
            }
        }
    }
}
