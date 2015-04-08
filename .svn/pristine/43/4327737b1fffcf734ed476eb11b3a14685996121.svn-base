using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tba.DataStructures.MaxSubSum
{
    public class MaxSubSumN3 : IAlgorithm
    {
        public MaxSubSumN3(int[] data)
        {
            this.Data = data;
        }

        public int[] Data { get; private set; }

        public int Calculate()
        {
            int maxSum = 0;
            for (int i = 0; i < this.Data.Length; i++)
            {
                for (int j = i; j < this.Data.Length; j++)
                {
                    int thisSum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        thisSum += this.Data[k];                     
                    }
                    if (thisSum > maxSum) maxSum = thisSum;
                }
            }
            return maxSum;
        }
    }
}