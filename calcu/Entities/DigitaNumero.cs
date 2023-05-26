using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu.Entities
{
    internal class DigitaNumero
    {
        Operacao operacao = new Operacao();
        public void Digita()
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
            operacao.OperacaoEscolha(numb,numb2,opera);
            Console.Clear();
        }

        public void DigitaUmNumero()
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
            Console.Clear();
        }
    }
}
