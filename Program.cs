namespace fundamentosCsharp;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercício Um\n");
        var exercicio1 = new Exercicio1();
        exercicio1.Executar();

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("Exercício Dois\n");
        var exercicio2 = new Exercicio2();
        exercicio2.Executar();

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("Exercício 3\n");
        var exercicio3 = new Exercicio3();
        exercicio3.Executar();

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("Exercício 4\n");
        var exercicio4 = new Exercicio4();
        exercicio4.Executar();

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("Exercício 5\n");
        var exercicio5 = new Exercicio5();
        exercicio5.Executar();

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("Exercício 6\n");
        var exercicio6 = new Exercicio6();
        exercicio6.Executar();

        Console.ReadKey();
    }
}