using System;
using System.Collections.Generic;

namespace MediaAritimetica.Utilidades
{
    public static class UtilidadesAritimetica
    {
        
        /// <summary>
        /// Verifica se o numero é primo
        /// </summary>
        /// <param name="numero"> Numero inteiro (int) </param>
        /// <returns>Retorna true se for, se não false</returns>
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
        /// <summary>
        /// Verifica se numero é positivo
        /// </summary>
        /// <param name="numero"> Numero inteiro (int)</param>
        /// <returns> Retorna true se sim, false se não </returns>
        public static bool NumeroEPositivo(int numero)
        {
            return (numero >= 0);
        }
        /// <summary>
        /// Verifica se tabela excede o limite de 100 elementos
        /// </summary>
        /// <param name="tabela"> Conjunto de elementos do tipo inteiro </param>
        /// <returns> Retorna true se sim, false se não</returns>
        public static bool TabelaExcedeLimite(int[] tabela)
        {
            if (0 < tabela.Length || tabela.Length <= 100) return false;
            return true;
        }
        /// <summary>
        /// Calcula media aritimética de todos numeros inteiros contidos em uma tabela exceto numeros negativos e primos
        /// </summary>
        /// <param name="Tabela">Tabela de numeros inteiros</param>
        /// <returns>Media aritimetica</returns>
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

