using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._4_Exer._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Stackclass stackClass = new Stackclass();
            Menu menu = new Menu();
            string result = "";


            while (result != "exit")
            {
                var selection = menu.GetMenu();

                if ((selection == 2) && (stack.Count == 0))
                    throw new InvalidOperationException("You can't 'Pop' something if it ain't there pal!");

                result = stackClass.ChangeStack(selection, stack);

                if (result != "exit")
                {
                    Console.WriteLine(result + "\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
