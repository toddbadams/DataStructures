using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tba.DataStructures.MaxSubSum
{
    public class MaxSubSumN2 : IAlgorithm
    {
        public MaxSubSumN2(int[] data)
        {
            this.Data = data;
        }

        public int[] Data { get; private set; }

        public int Calculate()
        {
            int maxSum = 0;
            for (int i = 0; i < this.Data.Length; i++)
            {
                int thisSum = 0;
                for (int j = i; j < this.Data.Length; j++)
                {
                    thisSum += this.Data[j];
                    if (thisSum > maxSum) maxSum = thisSum;
                }
            }
            return maxSum;
        }
    }
}