using System;
					
public class Program
{
	public static void Main()
	{
		
		String name; //DECLARANDO A VARIAVEL NOME

        Console.WriteLine("Insira Seu Nome");// ESCREVA: "INSIRA SEU NOME"

        name = Console.ReadLine(); // A VARIÁVEL NOME RECEBE O VALOR DIGITADO PELO USUÁRIO

        Console.WriteLine("Bem Vindo: " + name); //EXIBE A MENSAGEM DE BOAS VINDAS COM O NOME
	}
}