namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            
            
            int[] arr3 = new int[array1.Length + array2.Length];
            Array.Copy(array1, arr3, array1.Length);
            Array.Copy(array2, 0, arr3, array1.Length, array2.Length);
            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }
            return new int[10];
        }
    }

}