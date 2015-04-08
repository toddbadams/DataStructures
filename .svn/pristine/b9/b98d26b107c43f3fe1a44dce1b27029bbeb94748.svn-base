using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tba.DataStructures.Collections
{
    public interface ISorter<T>
        where T : IComparable
    {
        T[] SortAscending();
        T[] SortDecending();
        int[] Inversions { get; }
    }

    public class SortBase<T>
        where T : IComparable
    {
        protected T[] sortArray;
        private int[] inversions;
        private bool calcInversions;

        public int[] Inversions { get { return this.inversions; } }

        public SortBase(T[] sortArray)
        {
            this.sortArray = sortArray;
            this.inversions = new int[0];
        }

        public SortBase(T[] sortArray, bool calcInversions)
        {
            this.sortArray = sortArray;
            this.calcInversions = calcInversions;
            this.inversions = new int[0];
        }

        protected void Swap(int index1, int index2)
        {
            T temp;
            temp = sortArray[index1];
            sortArray[index1] = sortArray[index2];
            sortArray[index2] = temp;
        }

        protected bool IsGreaterThan(int index1, int index2)
        {
            return (sortArray[index1].CompareTo(sortArray[index2]) > 0);
        }

        protected bool IsGreaterThan(int index1, T value)
        {
            return (sortArray[index1].CompareTo(value) > 0);
        }

        protected bool IsLessThan(int index1, int index2)
        {
            return (sortArray[index1].CompareTo(sortArray[index2]) < 0);
        }

        protected bool IsLessThan(int index1, T value)
        {
            return (sortArray[index1].CompareTo(value) < 0);
        }

        protected void CalculateAscendingInversionsRemaining()
        {
            if (!this.calcInversions) return;
            Array.Resize(ref inversions, inversions.Length + 1);
            for (int i = 0; i < sortArray.Length; i++)
                for (int j = i + 1; j < sortArray.Length; j++)
                    if (this.IsGreaterThan(i, j))
                        inversions[inversions.Length - 1] = inversions[inversions.Length - 1] + 1;
        }

        protected void CalculateDecendingInversionsRemaining()
        {
            if (!this.calcInversions) return;
            Array.Resize(ref inversions, inversions.Length + 1);
            for (int i = 0; i < sortArray.Length; i++)
                for (int j = i + 1; j < sortArray.Length; j++)
                    if (this.IsLessThan(i, j))
                        inversions[inversions.Length] = +1;
        }

    }

    //Bubble Sort
    //Suppose A is an array of N values. We want to sort A in ascending order.
    //Bubble Sort is a simple-minded algorithm based on the idea that we look at the list, and wherever we find two consecutive elements out of order, we swap them. We do this as follows: We repeatedly traverse the sortArray part of the array, comparing consecutive elements, and we interchange them when they are out of order. The name of the algorithm refers to the fact that the largest element "sinks" to the bottom and the smaller elements "float" to the top.
    //     For I = 0 to N - 2
    //       For J = 0 to N - 2
    //         If (A(J) > A(J + 1)
    //           Temp = A(J)
    //           A(J) = A(J + 1)
    //           A(J + 1) = Temp
    //         End-If
    //       End-For
    //     End-For
    //Bubble Sort does roughly N**2 / 2 comparisons and does up to N**2 / 2 swaps.
    public class BubbleSorter<T> : SortBase<T>, ISorter<T>
        where T : IComparable
    {
        public BubbleSorter(T[] sortArray) : base(sortArray) { }
        public BubbleSorter(T[] sortArray, bool calcInversions) : base(sortArray, calcInversions) { }

        public T[] SortAscending()
        {
            for (int i = 0; i < sortArray.Length - 1; i++)
                for (int j = 0; j < sortArray.Length - 1; j++)
                {
                    if (this.IsGreaterThan(j, j + 1))
                        this.Swap(j, j + 1);
                    this.CalculateAscendingInversionsRemaining();
                }
            return sortArray;
        }

        public T[] SortDecending()
        {
            for (int i = 0; i < sortArray.Length - 1; i++)
                for (int j = 0; j < sortArray.Length - 1; j++)
                {
                    if (this.IsLessThan(j, j + 1))
                        this.Swap(j, j + 1);
                    this.CalculateAscendingInversionsRemaining();
                }
            return sortArray;
        }
    }

    //Insertion Sort
    //Suppose A is an array of N values. We want to sort A in ascending order.
    //Insertion Sort is an algorithm to do this as follows: We traverse the array and insert each element into the sorted part of the list where it belongs. This usually involves pushing down the larger elements in the sorted part.
    //     For I = 1 to N-1
    //       J = I
    //       Do while (J > 0) and (A(J) < A(J - 1)
    //         Temp = A(J)
    //         A(J) = A(J - 1)
    //         A(J - 1) = Temp
    //         J = J - 1 
    //       End-Do
    //     End-For
    //Insertion Sort does roughly N**2 / 2 comparisons and does up to N - 1 swaps.
    public class InsertionSorter<T> : SortBase<T>, ISorter<T>
        where T : IComparable
    {
        public InsertionSorter(T[] sortArray) : base(sortArray) { }
        public InsertionSorter(T[] sortArray, bool calcInversions) : base(sortArray, calcInversions) { }

        public T[] SortAscending()
        {
            T temp;
            int k;
            for (int i = 1; i < sortArray.Length; i++)
            {
                temp = sortArray[i];
                k = i - 1;
                while (k >= 0 && this.IsGreaterThan(k, temp))
                {
                    sortArray[k + 1] = sortArray[k];
                    k--;
                    this.CalculateAscendingInversionsRemaining();
                }
                sortArray[k + 1] = temp;
            }
            return sortArray;
        }

        public T[] SortDecending()
        {
            T temp;
            int k;
            for (int i = 1; i < sortArray.Length; i++)
            {
                temp = sortArray[i];
                k = i - 1;
                while (k >= 0 && this.IsLessThan(k, temp))
                {
                    sortArray[k + 1] = sortArray[k];
                    k--;
                    this.CalculateAscendingInversionsRemaining();
                }
                sortArray[k + 1] = temp;
            }
            return sortArray;
        }
    }

    //Selection Sort
    //Suppose A is an array of N values. We want to sort A in ascending order. That is, A[1] should be the smallest and A[N] should be the largest.
    //The idea of Selection Sort is that we repeatedly find the smallest element in the sortArray part of the array and swap it with the first element in the sortArray part of the array.
    //     For I = 0 to N-1 do:
    //       Smallsub = I
    //       For J = I + 1 to N-1 do:
    //         If A(J) < A(Smallsub)
    //           Smallsub = J
    //         End-If
    //       End-For
    //       Temp = A(I)
    //       A(I) = A(Smallsub)
    //       A(Smallsub) = Temp
    //     End-For
    //A refinement of the above pseudocode would be to avoid swapping an element with itself.
    //An alternate way to sort in ascending order is to find the largest value and swap with the last element in the sortArray part of the array.
    //Selection Sort does roughly N**2 / 2 comparisons and does N swaps.
    public class SelectionSorter<T> : SortBase<T>, ISorter<T>
        where T : IComparable
    {
        public SelectionSorter(T[] sortArray) : base(sortArray) { }
        public SelectionSorter(T[] sortArray, bool calcInversions) : base(sortArray, calcInversions) { }

        public T[] SortAscending()
        {
            int min;
            for (int i = 0; i < sortArray.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < sortArray.Length; j++)
                {
                    if (this.IsLessThan(j, min))
                        min = j;
                    this.CalculateAscendingInversionsRemaining();
                }

                
                this.Swap(i, min);
            }
            return sortArray;
        }

        public T[] SortDecending()
        {
            int min;
            for (int i = 0; i < sortArray.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < sortArray.Length; j++)
                    if (this.IsGreaterThan(j, min))
                        min = j;

                this.Swap(i, min);
            }
            return sortArray;
        }
    }

    //Merge Sort
    // http://www.codeproject.com/Articles/42068/Merge-Sort
    public class MergeSorter<T> : SortBase<T>, ISorter<T>
        where T : IComparable, new()
    {
        public MergeSorter(T[] sortArray) : base(sortArray) { }

        public T[] SortAscending()
        {
            int n = sortArray.Length;
            sortArray = MergeSort(sortArray, n);
            return sortArray;
        }

        public T[] SortDecending()
        {
            throw new NotImplementedException();
        }

        /// Internal method for sorting
        /// </summary>
        /// <param name="X"></param>
        /// <param name="n"></param>
        private static T[] MergeSort<T>(T[] X, int n) where T : IComparable,
            new()
        {
            // Define 2 aid Sub-Arrays
            T[] A = new T[(n / 2) + 2];
            T[] B = new T[(n / 2) + 2];

            // Initialize the 2 Sub-Arrays with an infinite 'sorting parameter'
            // Therefor, You must include a default ctor in your class
            // which will initialize an infinite value - To the sorting parameter
            // using 'where T : new()' here
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new T(); ;
                B[i] = new T();
            }

            // Recursive Stop-Condition, Sorting a Basic Array (Size 2)
            if (n == 2)
            {
                int CompareValue = X[0].CompareTo(X[1]);
                if (CompareValue > 0)
                {
                    T tempT = X[0];
                    X[0] = X[1];
                    X[1] = tempT;
                }
            }

            else
            {
                // The Sub-Arrays Size is Large than 2
                if (n > 2)
                {
                    int m = n / 2;

                    // Initialize the 2 Sub-Arrays (The first relevant values)
                    for (int i = 0; i < m; i = i + 1)
                    {
                        A[i] = X[i];
                    }

                    for (int j = m; j < n; j++)
                    {
                        B[j - m] = X[j];
                    }

                    // 2 Recursive Calling, Sorting Sub-Arrays
                    A = MergeSort(A, m);
                    B = MergeSort(B, n - m);

                    // Merging the Sorted Sub-Arrays into the main Array
                    int p = 0;
                    int q = 0;

                    for (int k = 0; k < n; k++)
                    {
                        {
                            int CompareValure = A[p].CompareTo(B[q]);

                            if (CompareValure == 0 ||
                                CompareValure == -1)
                            {
                                X[k] = A[p];
                                p = p + 1;
                            }

                            else
                            {
                                X[k] = B[q];
                                q = q + 1;
                            }
                        }
                    }

                } // if

            } // else

            return X;

        } // MegrgeSort_Internal
    }

    // Shell Sort
    public class ShellSorter<T> : SortBase<T>, ISorter<T>
        where T : IComparable, new()
    {
        public ShellSorter(T[] sortArray) : base(sortArray) { }
        public ShellSorter(T[] sortArray, bool calcInversions) : base(sortArray, calcInversions) { }

        public T[] SortAscending()
        {
            int j, increment;
            T temp;

            increment = 3;

            while (increment > 0)
            {
                for (int i = 0; i < sortArray.Length; i++)
                {
                    j = i;
                    temp = sortArray[i];

                    while ((j >= increment) && (this.IsGreaterThan(j - increment, temp))) 
                    {
                        sortArray[j] = sortArray[j - increment];
                        j = j - increment;
                        this.CalculateAscendingInversionsRemaining();
                    }

                    sortArray[j] = temp;
                }

                if (increment / 2 != 0)
                {
                    increment = increment / 2;
                }
                else if (increment == 1)
                {
                    increment = 0;
                }
                else
                {
                    increment = 1;
                }
            }
            return sortArray;
        }

        public T[] SortDecending()
        {
            int j, increment;
            T temp;

            increment = 3;

            while (increment > 0)
            {
                for (int i = 0; i < sortArray.Length; i++)
                {
                    j = i;
                    temp = sortArray[i];

                    while ((j >= increment) && (this.IsLessThan(j - increment, temp)))
                    {
                        sortArray[j] = sortArray[j - increment];
                        j = j - increment;
                    }

                    sortArray[j] = temp;
                }

                if (increment / 2 != 0)
                {
                    increment = increment / 2;
                }
                else if (increment == 1)
                {
                    increment = 0;
                }
                else
                {
                    increment = 1;
                }
            }
            return sortArray;
        }
    }

}