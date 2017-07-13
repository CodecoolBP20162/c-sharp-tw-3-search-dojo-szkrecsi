using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    class ValidatorClass
    {
        public string ValidText(String inputText, String pattern)
        {
            string toSearch = inputText.Trim();
            foreach (string line in toSearch.Split())
            {
                if(line.Contains(pattern))
                    return pattern;
            }
            return null;
         }
    }
}
