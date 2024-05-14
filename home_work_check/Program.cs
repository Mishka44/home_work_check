using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_check
{
    internal class Program
    {
        delegate void Output(string _first, string _second, bool append);
        static int GetNumber(string  text = "введите число")
        {
            int result = 0;
            string temp = "";
            do
            {
                Console.WriteLine("введите начало диапозона");
                temp = Console.ReadLine();
            } while (!int.TryParse(temp, out result));
            return result;
        }
        static void Correcting(ref int first, ref int second)
        {
            if (first > second)
            {
                int tmp = first;
                first = second;
                second = tmp;
            }
            
            
        }

        static string MultiTable(int start, int finish)
        {
            string result = "", br = "\r\n";
            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    result += $"{i} * {j} = {i * j}\t";
                }
                result += br;
            }
            result += br;
            return result;
        }

        static void Main(string[] args)
        {
            string filename ="";
            int first = 0, second = 0;
            Console.WriteLine($"{args[0]} {args[1]} {args[2]}");
            Output print;
            print = FileID.WriteToFile;
            // Использование анонимного метода и синтаксиса лямбда-выражений
            // print += myPrint;
            print += (path, content, append) => { Console.WriteLine(content); };
            if (args.Length >= 3)
            {
                filename = args[0];
                if (!int.TryParse(args[1], out first)){

                    first = GetNumber("введите начало диапозона");
                    
                } 
                if (!int.TryParse(args[2], out second))
                {
                    second = GetNumber("введите конец диапозона");
                }
                

            }
            else
            {
                Correcting(ref first, ref second);
            }
            print?.Invoke(filename, MultiTable(first, second), true);


        }
    }
}
