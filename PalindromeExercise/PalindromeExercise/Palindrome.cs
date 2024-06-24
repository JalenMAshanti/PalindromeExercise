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

            string reversed = new string(word.ToLower().Reverse().ToArray());
            bool result = (word == reversed) ? true : false;
            return result;
        }

    }
}
