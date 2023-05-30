using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu.Entities
{
    internal class Operacao
    {
        public class Parametros
        {
            public float Numero1 { get; set; }
            public float Numero2 { get; set; }
            public char Operacao { get; set; }
            public float Resultado { get; set; }

            public Parametros()
            {
            }

            public Parametros(float numero1, float numero2, char operacao)
            {
                Numero1 = numero1;
                Numero2 = numero2;
                Operacao = operacao;
            }

            public Parametros(float numero1, char operacao, float resultado)
            {
                Numero1 = numero1;
                Operacao = operacao;
                Resultado = resultado;
            }
        }


        public void OperacaoEscolha(Parametros parametros)
        {
            string calculo;
            float resultado;

            float numb = parametros.Numero1;
            float numb2 = parametros.Numero2;
            char opera = parametros.Operacao;

            DigitaNumero digitaNumero = new DigitaNumero();
            

            

            // OPERAÇAO SOMA //
            if (opera == '+')
            {
                Soma soma = new Soma();
                resultado = soma.Somar(numb, numb2);
                Console.WriteLine("Este e o resultado: " + resultado);
               

                Console.WriteLine("Deseja continuar calculado com este resultado" +
                                   "\n Sim ou não");
                calculo = Console.ReadLine();

                if (calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero(resultado);
                }
            }
            // OPERAÇAO SUBTRACAO //
            else if (opera == '-')
            {

                Subtracao subtrair = new Subtracao();
                resultado = subtrair.Subtrair(numb, numb2);
                Console.WriteLine("Este e o resultado: " + resultado);

                Console.WriteLine("Deseja continuar calculado com este resultado" +
                                   "\n Sim ou não");
                calculo = Console.ReadLine();
                if (calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero(resultado);
                }
            }
            // OPERACAO MULTIPLICACAO //
            else if (opera == '*')
            {
                Multiplicacao multiplicacao = new Multiplicacao();
                resultado = multiplicacao.Multiplicar(numb, numb2);
                Console.WriteLine("Este e o resultado: " + resultado);

                Console.WriteLine("Deseja continuar calculado com este resultado" +
                                   "\n Sim ou não");
                calculo = Console.ReadLine();
                if (calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero(resultado);
                }
            }
            // OPERACAO DIVISAO //
            else
            {
                Divisao divisao = new Divisao();
                resultado = divisao.Dividir(numb, numb2);
                Console.WriteLine("Este e o resultado: " + resultado);

                Console.WriteLine("Deseja continuar calculado com este resultado" +
                                   "\n Sim ou não");
                calculo = Console.ReadLine();
                if (calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero(resultado);
                }
            }
        }



        public void OperacaoEscolhaUmNumero(Parametros parametros)
        {
            DigitaNumero digitaNumero = new DigitaNumero();

            float numb = parametros.Numero1;
            char opera = parametros.Operacao;
            float resultado = parametros.Resultado;
            //resultado = resultadoGlobal;

            // OPERAÇAO SOMA //
            if (opera == '+')
            {
                Soma soma = new Soma();
                Console.WriteLine("Este e o resultado: " + soma.SomarResultado(numb, resultado));

            }
            // OPERAÇAO SUBTRACAO //
            else if (opera == '-')
            {
                Subtracao subtrair = new Subtracao();
                Console.WriteLine("Este e o resultado: " + subtrair.SubtrairResultado(numb, resultado));
            }
            // OPERACAO MULTIPLICACAO //
            else if (opera == '*')
            {
                Multiplicacao multiplicacao = new Multiplicacao();
                Console.WriteLine("Este e o resultado: " + multiplicacao.MultiplicarResultado(numb, resultado));
            }
            // OPERACAO DIVISAO //
            else
            {
                Divisao divisao = new Divisao();
                Console.WriteLine("Este e o resultado: " + divisao.DividirResultado(numb, resultado));
            }
        }
    }
}

