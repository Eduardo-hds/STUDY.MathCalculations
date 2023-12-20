using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosMatematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continueLoop = "n";
            do
            {
                Console.Clear();

                Console.WriteLine("Sistema matemático");
                Console.WriteLine("Para calcular o fatorial (1)");
                Console.WriteLine("Para calcular a média (2)");
                Console.WriteLine("Para saber se o numero é impar ou par (3)");
                Console.WriteLine("Para saber se os numeros formar um triangulo (4)");
                Console.WriteLine("Para saber a porcentagem requirida(5)");

                int selection = 0;

                Console.WriteLine("Digite o número do sistema desejado:");
                selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 1)
                {
                    Factorial();


                }
                else if (selection == 2)
                {
                    NumberAvarage();

                }
                else if (selection == 3)
                {
                    OddEven();
                }
                else if (selection == 4)
                {
                    Triangle();

                }
                else if (selection == 5)
                {
                    Percentage();
                }

                Console.WriteLine("Deseja fazer outro calculo? (s/n)");
                continueLoop = Console.ReadLine().ToLower();

            } while (continueLoop == "s" );
        }

        //Functios
        
        static void Factorial()
        {

            Console.WriteLine("Informe um número para ser feito o fatorial!");
            int number = Convert.ToInt32(Console.ReadLine());

            int finalResult = 1;

            for (int i = number; i >= 1; i--) 
            { 
                finalResult *= i;

            }

            Console.WriteLine("O fatorial de {0} é {1}.",number ,finalResult);
        }
        
        static void NumberAvarage()
        {
            string continueLoop = "n";

            double result = 0;
            double number;
            int total = 0;

            do
            {
                Console.WriteLine("Digite um número para fazer a média:");
                number = Convert.ToInt32(Console.ReadLine());

                result += number;

                total++;

                Console.WriteLine("Deseja adicionar mais um número? (s/n)");
                continueLoop = Console.ReadLine().ToLower();


            } while (continueLoop.ToLower() == "s");

            number = result / total;

            Console.WriteLine("A média dos números digitados é de {0}.",number);

        }

        static void OddEven()
        {
            int number;
            int result;

            Console.WriteLine("Digite o número que deseja saber se é impar ou par.");
            number = Convert.ToInt32(Console.ReadLine()); 

            result = number % 2;

            if (result > 0)
            {
                Console.WriteLine("O número é impar");
            } else
            {
                Console.WriteLine("O número é par");
            }
        }
        
        static void Triangle()
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Digite o valor do lado A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C:");
            c = Convert.ToInt32(Console.ReadLine());

            if((a + b > c) && (b + c > a) && (c + a > b))
            {
                Console.WriteLine("Os números digitados {0}, {1}, {2} podem formar um triangulo!",a,b,c);
            } else { Console.WriteLine("Os números digitados {0}, {1} ,{2} não podem formar um triangulo!",a,b,c);}
        }

        static void Percentage()
        {
            int intNumber;
            int percentage;
            int result;

            Console.WriteLine("Digete o número inteiro:");
            intNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digete a porcentagem a ser acahada:");
            percentage = Convert.ToInt32(Console.ReadLine());

            result = (intNumber * percentage) / 100;

            Console.WriteLine("{0}% de {1} é igual a: {2}", percentage, intNumber, result);

        }
    }
}
