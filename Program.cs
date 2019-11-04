using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var pp = new Program();

            List<string> myArray = new List<string>();
            string input = string.Empty;
            var count = 0;
            while (true)
            {
                count++;
                Console.Write($"{count} : ");
                input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    myArray.Add(input);
                }
            }

            // iteracja przez tablicę
            Console.WriteLine("Result : ");
            int countOpened = 0;
            int countClosed = 0;

            int[] counter = new int[myArray.Count];
            var info = string.Empty;
            foreach (var item in myArray)
            {

                char[] checkChar = item.ToCharArray();
                foreach (char c in checkChar)
                {
                    if (c == '(')
                        countOpened++;

                    if (c == ')')
                        countClosed++;
                }
                info = pp.GetResult(pp.checkTwoNumbers(countClosed, countOpened));
                Console.WriteLine($" : {item} | opened : {countOpened} | closed : {countClosed} | info : {info}");
             
                countOpened = 0;
                countClosed = 0;
                
            }
                Console.ReadKey();
            }

       public string  GetResult(bool status)
        {
            if (status)
            {
                return "Poprawne rozmieszczenie";
            }
            else
            {
                return "Nieprawne rozmieszczenie";
            }
        }
         public bool checkTwoNumbers(int x , int y)
        {
            if (x == y) { return true; } else { return false; }

        }

        }
    }

