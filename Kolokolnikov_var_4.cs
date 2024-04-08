namespace ConsoleApp1
{
    internal class Kolokolnikov_var_4
    {
        static void Main (string[] args)
        {
            // Leap year check
            Console.Write("Enter the year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                return;
            }
            bool isLeapYear = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
            Console.WriteLine($"{year} is {(isLeapYear ? "" : "not ")}a leap year.");


            // Output all prime numbers up to the specified number (not including)
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int end))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            if (end < 3) return;
            for (int i = 2; i < end; i++)
            {
                for (int ch_num = 2; ch_num <= 9; ch_num = ch_num != 4 ? ch_num + 2 : 3)
                {
                    if (i != ch_num && i % ch_num == 0) break;
                    if (ch_num == 9) Console.Write($"{i} ");
                }
            }
        }
    }
}


