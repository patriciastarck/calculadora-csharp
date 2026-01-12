// See https://aka.ms/new-console-template for more information
using System;


		
		Console.WriteLine("Digite o primeiro número:");
		
		int numero1 = int.Parse(Console.ReadLine());		

		
		Console.WriteLine("Digite a operação (+, -, *, /):");
		string operacao = Console.ReadLine();


		Console.WriteLine("Digite o segundo número:");
		int numero2 = int.Parse(Console.ReadLine());

if (operacao == "+")
		{
			int resultado = numero1 + numero2;
			Console.WriteLine("O resultado da soma é: " + resultado);
		}
		else if (operacao == "-")
		{
			int resultado = numero1 - numero2;
			Console.WriteLine("O resultado da subtração é: " + resultado);
		}
		else if (operacao == "*")
		{
			int resultado = numero1 * numero2;
			Console.WriteLine("O resultado da multiplicação é: " + resultado);
		}
		else if (operacao == "/")
		{
			int resultado = numero1 / numero2;
			Console.WriteLine("O resultado da divisão é: " + resultado);
		}

		// Esperar o usuário ler antes de fechar
		Console.WriteLine("Pressione qualquer tecla para sair...");
		Console.ReadKey();
