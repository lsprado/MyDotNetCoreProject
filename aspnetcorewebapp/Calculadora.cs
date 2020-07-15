using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcorewebapp
{
    public class Calculadora
    {
        public int Somar (int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Dividir(int a, int b)
        {
            if(b > 0)
            {
                return a / b;
            }
            else
            {
                throw new Exception("Erro");
            }
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}
