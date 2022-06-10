using System;
using Thread = System.Threading.Thread;
using File = System.IO.File;

namespace Brute
{
    public class Program
    {

        static void brute(string message)
        {
            var rand = new Random();
            char[] targetArray = message.ToCharArray();
            string[] stringArray = new string[targetArray.Length];
            int i = 0;
            while (i < targetArray.Length)
            {
                var currentChar = Convert.ToChar(rand.Next(32, 126));
                Console.Write(currentChar);
                if (currentChar == targetArray[i])
                {
                    Console.Write(" ");
                    ++i;
                }
                Console.Write(String.Join("", stringArray));
                Console.Write("\b");
                Thread.Sleep(5);
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("2 Arguments are required: provide '-m' or '-f' along with a message or file respectively");
            }

            else
            {
                string flag = args[0];
                if (flag == "-m")
                {
                    string text = args[1];
                    brute(text);
                }

                else if (flag == "-f")
                {
                    char[] toTrim = {'\n', '\r'};
                    string f = args[1];
                    string fileText = File.ReadAllText(@f);
                    fileText = fileText.Trim(toTrim);
                    brute(fileText);
                }

                else
                {
                    Console.WriteLine("The flag was not recognised, much like the confederate flag");
                }
            }
        }
    }
}
