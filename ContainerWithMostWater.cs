using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractice
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            List<int> area = new List<int>();
            for(int i=0; i<height.Length;i++)
            {
                for(int j=i+1;j<height.Length;j++)
                {
                    int x = height[i] < height[j] ? height[i] * j : height[j] * j;
                    area.Add(x);
                }
            }
            int maxValue = 0;
            foreach (var item in area)
            {
                if(item > maxValue)
                {
                    maxValue=item;
                }
            }
            return maxValue;
        }
    }
}