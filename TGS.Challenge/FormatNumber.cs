using System;
using System.Text;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        private static StringBuilder _number = null;
       

        public string Format(int value)
        {
            if (value < 0 || value > 1000000000) throw new ArgumentOutOfRangeException();
            _number = new StringBuilder();
            GetChunk(value.ToString());
            return _number.ToString();
        }

        private string GetChunk(string str)
        {
            const int chunckSize = 3;

            if (str.Length <= chunckSize)
            {
                _number.Insert(0, str);
                return str;
            }
            var chunk = str.Substring(str.Length - chunckSize, chunckSize);
            _number.Insert(0, "," + chunk);
            var remainder = str.Substring(0, str.Length - chunckSize);

            return GetChunk(str.Substring(0, str.Length - chunckSize));
        }

    }
}
