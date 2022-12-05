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
    }
}