class Program
{
    static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("-ANEL DE CORAÇÃO-");
        Console.ResetColor();
        Console.Write("");
        Thread.Sleep(2000);
        Console.Write("Quantos elementos da sequência deseja exibir? ");

        if (int.TryParse(Console.ReadLine(), out int quantidade) && quantidade > 0)
        {
            ExibirSequenciaTriangular(quantidade);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro positivo (Ex. 1,2,3...).");
            Console.ResetColor();
        }
    }
    static void ExibirSequenciaTriangular(int n)
    {
        int eventos = 0;
        int dificuldade = 1;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Thread.Sleep(1500);
        Console.WriteLine($"\n{n} primeiros elementos da sequência:");
        Console.ResetColor();
        for (int i = 0; i < n; i++)
        {

            Thread.Sleep(500);
            eventos += dificuldade;
            Console.Write(eventos + (i < n - 1 ? " " : "\n"));
            dificuldade++;
        }
    }
}
