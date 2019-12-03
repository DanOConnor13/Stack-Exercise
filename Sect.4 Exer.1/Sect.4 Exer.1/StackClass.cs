using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._4_Exer._1
{
    class Stackclass
    {

        int min = 1;
        int max = 5;

        Random random = new Random();
        RandomObjectGenerator randomObject = new RandomObjectGenerator();
        List<string> type = new List<string> { "Int", "Char", "String", "Bool" };

        public string ChangeStack(int selection, Stack stack)
        {
            var randomType = random.Next(min, max); 

            switch (selection)
            {
                case 1:
                    var newObject = randomObject.GetRandomObject(randomType);
                    stack.Push(newObject);
                    return newObject + " was added to stack.";
 
                case 2:
                    return stack.Pop() + " was removed from stack.";

                case 3:
                    stack.Clear();
                    return "Stack has been cleared";

                case 4:
                    foreach (object item in stack)
                    {
                        Console.WriteLine(item);
                    }
                    return "";

                case 5:
                    return "exit";
                default:
                    return "Something bad happened...";
            }
        }


    }

               
}


