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
        Operacao.Parametros parametros = new Operacao.Parametros();
        
        public void Digita()
        {
           
            Console.WriteLine("Digite os numeros que deseja calcular");

            Console.Write("Digite o primeiro numero: ");
            float numb = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            float numb2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação que deseja: \n " +
                                    "+ igual soma \n " +
                                    "- igual subtração \n " +
                                    "* igual multiplicação \n" +
                                    " / igual divisão");
            char opera = char.Parse(Console.ReadLine());
            parametros = new Operacao.Parametros(numb,numb2,opera);
            operacao.OperacaoEscolha(parametros);
        }

        public void DigitaUmNumero(float resul)
        {
            Console.WriteLine("Digite os numeros que deseja calcular");

            Console.Write("Digite o primeiro numero: ");
            float numb = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escolha a operação que deseja: \n " +
                        "+ igual soma \n " +
                        "- igual subtração \n " +
                        "* igual multiplicação \n" +
                        " / igual divisão");
            char opera = char.Parse(Console.ReadLine());

            parametros = new Operacao.Parametros(numb,opera,resul);
            operacao.OperacaoEscolhaUmNumero(parametros);
        }
    }
}
