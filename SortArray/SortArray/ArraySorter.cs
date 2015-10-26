using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public class ArraySorter
    {
        public static void Sort(int[][] arr, int criteria)
        {
            if (arr == null)
            {
                throw new ArgumentNullException();
            }
            switch (criteria)
            {
                case 1:
                    Sort(arr, (a, b) =>
                    {
                        int sum1 = 0;
                        int sum2 = 0;
                        if (a == null)
                        {
                            sum1 = int.MaxValue;
                        }
                        else
                        {
                            if (b == null)
                            {
                                sum2 = int.MaxValue;
                            }
                            else
                            {
                                for (int i = 0; i < a.Count(); i++)
                                {
                                    sum1 += a[i];
                                    sum2 += b[i];
                                }
                            }
                        }
                        if (sum1 > sum2)
                            return 1;
                        if (sum1 == sum2)
                            return 0;
                        if (sum1 < sum2)
                            return -1;
                        return 0;
                    });
                    break;
                case 2:
                    Sort(arr, (a, b) => 
                    {
                        int max1 = 0;
                        int max2 = 0;
                        if (a == null)
                        {
                            max1 = int.MaxValue;
                        }
                        else
                        {
                            if (b == null)
                            {
                                max2 = int.MaxValue;
                            }
                            else
                            {
                                for (int i = 0; i < a.Count(); i++)
                                {
                                    if (max1 < Math.Abs(a[i]))
                                        max1 = Math.Abs(a[i]);

                                    if (max2 < Math.Abs(b[i]))
                                        max2 = Math.Abs(b[i]);
                                }
                            }
                        }
                        if (max1 > max2)
                            return 1;
                        if (max1 == max2)
                            return 0;
                        if (max1 < max2)
                            return -1;
                        return 0;
                    });
                    break;
            }
        }

        private static void Sort(int[][] arr, Func<int[], int[], int> predicate)
        {
            for (int i = 0; i<arr.Count(); i++)
            {
                for (int j = i+1; j<arr.Count(); j++)
                {
                    switch(predicate(arr[i], arr[j]))
                    {
                        case -1:
                            break;
                        case 0:
                            break;
                        case 1:
                            int[] swapArray = arr[i];
                            arr[i] = arr[j];
                            arr[j] = swapArray;
                            break;
                    }
                }
            }
           // if (predicate(a, b) > 0) { /* do some work */ };
        }
    }
}
