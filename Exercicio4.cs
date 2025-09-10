namespace fundamentosCsharp;

class Exercicio4
{
    public void Executar()
    {
        Console.Write("Digite uma palavra ou uma frase: ");
        string caracteres = Console.ReadLine();

        int quantidadeDeCaracteres = caracteres.Count(c => char.IsLetterOrDigit(c));
        Console.WriteLine($"A quantidade de caracteres é: {quantidadeDeCaracteres}.");
    }
}