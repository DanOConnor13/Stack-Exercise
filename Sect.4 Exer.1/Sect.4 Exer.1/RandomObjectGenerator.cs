using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._4_Exer._1
{
    class RandomObjectGenerator
    {

        public object GetRandomObject(int randomType)
        {
            Random random = new Random();
            var randomNumForType = random.Next(0, 5);

            switch (randomType)
            {
                case 1: // int
                    return randomNumForType;
                case 2: // char
                    List<char> letter = new List<char>() { 'B', 'R', 'S', 'A', 'E' } ;
                    return letter[randomNumForType];
                case 3: // string  
                    List<string> word = new List<string>() { "blue", "cat", "car", "house", "run" };
                    return word[randomNumForType];
                case 4:  // bool
                    bool isTrue = new bool();
                    if (randomType % 2 == 0)
                        isTrue = true;
                    else
                        isTrue = false;

                    return isTrue;
                default:
                    throw new ArgumentOutOfRangeException("Houston, we have a problem.");
            }


        }
    }
}
