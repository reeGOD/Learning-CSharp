using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criando Variaveis");
        
        int idade;
        idade = 21;

        Console.WriteLine("Minha idade é: " + idade);

        idade = 21 + 22;

        Console.WriteLine("Idade da minha mãe é: " + idade);

        idade = idade - 10;

        Console.WriteLine("Idade da minha irmã é: " + idade);

        idade = idade * 2;

        Console.WriteLine("Idade do meu pai é: " + idade);

        idade = (idade * 2) + 20;

        Console.WriteLine("Idade do meu vô é: " + idade);

        Console.WriteLine("Enter para fechar");
        Console.ReadLine();
    }
}

