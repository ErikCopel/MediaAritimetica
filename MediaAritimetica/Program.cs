using System;
using System.Collections.Generic;
using static MediaAritimetica.Utilidades.UtilidadesAritimetica;

namespace MediaAritimetica
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] Tabela = { 987, 236, 547, 72, 138, 790, 83, -435, 234, 34 };
            
            Console.WriteLine("Media Aritimetica Tabela: " + MediaAritmeticaGestal(Tabela));
            

        }
    }
}