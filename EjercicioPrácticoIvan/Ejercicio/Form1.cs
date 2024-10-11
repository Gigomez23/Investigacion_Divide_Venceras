using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio.models;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar los nuevos resultados
            lbResult.Items.Clear();

            // Obtener la lista de números desde el TextBox
            string input = tbNumber.Text;

            try
            {
                // Convertir el input en un array de enteros
                int[] numbers = input.Split(',').Select(int.Parse).ToArray();

                // Crear una instancia de la clase DivideAndConquerSolver
                DivideAndConquerSolver solver = new DivideAndConquerSolver();

                // Agregar el array original al ListBox
                lbResult.Items.Add("Array original: " + string.Join(", ", numbers));

                // Aplicar QuickSort
                solver.QuickSort(numbers);

                // Agregar el array ordenado al ListBox
                lbResult.Items.Add("Array ordenado con QuickSort: " + string.Join(", ", numbers));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números separados por comas correctamente.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
