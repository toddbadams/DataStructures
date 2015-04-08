using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tba.DataStructures
{
    public class ArrayGenerator
    {

        public int Length { get; private set; }
        public int Min { get; private set; }
        public int Max { get; private set; }
        public int[] Data { get; private set; }

        public ArrayGenerator(int min, int max, int length)
        {
            this.Min = min < max ? min : max;
            this.Max = max > min ? max : min;
            this.Length = length;
            this.Data = new int[Length];
            for(int i = 0; i< Length; i++)
            {
                this.Data[i] = RandomNumber(this.Min,this.Max);
            }

        }

        //Function to get random number
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}