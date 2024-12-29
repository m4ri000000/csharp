//remove element, dado un array nums y un entero val, quitar todas las ocurrencias de val en num, en orden. Devolver el numero de elementos en nums que no son iguales a val.
//considerando los elementos de nums que no corresponden a val, como k

using System;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        int i;
        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }

    static void Main()
    {
        int[] nums = { 1, 3, 3, 4, 3, 4, 5 };
        int val = 3;

        Solution solution = new Solution();
        int k = solution.RemoveElement(nums, val);

        Console.WriteLine($"Cantidad de elementos distintos a {val}: {k}.");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}