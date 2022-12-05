using System;
using System.Collections.Generic;
using static MediaAritimetica.Utilidades.UtilidadesAritimetica;

namespace MediaAritimetica
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            int[] Tabela = { 1,2,3,4,5,6 };
            List<int> novaTabela = new List<int>(); //Gerar uma nova tabela
            double resultado = 0;
            
            /*
             * 0 < Número de Itens da Tabela fornecida <= 100. Caso o número de itens estiver fora do limite,
             * a função deverá retornar -1 antes de executar o algoritmo;
             */
            
            if (TabelaExcedeLimite(Tabela)) return -1;

            foreach (int numero in Tabela)
            {
                // Gerar uma nova tabela, excluindo números primos e valores negativos da tabela fornecida
                bool validaNumero = NumeroEPositivo(numero) && !NumeroEPrimo(numero);
                if (validaNumero)
                {
                    novaTabela.Add(numero);
                }
            }

            foreach (int numero in novaTabela)
            {
                resultado += numero;
            }

            resultado /= novaTabela.Count;
            Console.WriteLine("O resultado é :" + resultado);

            return 1;




            


        }
    }
}