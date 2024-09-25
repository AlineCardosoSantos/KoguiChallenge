using System;
using System.Collections.Generic;

namespace Question1
{
    public class ChaveCor
    {
        public string Hex { get; set; }                     // Armazenar o código hexadecimal da cor
        public string Cor { get; set; }                     // Armazenar o nome da cor
        public string Componente { get; set; }              // Armazenar o componente relacionado à cor

        // Construtor para inicializar a classe
        public ChaveCor(string hex, string cor, string componente)
        {
            Hex = hex;
            Cor = cor;
            Componente = componente;
        }
    }

    public static class FirstQuestion
    {
        public static List<ChaveCor> ListaCores { get; private set; }

        static FirstQuestion()
        {
            ListaCores = new List<ChaveCor>()
            {
                new ChaveCor("#FF00FF", "MagentaFuchsia", "(vazio)"),
                new ChaveCor("#FFFFFF", "White", "para"),
                new ChaveCor("#0000FF", "Blue", "Pares"),
                new ChaveCor("#008000", "Green", "alterar"),
                new ChaveCor("#000000", "Black", "#"),
                new ChaveCor("#FFA500", "WebOrange", "e"),
                new ChaveCor("#FFFF00", "Yellow", "impares"),
                new ChaveCor("#FF0000", "Red", "\"\""),
                new ChaveCor("#FFE5B4", "Coconut", "Busca"),
                new ChaveCor("#00FFFF", "CyanAqua", "primos")
            };
        }

        public static void Executar()
        {
            int larguraColunaCor = 15;
            int larguraColunaHex = 10;
            int larguraColunaComponente = 12;

            // Cabeçalho
            Console.WriteLine($"{ "Cor".PadRight(larguraColunaCor) } | { "Hex".PadRight(larguraColunaHex) } | { "Componente".PadRight(larguraColunaComponente) }");
            Console.WriteLine(new string('-', larguraColunaCor + larguraColunaHex + larguraColunaComponente + 6));

            // Conteúdo
            foreach (var cor in ListaCores)
            {
                Console.WriteLine($"{ cor.Cor.PadRight(larguraColunaCor) } | { cor.Hex.PadRight(larguraColunaHex) } | { cor.Componente.PadRight(larguraColunaComponente) }");
            }
        }
    }
}
