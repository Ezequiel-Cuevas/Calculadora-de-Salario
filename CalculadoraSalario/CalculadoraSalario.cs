using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSalarioApp
{
    public class CalculadoraSalario
    {
        public decimal CalcularSalario(decimal salarioPorHora, int horasTrabajadas)
        {
            if (horasTrabajadas <= 0)
            {
                return 0;
            }
            else if (horasTrabajadas <= 40)
            {
                return salarioPorHora * horasTrabajadas;
            }
            else
            {
                decimal salarioBase = salarioPorHora * 40;
                decimal horasExtras = horasTrabajadas - 40;
                decimal salarioTotal = salarioBase + (horasExtras * salarioPorHora * 1.5m);
                return salarioTotal;
            }
        }
    }
}

