using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.models
{
    public class DivideAndConquerSolver
    {
        // Método principal para QuickSort
        public void QuickSort(int[] array)
        {
            QuickSortRecursive(array, 0, array.Length - 1);
        }

        // Método recursivo de QuickSort
        private void QuickSortRecursive(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortRecursive(array, low, pivotIndex - 1);
                QuickSortRecursive(array, pivotIndex + 1, high);
            }
        }

        // Método para dividir el array en base al pivote
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        // Método para intercambiar elementos en el array
        private void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
