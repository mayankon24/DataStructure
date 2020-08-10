using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStructure {
    class capitalLetterChange {
        public void matchpattern () {
            string inputString = "this is crazy and fun";
            string[] inputList = { "is", "fun" };

            string[] inputArray = inputString.Split (" ");

            HashSet<string> inputhash = new HashSet<string> ();
            foreach (string item in inputList) {
                inputhash.Add (item);
            }

            int i = 0;
            for (i = 0; i < inputArray.Length; i++) {
                if (!inputhash.Contains (inputArray[i])) {
                    inputArray[i] = createCapital (inputArray[i]);
                }
            }

            foreach (string item in inputArray) {
                Console.Write (item + " ");
            }
        }

        string createCapital (String str) {
            StringBuilder tempstr = new StringBuilder (str);
            int temp = (int) tempstr[0];
            if (temp >= 97 && temp <= 122) {
                tempstr[0] = (char) (temp - 32);
            }

            return tempstr.ToString ();
        }
    }
}