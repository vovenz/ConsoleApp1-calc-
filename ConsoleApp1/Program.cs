using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            int choice;

            do
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию '+'");
                Console.WriteLine("4. Выполнить операцию '-'");
                Console.WriteLine("5. Выполнить операцию '*'");
                Console.WriteLine("6. Выполнить операцию '/'");
                Console.WriteLine("0. Выйти");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите значение A: ");
                        a = double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Введите значение B: ");
                        b = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine($"Результат сложения: {a + b}");
                        break;
                    case 4:
                        Console.WriteLine($"Результат вычитания: {a - b}");
                        break;
                    case 5:
                        Console.WriteLine($"Результат умножения: {a * b}");
                        break;
                    case 6:
                        if (b != 0)
                        {
                            Console.WriteLine($"Результат деления: {a / b}");
                        }
                        else
                        {
                            Console.WriteLine("Деление на ноль невозможно.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }

            } while (choice != 0);

            Console.ReadKey();
        }
    }
}
