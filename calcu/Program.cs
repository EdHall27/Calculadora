using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcu.Entities;

namespace calcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite os numeros que deseja calcular");

            Console.Write("Digite o primeiro numero: ");
            int numb = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int numb2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação que deseja: \n " +
                                "+ igual soma \n " +
                                "- igual subtração \n " +
                                "* igual multiplicação \n" +
                                " / igual divisão");
            char opera = char.Parse(Console.ReadLine());*/



            int numb, numb2;
            char opera;
            DigitaNumero digitaNumero = new DigitaNumero();
            (numb,numb2,opera) = digitaNumero.Digita();

            string calculo;
            float resultado;
            if (opera == '+')
            {
                Soma soma = new Soma(numb,numb2);
                resultado = soma.Somar(numb, numb2);
                Console.WriteLine("Este e o resultado: "+ resultado);

                Console.WriteLine("Deseja continuar calculado com este resultado");
                calculo = Console.ReadLine();
                if (calculo == "sim" || calculo == "Sim")
                {
                    (numb,opera) = digitaNumero.DigitaUmNumero();
                    Console.WriteLine("Este e o resultado: " + soma.SomarResultado(numb,numb2,resultado));
                }
                else
                {
                    
                }
            }
            else if (opera == '-')
            {

            }
            else if (opera == '*')
            {

            }
            else 
            {

            }
        }
    }
}
