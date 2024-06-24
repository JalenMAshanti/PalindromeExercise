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
           
            //Refactored
            string originalString = new string(word.Where(x => char.IsLetter(x)).ToArray()).ToLower();
            string reversedString = new string(word.Where(x => char.IsLetter(x)).Reverse().ToArray()).ToLower();

            return  (originalString == reversedString) ? true : false;
            
        }

    }
}
