using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria.models
{
    internal class FuncionBusquedaBinaria
    {
        public FuncionBusquedaBinaria() { }

        public int[] Datos = new int[0];

        // Constructor que recibe el arreglo de enteros procesado
        public FuncionBusquedaBinaria(int[] listaNumeros)
        {
            Datos = listaNumeros;
        }

        // Método para buscar un número usando el algoritmo de búsqueda binaria
        public int Buscar(int numeroABuscar)
        {
            return BusquedaBinariaRecursiva(Datos, numeroABuscar, 0, Datos.Length - 1);
        }

        // Función recursiva de búsqueda binaria
        private int BusquedaBinariaRecursiva(int[] arr, int num, int izquierda, int derecha)
        {
            if (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arr[medio] == num)
                    return medio;

                if (arr[medio] > num)
                    return BusquedaBinariaRecursiva(arr, num, izquierda, medio - 1);

                return BusquedaBinariaRecursiva(arr, num, medio + 1, derecha);
            }

            return -1;
        }
    }
}
