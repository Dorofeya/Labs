using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class Task5_1
    {
        public static void Main()
        {
            string b = "5";
            while (true)
            {
                var a = Console.ReadLine();
                if (a == "q")
                {
                    break;
                }
                else if (int.TryParse(a, out var result))
                {
                    Console.WriteLine((char)result);
                }
                else if (float.TryParse(a, out var result2))
                {

                    if (Math.Abs(result2 - float.Parse(b)) < 0.0001)
                    {
                        break;
                    }
                }
                b = a;
            }
        }
    }
}
