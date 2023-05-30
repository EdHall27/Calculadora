using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu.Entities
{
    internal class Subtracao
    {
        /*public float Number1 { get; set; }
        public float Number2 { get; set; }

        public Subtracao(float number1, float number2)
        {
            Number1 = number1;
            Number2 = number2;
        }*/

        public float Subtrair(float num1, float num2)
        {
            return num1 - num2;
        }

        public float SubtrairResultado(float num1,float result)
        {
            return result - num1;
        }
    }
}
