using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu.Entities
{
    internal class Operacao
    {
        public void OperacaoEscolha(int numb, int numb2, char opera)
        {
            DigitaNumero digitaNumero = new DigitaNumero();

            string calculo;
            float resultado;

            // OPERAÇAO SOMA //
            if (opera == '+')
            {
                Soma soma = new Soma(numb, numb2);
                resultado = soma.Somar(numb, numb2);
                Console.WriteLine("Este e o resultado: " + resultado);

                Console.WriteLine("Deseja continuar calculado com este resultado"+
                                   "\n Sim ou não");
                calculo = Console.ReadLine();

                if (calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero();
                    Console.WriteLine("Este e o resultado: " + soma.SomarResultado(numb,0, resultado));
                }
                else
                {

                }
            }
            // OPERAÇAO SUBTRACAO //
            else if (opera == '-')
            {

                Subtracao subtrair = new Subtracao(numb, numb2);
                resultado = subtrair.Subtrair(numb, numb2);
                Console.WriteLine("Este e o resultado: " + resultado);

                Console.WriteLine("Deseja continuar calculado com este resultado" +
                                   "\n Sim ou não");
                calculo = Console.ReadLine();
                if (calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero();
                    Console.WriteLine("Este e o resultado: " + subtrair.SubtrairResultado(numb,0, resultado));
                }
            }
            // OPERACAO MULTIPLICACAO //
            else if (opera == '*')
            {
                Multiplicacao multiplicacao = new Multiplicacao(numb, numb2);
                resultado = multiplicacao.Multiplicar(numb, numb2);
                Console.WriteLine("Este e o resultado: " + resultado);

                Console.WriteLine("Deseja continuar calculado com este resultado" +
                                   "\n Sim ou não");
                calculo = Console.ReadLine();
                if (calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero();
                    Console.WriteLine("Este e o resultado: " + multiplicacao.MultiplicarResultado(numb,0, resultado));
                }
            }
            // OPERACAO DIVISAO //
            else
            {
                Divisao divisao = new Divisao(numb, numb2);
                resultado = divisao.Dividir(numb, numb2);
                Console.WriteLine("Deseja continuar calculado com este resultado" +
                                   "\n Sim ou não");
                calculo = Console.ReadLine();
                if(calculo == "sim" || calculo == "Sim")
                {
                    digitaNumero.DigitaUmNumero();
                    Console.WriteLine("Este e o resultado: " + divisao.DividirResultado(numb,0, resultado));
                }
            }
            }
        }
    }
