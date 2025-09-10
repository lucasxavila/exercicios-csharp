namespace fundamentosCsharp;

class Exercicio2
{
    public void Executar()
    {
        Console.Write("Digite seu primeiro nome: ");
        string primeiroNome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine(primeiroNome + " " + sobrenome);
    }
}