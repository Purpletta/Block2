using System;

namespace Sort
{
    class GenericSort
    {
        static void Main()
        {

        }
    }
    interface sort
    {
        public delegate int comparator<T>(T a, T b);

        public static void qsort(int[] a, uint left, uint right)
        {
            if (left < right)
            {
                uint q = partition(a, left, right, cmp_int);
                qsort(a, left, q);
                qsort(a, q + 1, right);
            }
        }
        public static void qsort(char[] a, uint left, uint right)
        {
            if (left < right)
            {
                uint q = partition(a, left, right, cmp_char);
                qsort(a, left, q);
                qsort(a, q + 1, right);
            }
        }
        public static void qsort(double[] a, uint left, uint right)
        {
            if (left < right)
            {
                uint q = partition(a, left, right, cmp_double);
                qsort(a, left, q);
                qsort(a, q + 1, right);
            }
        }
        public static void qsort<T>(T[] a, uint left, uint right, comparator<T> cmp)
        {
            if (left < right)
            {
                uint q = partition(a, left, right, cmp);
                qsort(a, left, q, cmp);
                qsort(a, q + 1, right, cmp);
            }
        }
        private static uint partition<T>(T[] a, uint left, uint right, comparator<T> cmp)
        {
            T v = a[(left + right) >> 1];
            uint i = left;
            uint j = right;
            while (i <= j)
            {
                while (cmp(a[i], v) < 0)
                {
                    ++i;
                }
                while (cmp(a[j], v) > 0)
                {
                    --j;
                }
                if (i >= j)
                {
                    break;
                }
                swap(ref a[i++], ref a[j--]);
            }
            return j;
        }
        private static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        private static int cmp_int(int a, int b)
        {
            return (a - b);
        }
        private static int cmp_char(char a, char b)
        {
            return (a - b);
        }
        private static int cmp_double(double a, double b)
        {
            return Math.Sign((a - b));
        }
    }
}
