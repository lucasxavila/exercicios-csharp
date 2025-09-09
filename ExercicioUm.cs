namespace fundamentosCsharp;

class ExercicioUm
{
    public void Executar()
    {
        Console.Write("Digite seu primeiro nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"0lá, {nome}! Seja muito bem-vindo!");
        Console.ReadKey();
    }
}