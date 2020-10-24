using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero1, numero2, raiz;
            double result4, resultP, resultR;
            bool n1Valido, n2Valido, raizValido;
            string op, sair;

            do
            {
                Console.Clear();

                Console.WriteLine("Soma: +");
                Console.WriteLine("Subtração: -");
                Console.WriteLine("Multiplicação: *");
                Console.WriteLine("Divisão: /");
                Console.WriteLine("Potenciação: p");
                Console.WriteLine("Radiação (Raiz Quadrada): r\n");
                Console.Write("Escolha a Operação que Deseja Utilizar: ");
                op = Console.ReadLine().ToLower();

                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "p")
                {
                    Console.Clear();

                    Console.Write("Digite o 1ºNumero: ");
                    n1Valido = double.TryParse(Console.ReadLine(), out numero1);

                    Console.Write("Digite o 2º Número: ");
                    n2Valido = double.TryParse(Console.ReadLine(), out numero2);

                    switch (op)
                    {
                        case "+":
                            result4 = numero1 + numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado de Soma: {Math.Round(result4, 2)}");
                            break;

                        case "-":
                            result4 = numero1 - numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado de Subtração: {Math.Round(result4, 2)}");
                            break;

                        case "*":
                            result4 = numero1 * numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado de Multiplicação: {Math.Round(result4, 2)}");
                            break;

                        case "/":
                            result4 = numero1 / numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado da Divisão: {Math.Round(result4, 2)}");
                            break;

                        case "p":
                            Console.WriteLine();
                            resultP = numero1 * numero2 / 100;
                            Console.WriteLine($"Resultado de Porcentagem: {Math.Round(resultP, 2)}");
                            break;
                    }
                }
                else if (op == "r")
                {
                    Console.Clear();

                    Console.Write("Digite o Valor de Raiz Quadrada: ");
                    raizValido = double.TryParse(Console.ReadLine(), out raiz);
                    Console.WriteLine();

                    if (!raizValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    resultR = Math.Sqrt(raiz);
                    Console.WriteLine($"Sua Raiz Quadrada {raiz}");
                    Console.WriteLine($"É: {Math.Round(resultR, 2)}");
                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }

                Console.Write("Deseja Sair? S/N: ");
                sair = Console.ReadLine().ToUpper();
            }
            while (sair != "S" && sair != "SIM");
            {
                Console.WriteLine();
                Console.WriteLine("Obrigado Por Utilizar Meu Programa!");
            }
        }
    }
}