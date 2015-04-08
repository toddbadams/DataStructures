using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tba.DataStructures.MaxSubSum
{
    public class MaxSubSumN : IAlgorithm
    {
        public MaxSubSumN(int[] data)
        {
            this.Data = data;
        }

        public int[] Data { get; private set; }

        public int Calculate()
        {
            int maxSum = 0;
            int sum = 0;
            for (int i = 0; i < this.Data.Length; i++)
            {
                sum += this.Data[i];
                if (sum < 0) sum = 0;
                if (sum > maxSum) maxSum = sum;
            }
            return maxSum;
        }
    }
}