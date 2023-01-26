namespace Labs
{
    internal class Task5_4
    {
        static void Run()
        {
            string[] array = new string[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            PrintArray(array);
            string[] array2 = ChangeArray(array);
            PrintArray(array2);
        }

        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static string[] ChangeArray(string[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out int result))
                {
                    if (result > 0)
                    {
                        array[i] = Factorial(result).ToString();
                    }

                }

                else if (double.TryParse(array[i], out double result2))
                {
                    result2 = Math.Round(result2, 2);
                    string[] parts = result2.ToString().Split(',');
                    array[i] = parts[1];
                }
            }
            return array;
        }


        static long Factorial(int i)
        {
            if (i == 1) return 1;
            return i * Factorial(i - 1);
        }
    }
}
