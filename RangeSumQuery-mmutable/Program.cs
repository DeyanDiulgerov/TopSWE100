using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeSumQuery_mmutable
{
    public class NumArray
    {
        private int[] runningSum;

        public NumArray(int[] nums)
        {
            runningSum = new int[nums.Length];
            runningSum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            // sum[i,j] = runningSum[0,j] - runningSum[0,i-1]       
            return left == 0 ? runningSum[right] : runningSum[right] - runningSum[left - 1];
        }
    }
}
