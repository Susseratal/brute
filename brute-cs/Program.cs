using System;
using Thread = System.Threading.Thread;

namespace Brute
{
    public class Program
    {
        var rand = new Random();

        static void brute(string message)
        {
            char[] targetArray = message.ToCharArray();
            string[] stringArray = ([""] * targetArray.Length);
            int i = 0;
            while (i < targetArray.Length)
            {
                char stringArray[i] = char(rand.Next(32, 126));
                if (stringArray[i] == targetArray[i])
                {
                    ++i;
                }
                else
                {
                    // Console.WriteLine("".Join(stringArray), );
                }
            }
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("2 Arguments are required: Please provide either the '-m' or '-f' flag for a message or file");
            }

            else if (args.Length == 1)
            {
                Console.WriteLine("2 Arguments are required: Please provide a message or filename");
            }

            else
            {
                Console.WriteLine(args.Length);
                string flag = args[0];
                if (flag == "-m")
                {
                    string text = args[1];
                    brute(text);
                }

                else if (flag == "-f")
                {
                    // read a file
                }
            }
        }
    }
}
