namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T CollectionSum<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = default(T);
            foreach (T item in collection)
            {
                result += (dynamic)item;
            }
            return result;
        }

        public static T CollectionProduct<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)1;
            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }
            return result;
        }

        public static T CollectionMinElement<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Min();
        }

        public static T CollectionMaxElement<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Max();
        }

        public static double CollectionAverage<T>(this IEnumerable<T> collection) where T : struct
        {
            double result = Convert.ToDouble(CollectionSum(collection)) / Convert.ToDouble(collection.Count());
            return result;
        }
    }
}
