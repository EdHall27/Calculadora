using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu.Entities
{
    internal class DigitaNumero
    {
        public (int,int,char) Digita()
        {
           
            Console.WriteLine("Digite os numeros que deseja calcular");

            Console.Write("Digite o primeiro numero: ");
            int numb = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int numb2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação que deseja: \n " +
                                    "+ igual soma \n " +
                                    "- igual subtração \n " +
                                    "* igual multiplicação \n" +
                                    " / igual divisão");
            char opera = char.Parse(Console.ReadLine());

            return (numb,numb2,opera);
        }

        public (int,char) DigitaUmNumero()
        {
            Console.WriteLine("Digite os numeros que deseja calcular");

            Console.Write("Digite o primeiro numero: ");
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação que deseja: \n " +
                        "+ igual soma \n " +
                        "- igual subtração \n " +
                        "* igual multiplicação \n" +
                        " / igual divisão");
            char opera = char.Parse(Console.ReadLine());

            return (numb, opera);
        }
    }
}
