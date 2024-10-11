using System;

class HeapSortExample
{
    // Método para intercambiar dos elementos
    private void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Método para realizar heapify
    private void Heapify(int[] arr, int n, int i)
    {
        int largest = i; // Inicializa el nodo más grande como raíz
        int left = 2 * i + 1; // Índice del hijo izquierdo
        int right = 2 * i + 2; // Índice del hijo derecho

        // Verifica si el hijo izquierdo es mayor que la raíz
        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        // Verifica si el hijo derecho es mayor que el mayor hasta ahora
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        // Si el mayor no es la raíz, intercambia y aplica heapify nuevamente
        if (largest != i)
        {
            Swap(ref arr[i], ref arr[largest]);
            Heapify(arr, n, largest);
        }
    }

    // Método para ordenar el arreglo utilizando HeapSort
    public void HeapSort(int[] arr)
    {
        int n = arr.Length;

        // Construye el heap (reorganiza el arreglo)
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        // Extrae elementos del heap uno por uno
        for (int i = n - 1; i > 0; i--)
        {
            // Intercambia el primer elemento (la raíz) con el último
            Swap(ref arr[0], ref arr[i]);
            // Aplica heapify en el árbol reducido
            Heapify(arr, i, 0);
        }
    }

    // Método para imprimir el arreglo
    private void PrintArray(int[] arr)
    {
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

    // Ejemplo de uso
    public static void Main(string[] args)
    {
        int[] arr = { 3, 5, 1, 10, 2, 7 };
        HeapSortExample heapSort = new HeapSortExample();

        Console.WriteLine("Arreglo original:");
        heapSort.PrintArray(arr);

        heapSort.HeapSort(arr);

        Console.WriteLine("Arreglo ordenado:");
        heapSort.PrintArray(arr);
    }
}
