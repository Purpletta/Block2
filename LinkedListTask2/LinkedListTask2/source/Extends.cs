using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTask2
{
    public class Extends<T> where T : IComparable<T>
    {
        public bool Any<TSource>(IEnumerable<TSource> source)
        {
            var enumerator = source.GetEnumerator();
            return enumerator.MoveNext();
        }
        public int Count<TSource>(IEnumerable<TSource> source)
        {
            int count = 0;
            var enumerator = source.GetEnumerator();
            while (enumerator.MoveNext()) count++;
            return count;
        }
        public object ElementAt<TSource>(IEnumerable<TSource> source, int position)
        {
            var enumerator = source.GetEnumerator();
            for (int i = 0; i <= position; i++)
            {
                if (!enumerator.MoveNext())
                {
                    return null;
                }
            }
            return enumerator.Current;
        }
        public TSource ElementAtOrDefault<TSource>(IEnumerable<TSource> source, int position)
        {
            var enumerator = source.GetEnumerator();
            for (int i = 0; i <= position; i++)
            {
                if (!enumerator.MoveNext())
                {
                    return default;
                }
            }
            return enumerator.Current;
        }
        public TSource First<TSource>(IEnumerable<TSource> source)
        {
            var enumerator = source.GetEnumerator();
            enumerator.MoveNext();
            return enumerator.Current;
        }
        public TSource Last<TSource>(IEnumerable<TSource> source)
        {
            var enumerator = source.GetEnumerator();
            TSource previous = default;
            while (enumerator.MoveNext())
            {
                previous = enumerator.Current;
            }
            return previous;
        }

        public TSource Max<TSource>(IEnumerable<TSource> source, Func<TSource, TSource, bool> func)
        {
            var enumerator = source.GetEnumerator();
            enumerator.MoveNext();
            TSource max = enumerator.Current;
            while (enumerator.MoveNext())
            {
                if (func(max, enumerator.Current))
                {
                    max = enumerator.Current;
                }
            }
            return max;
        }
        public TSource Min<TSource>(IEnumerable<TSource> source, Func<TSource, TSource, bool> func)
        {
            var enumerator = source.GetEnumerator();
            enumerator.MoveNext();
            TSource min = enumerator.Current;
            while (enumerator.MoveNext())
            {
                if (!func(min, enumerator.Current))
                {
                    min = enumerator.Current;
                }
            }

            return min;
        }

        public TSource[] Reverse<TSource>(IEnumerable<TSource> source)
        {
            int count = Count(source);
            TSource[] reversed = new TSource[count];
            var enumerator = source.GetEnumerator();
            int k = 0;
            for (int j = count; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    enumerator.MoveNext();
                }
                reversed[k] = enumerator.Current;
                enumerator.Reset();
                k++;
            }
            return reversed;
        }





    }
}
