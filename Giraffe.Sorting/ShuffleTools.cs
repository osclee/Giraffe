using System;
using System.Collections.Generic;

namespace Giraffe.Sorting
{
    public static class ShuffleTools
    {
        public static T[] Shuffle<T>(this T[] list)
        {
            if (list == null)
            {
                return null;
            }

            if (list.Length <= 1)
            {
                return list;
            }

            Random random = new Random();
            for (int i = list.Length - 1; i >= 0; i--)
            {
                var randIndex = random.Next(0, list.Length);

                var value1 = list[i];
                var value2 = list[randIndex];

                list[i] = value2;
                list[randIndex] = value1;
            }
            return list;
        }

        public static List<T> Shuffle<T>(this List<T> collection)
        {
            return new List<T>(Shuffle(collection.ToArray()));
        }
    }
}
