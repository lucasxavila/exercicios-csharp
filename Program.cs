namespace fundamentosCsharp;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercício Um\n");
        var exercicio1 = new ExercicioUm();
        exercicio1.Executar();

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("Exercício Dois\n");
        var exercicio2 = new ExercicioDois();
        exercicio2.Executar();

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("Exercício Três\n");
        var exercicio3 = new ExercicioTres();
        exercicio3.Executar();
    }
}