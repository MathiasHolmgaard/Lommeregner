using System.ComponentModel;

namespace Lommeregner
{
    internal class Program
        /* Jeg skal finde ud af hvordan jeg kalder metoder fra klassen Calculator*/
    {

        static void Main(string[] args)
        {
            {
                while (true)
                {
                    double num1, num2;
                    char op;

                    Console.Write("Indtast første tal: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Indsæt tegn: ");
                    op = Convert.ToChar(Console.ReadLine());

                    Console.Write("Indtast næste tal: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (op)
                    {
                        case '+':
                            Console.WriteLine(num1 + num2);
                            break;
                        case '-':
                            Console.WriteLine(num1 - num2);
                            break;
                        case '*':
                            Console.WriteLine(num1 * num2);
                            break;
                        case '/':
                            Console.WriteLine(num1 / num2);
                            break;
                        default:
                            Console.WriteLine("Ugyldigt tegn!");
                            break;
                    }
                    Console.WriteLine("Tryk ENTER for at prøve igen");
                    Console.ReadLine();
                }
            }
        }
    }
}
