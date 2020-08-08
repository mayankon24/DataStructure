using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace dataStructure
{
    class Duplicate
    {

        public void Fibonacci()
        {
            int[] intarray = { 16, 67, 78, 45, 34, 56, 78, 16, 78 };
            int length = intarray.Count();

            for (int i = 0; i < intarray.Count(); i++)
            {
                Console.Write(intarray[i].ToString() + " ,");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Out.NewLine = "\r\n\r\n";

            int first = 0;
            int second = 1;
            int number = 7;

            List<int> lstFibonacci = new List<int>();
            for (int i = 0; i < number; i++)
            {
                int temp = first+second;
                first = second;
                second = temp;
                lstFibonacci.Add(temp);
            }

            for (int i = 0; i < lstFibonacci.Count(); i++)
            {
                Console.Write(lstFibonacci[i].ToString() + " ,");
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.Out.NewLine = "\r\n\r\n";

        }

        public void palindrome()
        {
            int[] intarray = { 16, 67, 78, 45, 34, 45, 78, 67, 116 };
            int length = intarray.Count();

            for (int i = 0; i < intarray.Count(); i++)
            {
                Console.Write(intarray[i].ToString() + " ,");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Out.NewLine = "\r\n\r\n";

            int flag = 1;

            for (int i = 0, j = length - 1; i < length/2; i++, j--)
            {
                if (intarray[i] != intarray[j])
                {
                    flag = 0;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.Write("yes"); 
            }
            else
            {
                Console.Write("NO"); 
            }
           
            Console.ReadLine();
            Console.Out.NewLine = "\r\n\r\n";

        }

        public void ReverseList()
        {
            int[] intarray = { 16, 67, 78, 45, 34, 56, 78, 16, 78 };
            int length = intarray.Count();

            for (int i = 0; i < intarray.Count(); i++)
            {
                Console.Write(intarray[i].ToString() + " ,");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Out.NewLine = "\r\n\r\n";

            for (int i = 0, j = length - 1; i < length/2; i++, j--)
            {
                int temp = intarray[i];
                intarray[i] = intarray[j];
                intarray[j] = temp;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Out.NewLine = "\r\n\r\n";

            for (int i = 0; i < intarray.Count(); i++)
            {
                Console.Write(intarray[i].ToString() + " ,");
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.Out.NewLine = "\r\n\r\n";

        }


        public void DuplicateArray()
        {
            int[] intarray = { 16, 67, 78, 45, 34, 56, 78, 16, 78 };
            //Random rnd = new Random();
            //for (int i = 0; i < intarray.Count(); i++)
            //{
            //    intarray[i] = rnd.Next(1, 100);
            //}

            for (int i = 0; i < intarray.Count(); i++)
            {
                Console.Write(intarray[i].ToString() + " ,");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Out.NewLine = "\r\n\r\n";

            Dictionary<int, int> disDuplicate = new Dictionary<int, int>();

            for (int i = 0; i < intarray.Count(); i++)
            {
                if (disDuplicate.ContainsKey(intarray[i]))
                {
                    disDuplicate[intarray[i]]++; 
                }
                else
                {
                    disDuplicate[intarray[i]] = 1;
                }

            }

            foreach (var item in disDuplicate)
            {
                Console.Write(item.Key +"count is "+ item.Value + " ,");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Out.NewLine = "\r\n\r\n";
            Console.ReadLine();

        }

        public void findLIke()
        {
            List<string> list = new List<string>();
            list.Add("line one");
            list.Add("line two");
            list.Add("line three");
            list.Add("line four");
            list.Add("line five");
            list.Add("line six");
            list.Add("line seven");
            list.Add("line eight");
            list.Add("line nine");
            list.Add("line ten");

            string pattern = "line f+";// ".*ine.*e";

            List<string> lstResult = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (Like(list[i],pattern))
                {
                    lstResult.Add(list[i]);  
                }
            }
        }

        private bool Like(string s, string pattern, RegexOptions options = RegexOptions.IgnoreCase)
        {
            return Regex.IsMatch(s, pattern, options);
        }


    }
}
