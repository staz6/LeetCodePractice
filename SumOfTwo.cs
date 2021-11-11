using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class SumOfTwo
    {
        //On2 solution
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("match found");
                        int[] x = { i, j };
                        return x;

                    }
                }
            }
            return nums;

        }
        public int[] sumOfTwoOptimal(int[] nums,int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

           for(int i=0;i<nums.Length;i++)
           {
               int compliment = target - nums[i];
                if(dic.ContainsKey(compliment)) return new int[] {dic[compliment],i};
                if(!dic.ContainsKey(nums[i])) dic.Add(nums[i],i);
           }

            return new int[2];
        }
    }
}