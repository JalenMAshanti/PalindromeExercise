using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Palindrome
    {
        public bool PalindromeDetection (string word)
        {
            //throw new NotImplementedException ();   
                
            List<char> oringalWordWithoutSpaces = new List<char> (word.Where(x => char.IsLetter(x)));
            List<char> wordReversed = new List<char>(word.Where(x => char.IsLetter(x)).Reverse());

            string originalString = new string(oringalWordWithoutSpaces.ToArray());
            string reversedString = new string(wordReversed.ToArray());

            bool result = (originalString.ToLower() == reversedString.ToLower()) ? true : false;
            return result;
        }

    }
}
