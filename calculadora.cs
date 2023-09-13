using System;
using System.Collections.Generic;

class Calculadora
{
    static void Main()
    {
        // Lista para armazenar as operações realizadas.
        List<string> operacoes = new List<string>();
        
        // Variável para armazenar o resultado final.
        double resultadoFinal = 0.0;

        while (true)
        {
            Console.WriteLine("Menu da Calculadora");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("5. Mostrar Todas as Operações");
            Console.WriteLine("6. Mostrar Resultado Final");
            Console.WriteLine("7. Sair");
            Console.Write("Digite sua escolha (1-7): ");

            int escolha;
            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira uma opção válida.");
                continue;
            }

            double numero1, numero2, resultado;
            char operador;
            string operacao;

            switch (escolha)
            {
                case 1:
                    operador = '+';
                    operacao = "Adição";
                    break;
                case 2:
                    operador = '-';
                    operacao = "Subtração";
                    break;
                case 3:
                    operador = '*';
                    operacao = "Multiplicação";
                    break;
                case 4:
                    operador = '/';
                    operacao = "Divisão";
                    break;
                case 5:
                    // Chama a função para mostrar todas as operações.
                    MostrarTodasOperacoes(operacoes);
                    continue;
                case 6:
                    // Mostra o resultado final.
                    Console.WriteLine($"Resultado Final: {resultadoFinal}");
                    continue;
                case 7:
                    // Encerra o programa e mostra todas as operações realizadas.
                    Console.WriteLine("Encerrando a calculadora.");
                    MostrarTodasOperacoes(operacoes);
                    return;
                default:
                    Console.WriteLine("Escolha inválida. Por favor, insira uma opção válida.");
                    continue;
            }

            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                continue;
            }

            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero!");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido!");
                    continue;
            }

            // Adiciona a operação realizada à lista de operações.
            operacoes.Add($"{operacoes.Count + 1}. {numero1} {operador} {numero2} = {resultado}");
            
            // Atualiza o resultado final.
            resultadoFinal = resultado;

            // Mostra o resultado da operação atual.
            Console.WriteLine($"{operacao} resultado: {numero1} {operador} {numero2} = {resultado}\n");
        }
    }

    // Função para mostrar todas as operações realizadas.
    static void MostrarTodasOperacoes(List<string> operacoes)
    {
        Console.WriteLine("Todas as Operações:");
        foreach (string op in operacoes)
        {
            Console.WriteLine(op);
        }
        Console.WriteLine();
    }
}