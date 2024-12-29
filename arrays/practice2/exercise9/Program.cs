//concatenate two arrays
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = {1, 2, 3};
        int[] nums2 = {4, 5, 6};
        int[] numsConc = new int[nums1.Length + nums2.Length];
        int i;
        for (i = 0; i < nums1.Length; i++)
        {
            numsConc[i] = nums1[i];
        }
        for (i = 0; i < nums2.Length; i++)
        {
            numsConc[nums1.Length + i] = nums2[i];
        }
        Console.WriteLine("the concatenated array is: " + string.Join(", ", numsConc));
    }
}