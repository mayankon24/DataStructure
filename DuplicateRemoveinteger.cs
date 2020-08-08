using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStructure
{
    class DuplicateRemoveinteger
    {
        public void integerSplit()
        {
            Console.WriteLine("enter the interger value");
            string str =  Console.ReadLine();

            int[] input = {2,2,1,1,1,1,1,1,1,2,0};
            //input = new int[str.Length];  

            //for (int i = 0; i < str.Length; i++)
            //{
            //    input[i] = Convert.ToInt32(str[i]);
            //}

            //for (int i = 0; i < input.Count(); i++)
            //{
            //    Console.WriteLine(input[i].ToString());
            //}

            DuplicateRemove(input);
        }

        public void DuplicateRemove(int[] input)
        {          
            int lastIndex = input.Length - 1;
            int temp;

            for (int i = 0; i <= lastIndex; i++)
            {
                for (int j = i+1; j <= lastIndex; )
                {
                    if (input[i] == input[j] && input[j] == input[lastIndex])
                    {
                        lastIndex--;
                        continue;
                    }

                    if (input[i] ==  input[j])
                    {
                        temp = input[j];
                        input[j] = input[lastIndex];
                        input[lastIndex] = temp;
                        lastIndex--;
                    }
                    j++;
                }
            }

            for (int i = 0; i <= lastIndex; i++)
            {
                Console.WriteLine(input[i].ToString());
            }

            Console.ReadLine();           
        }
    }
}
