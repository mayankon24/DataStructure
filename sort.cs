using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStructure
{
    class Sort
    {
        public void sortArray()
        {
            int[] intarray = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < intarray.Count(); i++)
            {               
                intarray[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < intarray.Count(); i++)
            {
                Console.Write(intarray[i].ToString() + " ,");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Out.NewLine = "\r\n\r\n";

            int[] sortArray = new int[15];
            sortArray[0] = intarray[0];

            for (int j = 0; j < intarray.Count() - 1; j++)
            {
                if (intarray[j] > intarray[j + 1])
                {
                    int temp = intarray[j];
                    intarray[j] = intarray[j + 1];
                    intarray[j + 1] = temp;
                }

            }



            //for (int i = 0; i < intarray.Count(); i++)
            //{
               
            //}
            for (int i = 0; i < intarray.Count(); i++)
            {
                Console.Write(intarray[i].ToString() + " ,");
            }
          

            Console.ReadLine();
        }

        public void BubbleSort()
        {
            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            bool flag = true;
            int temp;
            int numLength = number.Length;

            //sorting an array
            for (int i = 0; (i < (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            //Sorted array
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();        
        }
    }
}
