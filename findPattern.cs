using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStructure
{
    public class findPattern
    { 
        public void ExecutePatern()
        {
            List<string> lstCountry = new List<string>();
            lstCountry.Add("india");
            lstCountry.Add("qw");
            lstCountry.Add("qw");
            lstCountry.Add("Zimbabwe");
            lstCountry.Add("America");
            lstCountry.Add("India");
            lstCountry.Add("Indrt");
            lstCountry.Add("Germany");
            lstCountry.Add("China");
            lstCountry.Add("Ukraine");
            lstCountry.Add("Ind");

            List<string> lst = findPatern(lstCountry, "Ind");
        }

        public List<string> findPatern(List<string> lstCountry, string patern)
        {
            List<string> lstResult = new List<string>();

            foreach (string country in lstCountry)
            {
                if (IspaternMatch(country, patern))
                {
                    lstResult.Add(country);
                }
            }

            return lstResult;
        }
        bool IspaternMatch(string input, string patern)
        {           
            if (input.Length < patern.Length)
            {
                return false;
            }
            bool match = true;

            for (int i = 0; i < patern.Length; i++)
            {
                if (patern[i] != input[i])
                {
                    match = false;
                }
            }
            return match;
        }

        public void  permentation(string input)
        {
            
        }
    }
}
