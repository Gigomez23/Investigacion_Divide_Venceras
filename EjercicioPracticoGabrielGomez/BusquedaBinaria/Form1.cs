using BusquedaBinaria.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {

        DatosEntrada entradaDatos = new DatosEntrada();
        FuncionBusquedaBinaria busqueda = new FuncionBusquedaBinaria();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Procesar la lista de números con la clase EntradaDatos
                int[] listaNumeros = entradaDatos.ProcesarLista(tbNumbersList.Text);

                // Crear una instancia de BusquedaBinaria con la lista procesada
                busqueda = new FuncionBusquedaBinaria(listaNumeros);

                // Procesar el número a buscar
                int numeroABuscar = entradaDatos.ProcesarNumeroABuscar(tbNumber.Text);

                // Realizar la búsqueda
                int resultado = busqueda.Buscar(numeroABuscar);

                // Mostrar el resultado en el TextBox
                if (resultado != -1)
                    tbResult.Text = $"Número {numeroABuscar} encontrado en la posición {resultado + 1}.";
                else
                    tbResult.Text = $"Número {numeroABuscar} no encontrado.";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
