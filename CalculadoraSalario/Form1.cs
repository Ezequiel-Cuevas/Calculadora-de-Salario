using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSalarioApp
{
    public partial class Form1 : Form
    {
        private CalculadoraSalario calculadora = new CalculadoraSalario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal salarioPorHora;
            int horasTrabajadas;

            if (decimal.TryParse(txtSalarioPorHora.Text, out salarioPorHora) &&
                int.TryParse(txtHorasTrabajadas.Text, out horasTrabajadas))
            {
                decimal salarioTotal = calculadora.CalcularSalario(salarioPorHora, horasTrabajadas);
                lstResultados.Items.Add($"Salario semanal: ${salarioTotal}");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para el salario por hora y las horas trabajadas.");
            }
        }
    }
}
