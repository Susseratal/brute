using System;
using Thread = System.Threading.Thread;

namespace Processor
{
    public class Program
    {
        var rand = new Random();
        string[] targetArray = ["H", "e" "l", "l", "o", ",", " ", "w", "o", "r", "l", "d"];
        string[] stringArray = ["", "" "", "", "", "", "", "", "", "", "", ""];
        int i = 0;

        static void Main()
        {
            while (i < targetArray.Length)
            {
                if (stringArray[i] != targetArray[i])
                {
                    stringArray[i] = Convert.ToChar(rand.Next(32, 126));
                }

                else if (stringArray[i] == targetArray[i])
                {
                    ++i;
                }
            }
        }
    }
}
