namespace Question3
{
    class ThirdQuestion
    {
        public static void Executar()
        {
            string matrizPath = "./MATRIZ.txt";
            string matrizConteudo = File.ReadAllText(matrizPath).Replace("\r\n", "");

            int colunas = 101;

            for (int i = 0; i < matrizConteudo.Length; i++)
            {
                char simbolo = (int)char.GetNumericValue(matrizConteudo[i]) % 2 == 0 ? '#' : ' ';
                
                Console.Write(simbolo);

                if ((i + 1) % colunas == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\nUma xícara de café!!!!!!");
        }
    }
}
