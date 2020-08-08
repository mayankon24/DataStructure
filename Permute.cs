using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStructure
{
    class Permute
    {

        public void calPermute(StringBuilder input, int s, int e)
        {
            if (s==e)
            {
                Console.WriteLine(input);
                return;
            }           

            for (int i = s; i <= e; i++)
            {
                StringBuilder replaceString = swap(input,s,i );
                calPermute(replaceString,s+1, e);
            }
        }

        private StringBuilder swap(StringBuilder input, int s, int e)
        {
            char temp = input[s];
            input[s] = input[e];
            input[e] = temp;

            return input;
        }

        public void ExecutePermute()
        {
           string input = Console.ReadLine();
           StringBuilder tempInput = new StringBuilder();
           tempInput.Append(input);

           int start = 0;
           int lenght = input.Length-1;

           calPermute(tempInput, start, lenght);
           Console.ReadLine();
        }
    }
}
