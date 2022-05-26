using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSLabs.AtHomeCodingExcercise.App
{
    public static class Excercises
    {
        /// <summary>
        /// Calculate how many integers in the collection are above or below the comparison threshold
        /// </summary>
        /// <param name="collection">Unsorted collection of integers</param>
        /// <param name="comparison">The comparison value</param>
        /// <returns>Dictionary with the keys "above" and "below" with the corresponding count of integers from the list that are above or below the comparison value</returns>
        public static Dictionary<string,int> aboveBelow(List<int> collection, int comparison)
        {
            int above = 0,
                below = 0;
            var aboveAndBelowDictionary = new Dictionary<string,int>();
            collection.ForEach(x =>
                {
                    if (x > comparison)
                        above++;
                    if (x < comparison)
                        below++;
                });
            aboveAndBelowDictionary.Add("above", above);
            aboveAndBelowDictionary.Add("below", below);
            return aboveAndBelowDictionary;
        }

        /// <summary>
        /// Shift originalString to the right by rotationAmount
        /// </summary>
        /// <param name="originalString">String to be rotated</param>
        /// <param name="rotationAmount">Positive integer declaring how many characters to rotate to right</param>
        /// <returns>returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning</returns>
        public static string stringRotation(string originalString, int rotationAmount)
        {
            if (rotationAmount < 0)
                throw new ArgumentException("rotationAmount must be positive");

            rotationAmount = originalString.Length == 0 ? 0 : rotationAmount % originalString.Length;
            return originalString.Substring(originalString.Length - rotationAmount,rotationAmount) 
                + originalString.Substring(0, originalString.Length - rotationAmount);
        }
    }
}
