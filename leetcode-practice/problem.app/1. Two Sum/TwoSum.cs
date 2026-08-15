using System;
using System.Collections.Generic;
using System.Text;

namespace problem.app._1._Two_Sum
{
    public class TwoSum
    {
        public int[] Find(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}
