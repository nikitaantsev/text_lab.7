
using System;
using System.Collections.Generic;
using System.Threading;

namespace    lab.tex_7
{ 
class GFG
{

 
    static int countSubsets(int[] arr, int n)
    {
        HashSet<int> us = new HashSet<int>();
        int even_count = 0;

        
        for (int i = 0; i < n; i++)
            if (arr[i] % 2 == 0)
                us.Add(arr[i]);


        
        even_count = us.Count;

      
        return (int)(Math.Pow(2, even_count) - 1);
    }

    
    public static void Main(String[] args)
    {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Sleep for 2 seconds.");
                Thread.Sleep(2000);
            }

            Console.WriteLine("Main thread exits.");

            int[] arr = { 4, 2, 1, 9, 2, 6, 5, 3 };
        int n = arr.Length;
        Console.WriteLine("Number of subsets = "
            + countSubsets(arr, n));
        }
    }
}



















