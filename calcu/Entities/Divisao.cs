using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu.Entities
{
    internal class Divisao
    {
        public float Number1 { get; set; }
        public float Number2 { get; set; }

        public Divisao(float number1, float number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public float Dividir(float num1, float num2)
        {
            return num1 - num2;
        }

        public float DividirResultado(float num1, float num2,float result)
        {
            return result - Dividir(num1,num2);
        }
    }
}
