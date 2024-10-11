using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria.models
{
    internal class DatosEntrada
    {
        public DatosEntrada() { }

        //función para procesar los datos de entrada y convertir de string a entero.
        public int[] ProcesarLista(string listaNumeros)
        {
            try
            {
                // Convertir la lista de strings en enteros y ordenarlos
                return listaNumeros.Split(',').Select(int.Parse).OrderBy(n => n).ToArray();
            }
            catch
            {
                throw new ArgumentException("La lista de números ingresada no es válida.");
            }
        }

        public int ProcesarNumeroABuscar(string numeroABuscar)
        {
            if (int.TryParse(numeroABuscar, out int numero))
            {
                return numero;
            }
            else
            {
                throw new ArgumentException("El número a buscar no es válido.");
            }
        }
    }
}
