namespace Labs
{
    internal class Task5_2
    {
        static void Run()
        {
            string number = Console.ReadLine();
            CheckNumber(number);
        }
        static void CheckNumber(string number)
        {
            int sum = 0;
            if (true)
            {
                foreach (char c in number)
                {
                    sum += c - '0';
                }
                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("Невозможно");
            }

        }
    }
}
