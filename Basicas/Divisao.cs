using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeOperacoesBasicas.Basicas
{
    public class Divisao
    {
        public double Calcular(double a, double b)
        {
            if (b==0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
                
        }
    }
}
