using Question1;
using Question2;
using Question3;

namespace KoguiChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chamar a questão 1
            Console.WriteLine("--------------- Questão 1 ---------------\n");
            FirstQuestion.Executar();

            // Chamar a questão 2
            Console.WriteLine("\n--------------- Questão 2 ---------------\n");
            SecondQuestion hexa_sequence = new SecondQuestion();
            hexa_sequence.Executar().Wait(); 

            // Chamar a questão 3
            Console.WriteLine("\n--------------- Questão 3 ---------------\n");
            ThirdQuestion.Executar();
        }
    }
}