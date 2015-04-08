using System.Collections.Generic;

namespace tba.DataStructures.Collections
{

    public class StockSpan
    {
        public StockSpan()
        {

        }

        public StockSpan(decimal[] prices)
        {
            this.Prices = prices;
        }

        public  decimal[] Prices { get; private set; }

        //  2. Initialize an array S which will store the span of the stock
        //  3. for i = 0 to i = n - 1
        //         3.1 Initialize k to zero
        //         3.2 Done with a false condition
        //         3.3 repeat
        //               3.3.1 if ( P[i - k] <= P[i] ) then
        //                         Increment k by 1
        //               3.3.2 else
        //                         Done with true condition
        //         3.4 Till (k > i) or done with processing
        //               Assign value of k to S[i] to get the span of the stock
        //  4. Return array S
        public int[] CalculateNorm()
        {
            int[] span = new int[this.Prices.Length];
            int k;
            for (int i = 0; i < this.Prices.Length; i++)
            {
                k = 0;
                do
                {
                    if (this.Prices[i - k] <= Prices[i])
                    {
                        k++;
                    }
                    else
                    {
                        break;
                    }
                } while (k <= i);
                span[i] = k;
            }

            return span;
        }

        //1. Initialize an array P which contains the daily prices of the stocks
        //2. Initialize an array S which will store the span of the stock
        //3. for i = 0 to i = n - 1
        //        3.1 Initialize k to zero
        //        3.2 Done with a false condition
        //        3.3 while not (Stack N is empty or done with processing)
        //              3.3.1 if ( P[i] >= P[N.top())] then
        //                 3.3.1.1 Pop a value from stack N
        //              3.3.2 else
        //                 3.3.2.1 Done with true condition
        //        3.4 if Stack N is empty
        //                 3.4.1 Initialize h to -1
        //        3.5 else
        //                 3.5.1 Initialize stack top to h ( h <- N.top() )
        //                 3.5.2 Put the value of h - i in S[i]
        //                 3.5.3 Push the value of i in N 
        //4. Return array S
        public int[] CalculateWithStack(IStack<int> N)
        {
            //2. Initialize an array S which will store the span of the stock
            int[] S = new int[this.Prices.Length];
            int k = 0;
            int h = 0;

            //3. for i = 0 to i = n - 1
            for (int i = 0; i < this.Prices.Length; i++)
            {
                //3.1 Initialize k to zero
                k = 0;

                //3.2 Done with a false condition

                //3.3 while not (Stack N is empty or done with processing)
                while (N.Count > 0)
                {
                    //3.3.1 if ( P[i] >= P[N.top())] then
                    if (this.Prices[i] >= this.Prices[N.Peek()])
                    {
                        //3.3.1.1 Pop a value from stack N
                        N.Pop();
                    }
                    //3.3.2 else
                    else
                    {
                        //3.3.2.1 Done with true condition
                        break;
                    }
                }

                //3.4 if Stack N is empty
                if (N.Count < 1)
                {
                    //3.4.1 Initialize h to -1
                    h = -1;
                }
                //3.5 else
                else
                {
                    //3.5.1 Initialize stack top to h ( h <- N.top )
                    h = N.Peek();
                }
                //3.6 Put the value of h - i in S[i]
                S[i] = i - h;
                //3.7 Push the value of i in N 
                N.Push(i);
            }

            return S;
        }



        
    }
}
