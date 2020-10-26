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

            double A, B, C;
            double Delta, X1, X2;
            bool aValido, bValido, cValido;

            double ladoA, ladoB, ladoC;
            double resultSP, resultA;
            bool laValido, lbValido, lcValido;

            double Base, Altura, Area;
            bool baseValido, alturaValido;

            double N1, N2, N3, N4, resultMedia;
            bool nota1Valido, nota2Valido, nota3Valido, nota4Valido;

            double alturaI, pesoI, IMC;
            bool alturaIValido, pesoIValido;

            double Cels1, Cels2;
            double Fahren1, Fahren2;
            bool celsiusValido;

            int distancia, tempo, velocidade;
            bool distanciaValido, tempoValido;

            string op, sair;

            do
            {
                Console.Clear();

                Console.WriteLine("<------Calculadora Simples------>\n");

                Console.WriteLine("<------Operações Basicas------>");
                Console.WriteLine("Soma: +");
                Console.WriteLine("Subtração: -");
                Console.WriteLine("Multiplicação: *");
                Console.WriteLine("Divisão: /");
                Console.WriteLine("Potenciação: P");
                Console.WriteLine("Radiação (Raiz Quadrada): R\n");

                Console.WriteLine("<------Operações Adicionais (Bonus)------>");
                Console.WriteLine("Bhaskara: B");
                Console.WriteLine("Heron: H");
                Console.WriteLine("Area do Triangulo: A");
                Console.WriteLine("Média: M");
                Console.WriteLine("IMC: I");
                Console.WriteLine("Graus Cº (Celsius): C");
                Console.WriteLine("Graus Fº (Fahrenheit): F");
                Console.WriteLine("Velocidade Media: V");
                Console.Write("\n");
                Console.Write("Escolha a Operação que Deseja Utilizar: ");
                op = Console.ReadLine().ToUpper();

                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "P")
                {
                    Console.Clear();

                    Console.Write("Digite o 1ºNumero: ");
                    n1Valido = double.TryParse(Console.ReadLine(), out numero1);

                    if (!n1Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o 2º Número: ");
                    n2Valido = double.TryParse(Console.ReadLine(), out numero2);

                    if (!n2Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

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

                        case "P":
                            Console.WriteLine();
                            resultP = numero1 * numero2 / 100;
                            Console.WriteLine($"Resultado de Porcentagem: {Math.Round(resultP, 2)}");
                            break;
                    }
                }
                else if (op == "R")
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
                    Console.WriteLine($"Raiz Quadrada de {raiz}");
                    Console.WriteLine($"É: {Math.Round(resultR, 2)}");
                    Console.WriteLine();
                }
                else if (op == "B")
                {
                    Console.Clear();
                    Console.Write("Digite o Valor de A: ");
                    aValido = double.TryParse(Console.ReadLine(), out A);

                    if (!aValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o Valor de B: ");
                    bValido = double.TryParse(Console.ReadLine(), out B);

                    if (!bValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o Valor de C: ");
                    cValido = double.TryParse(Console.ReadLine(), out C);

                    if (!cValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Delta = Math.Pow(B, 2) - 4 * A * C;
                    X1 = (-B + Math.Sqrt(Delta)) / 2 * A;
                    X2 = (-B - Math.Sqrt(Delta)) / 2 * A;

                    if (A == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Não é uma equação do segundo grau!");
                    }
                    else if (Delta < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Como Delta é = -8,00, a equação não possui raizes reais!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("O resultado de x1 é: ");
                        Console.WriteLine(Math.Round(X1, 2));

                        Console.Write("O resultado de x2 é: ");
                        Console.WriteLine(Math.Round(X2, 2));
                    }
                }
                else if (op == "H")
                {
                    Console.Clear();

                    Console.Write("Digite o Valor de A: ");
                    laValido = double.TryParse(Console.ReadLine(), out ladoA);

                    if (!laValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o Valor de B: ");
                    lbValido = double.TryParse(Console.ReadLine(), out ladoB);

                    if (!lbValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o Valor de C: ");
                    lcValido = double.TryParse(Console.ReadLine(), out ladoC);
                    Console.WriteLine();

                    if (!lcValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    resultSP = (ladoA + ladoB + ladoC) / 2;
                    resultA = Math.Sqrt(resultSP * (resultSP - ladoA) * (resultSP - ladoB) * (resultSP - ladoC));

                    Console.WriteLine("Semiperímetro = {0}", resultSP);
                    Console.WriteLine("Area = {0}(cm²)", resultA);
                    Console.WriteLine();
                }
                else if (op == "A")
                {
                    Console.Clear();

                    Console.Write("Digite o Valor da Base (cm): ");
                    baseValido = double.TryParse(Console.ReadLine(), out Base);

                    Console.Write("Digite o Valor da Altura (cm): ");
                    alturaValido = double.TryParse(Console.ReadLine(), out Altura);
                    Console.Write("\n");

                    Area = Base * Altura / 2;
                    Console.WriteLine($"A area do triangulo retangulo é: {Area}(cm²)");
                }
                else if (op == "M")
                {
                    Console.Clear();

                    Console.Write("Digite a 1ºNota: ");
                    nota1Valido = double.TryParse(Console.ReadLine(), out N1);

                    if (!nota1Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    if (N1 < 0 || N1 > 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite somente números de 0 a 10");
                        Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite a 2ºNota: ");
                    nota2Valido = double.TryParse(Console.ReadLine(), out N2);

                    if (!nota2Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    if (N2 < 0 || N2 > 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite somente números de 0 a 10");
                        Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite a 3ºNota: ");
                    nota3Valido = double.TryParse(Console.ReadLine(), out N3);

                    if (!nota3Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    if (N3 < 0 || N3 > 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite somente números de 0 a 10");
                        Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite a 4ºNota: ");
                    nota4Valido = double.TryParse(Console.ReadLine(), out N4);

                    if (!nota4Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }
                    if (N4 < 0 || N4 > 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite somente números de 0 a 10");
                        Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    resultMedia = (N1 + N2 + N3 + N4) / 4;
                    if (resultMedia >= 7)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sua media final é de {Math.Round(resultMedia, 1)}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Então você foi APROVADO!");
                        Console.ResetColor();
                    }
                    else if (resultMedia >= 5 && resultMedia <= 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sua media final é de {Math.Round(resultMedia, 1)}");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Então você ficou de RECUPERAÇÃO!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sua media final é de {Math.Round(resultMedia, 1)}");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Então você foi REPROVADO!");
                        Console.ResetColor();
                    }
                }
                else if (op == "I")
                {
                    Console.Clear();

                    Console.Write("Digite sua Altura(m): ");
                    alturaIValido = double.TryParse(Console.ReadLine(), out alturaI);

                    if (!alturaIValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite seu Peso(kg): ");
                    pesoIValido = double.TryParse(Console.ReadLine(), out pesoI);
                    Console.WriteLine();

                    if (!pesoIValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    IMC = pesoI / (alturaI * alturaI);
                    Console.Write("Seu IMC é: ", IMC);

                    if (IMC < 17)
                    {
                        Console.WriteLine(Math.Round(IMC, 2));
                        Console.WriteLine("Você está muito abaixo do peso ideal");

                    }
                    if (IMC >= 17 && IMC <= 18.49)
                    {
                        Console.WriteLine(Math.Round(IMC, 2));
                        Console.WriteLine("Você está abaixo do peso ideal");
                    }
                    if (IMC >= 18.5 && IMC <= 24.99)
                    {
                        Console.WriteLine(Math.Round(IMC, 2));
                        Console.WriteLine("Você está com peso ideal");
                    }
                    if (IMC >= 25 && IMC <= 29.99)
                    {
                        Console.WriteLine(Math.Round(IMC, 2));
                        Console.WriteLine("Você está acima do peso ideal");
                    }
                    if (IMC >= 30 && IMC <= 34.99)
                    {
                        Console.WriteLine(Math.Round(IMC, 2));
                        Console.WriteLine("Você está com obesidade I");
                    }
                    if (IMC >= 35 && IMC <= 39.99)
                    {
                        Console.WriteLine(Math.Round(IMC, 2));
                        Console.WriteLine("Você está com obesidade II (severa)");
                    }
                    if (IMC >= 40)
                    {
                        Console.WriteLine(Math.Round(IMC, 2));
                        Console.WriteLine("Você está com obesidade III (mórbida)");
                    }
                }
                else if (op == "C")
                {
                    Console.Clear();

                    Console.Write("Digite seu Valor Fahrenheit: ");
                    Fahren2 = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Cels2 = (Fahren2 - 32) / 1.8;
                    Console.WriteLine($"Seu valor de Fahrenheit {Fahren2}Fº convertido para Celsius é: {Cels2}Cº");
                }
                else if (op == "F")
                {
                    Console.Clear();

                    Console.Write("Digite seu Valor em Celsius: ");
                    celsiusValido = double.TryParse(Console.ReadLine(), out Cels1);
                    Console.WriteLine();

                    if (!celsiusValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Fahren1 = Cels1 * 1.8 + 32;
                    Console.WriteLine($"Seu valor de Celsius {Cels1}Cº convertido para Fahrenheit é: {Fahren1}Fº");
                }
                else if (op == "V")
                {
                    Console.Clear();

                    Console.Write("Digite seu Valor Distancia (m): ");
                    distanciaValido = int.TryParse(Console.ReadLine(), out distancia);

                    if (!distanciaValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite seu Valor Tempo (s): ");
                    tempoValido = int.TryParse(Console.ReadLine(), out tempo);
                    Console.Write("\n");

                    if (!tempoValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    velocidade = distancia / tempo;
                    Console.WriteLine("Sua Velocidade Média é = {0} m/s", velocidade);
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