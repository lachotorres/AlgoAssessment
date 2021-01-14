using System;
using System.Collections.Generic;
using System.Text;

namespace TGS.Challenge
{
    public class Helper
    {
        /// <summary>
        /// Sorts string chars alphabetically
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        /// <remarks>
        /// This can be done easier with LINQ but I think there is no point to use LINQ on this assesment.
        /// </remarks>
        public static string Sort(string str)
        {
            char temp;
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }

            return new string(charstr);
        }
    }
}
