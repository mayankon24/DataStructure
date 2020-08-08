using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStructure
{
  public  class reverseString
    {

        public void reverse()
        {
            string input = "my name is mayank aggarwal";
            input = input + ' ';
            string output = string.Empty;


            int len = input.Count();
            string[] strArray = new string[len];

            string temp = string.Empty;
            int j = 0;

            for (int i = 0; i < len; i++)
            {
                if (input[i] == ' ')
                {
                    strArray[j++] = temp;
                    temp = string.Empty;
                }

                temp = temp + input[i];
            }

            for (int i = strArray.Count() -1; i >= 0; i--)
            {

                if (strArray[i] != null)
                {
                    output = output + " " + strArray[i];
                }
            }

            Console.WriteLine(output);
        }

    }
}
