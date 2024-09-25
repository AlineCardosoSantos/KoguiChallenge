using Services;
using Question1;

namespace Question2
{
    public class SecondQuestion
    {
        public async Task Executar()
        {
            ColorService colorService = new ColorService();
            string[] hexColors = { "#0000FF", "#00FF00", "#FFFFFF", "#FF0000", "#FFA500", "#FFFF00", "#000000" };

            int larguraColunaCor = 15;
            int larguraColunaHex = 10;

            // Cabeçalho
            Console.WriteLine($"{ "Cor".PadRight(larguraColunaCor) } | { "Hex".PadRight(larguraColunaHex) }");
            Console.WriteLine(new string('-', larguraColunaCor + larguraColunaHex + 6));

            // Conteúdo
            foreach (string hex in hexColors)
            {
                try
                {
                    string nomeCor = await colorService.GetColorNameByHex(hex);
                    Console.WriteLine($"{ nomeCor.PadRight(larguraColunaCor) } | { hex.PadRight(larguraColunaHex)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao processar a cor {hex}: {ex.Message}");
                }
            }

            // Gerar a frase a partir dos componentes
            string frase = string.Join(" ", FirstQuestion.ListaCores
                .Where(c => c.Componente != "(vazio)" &&  hexColors.Contains(c.Hex))
                .Select(c => c.Componente.Trim()));

            Console.WriteLine("\nFrase gerada:");
            Console.WriteLine(frase);
        }
    }
}
