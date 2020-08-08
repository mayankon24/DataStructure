using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStructure
{
    class Split
    {
        public void integerSplit()
        {
            Console.WriteLine("enter the interger value");
            int input = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine(input.ToString());

            printsplitPattern(input);
        }

        public void printsplitPattern(int input)
        {
            int temp;
            while (input != 0)
            {
                temp = input % 10;
                Console.WriteLine(temp);
                AddNodeFirst(temp);
                input = input / 10;
            }
            Console.ReadLine();
        }

        public void AddNodeFirst(int value)
        {


        }
    }
}
