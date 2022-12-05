using System;
using System.Collections.Generic;

namespace MediaAritimetica.Utilidades
{
    public static class UtilidadesAritimetica
    {
        
        public static bool NumeroEPrimo(int numero)
        {
            for (int i = 2; i <= numero/2; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool NumeroEPositivo(int numero)
        {
            return (numero >= 0);
        }

        public static bool TabelaExcedeLimite(int[] tabela)
        {
            if (0 < tabela.Length || tabela.Length <= 100) return false;
            return true;
        }

        public static double TabelaMediaAritimetica(int[] tabela)
        {
            double resultado = 0;
            foreach (int numero in tabela)
            {
                resultado += numero;
            }
            resultado /= tabela.Length;
            return resultado;
        }
        public static double MediaAritmeticaGestal(int[] Tabela)
        {
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

            return resultado;
        }
    }
    
}

