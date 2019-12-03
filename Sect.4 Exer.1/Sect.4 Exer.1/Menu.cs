using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._4_Exer._1
{
    class Menu
    {
        public int GetMenu()
        {
            while (true)
            {
                Console.WriteLine
                    ("Welcome to the junk stack! What would you like to do?\n\n" +
                     "1. Add to the junk stack \n" +
                     "2. Take from the junk stack \n" +
                     "3. Clear the stack\n" +
                     "4. View the stack\n" +
                     "5. Exit Program\n");

                var input = Console.ReadLine();
                Console.Clear();

                if (String.IsNullOrWhiteSpace(input))
                    throw new InvalidOperationException("Entry cannot be blank Chief!");

                try
                {
                    if ((Convert.ToInt32(input) < 1) ||
                        Convert.ToInt32(input) > 5)
                    {
                        Console.WriteLine("Invalid input. Please try again\n");
                        continue;
                    }

                    return Convert.ToInt32(input);

                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid Entry/ Can't convert to number. Please try again\n");
                    continue;
                }
            }
        }
    }
}
