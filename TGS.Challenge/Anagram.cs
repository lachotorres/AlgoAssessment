using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
    */
    public class Anagram
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        /// <remarks>
        /// NOTE horse and heroes cannot be an Anagrams cause definition of angaram says we have to use all the original letters only once
        /// so heroes contain 2 "e" chars and cannot be an anagram of horse
        /// Also "Funeral" and "Reel fun" cannot be anagrams so assert to true on test case "Funeral_IsAnagram_Reel_fun" is wrong.
        /// </remarks>
        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2)) throw new ArgumentException();

            var w1 = Regex.Replace(word1, "[^a-zA-Z]", "").ToLower();
            var w2 = Regex.Replace(word2, "[^a-zA-Z]", "").ToLower();

            w1 = Helper.Sort(w1);
            w2 = Helper.Sort(w2);

            return w1.Equals(w2);
        }

        
    }
}
