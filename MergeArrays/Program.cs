using System.Collections.Generic;

namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            
            // add the arrays together
            int count1 = array1.Length;
            int count2 = array2.Length;
            int[] arrayResult = new int[count1 + count2];
            // seperate the int
            int a = 0, b = 0;   // for arr1 and arr2
            int i = 0;          // for result

            //video said this meant true or false &&
            // while function makesure we dont miss a number because a count needs to = count1 etc
            while (a < count1 && b < count2)
            {
                if (array1[a] <= array2[b])
                {
                    arrayResult[i++] = array1[a++];
                }
                else
                {
                    arrayResult[i++] = array2[b++];
                }
            }
            //sorting
            if (a < count1)
            {
                 //first
                for (int x = a; x < count1; x++)
                {
                    arrayResult[i++] = array1[x];
                }
            }
            else
            {
                //2nd
                for (int x = b; x < count2; x++)
                {
                    arrayResult[i++] = array2[x];
                }
            }
            return arrayResult;
        }
    }




}


