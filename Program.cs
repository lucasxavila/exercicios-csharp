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
    }
}