namespace fundamentosCsharp;

class Exercicio1
{
    public void Executar()
    {
        Console.Write("Digite seu primeiro nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"0l�, {nome}! Seja muito bem-vindo!");
        Console.ReadKey();
    }
}