using System;
using System.Runtime.InteropServices;

namespace tba.DataStructures
{
    public class MinusOne
    {
        [DllImport(@"tba.CppDatastructures.dll",
            CallingConvention = CallingConvention.Cdecl)]
        private static extern void MinusOneArray(IntPtr array, int length);

        #region Ctor
        public MinusOne(int[] array)
        {
            this.Array = array;
        }
        #endregion

        #region Public Properties
        public int[] Array { get; private set; }
        #endregion

        #region Public Methods
        public void Calculate()
        {
            GCHandle handle = GCHandle.Alloc(this.Array, GCHandleType.Pinned);
            try
            {
                IntPtr pointer = handle.AddrOfPinnedObject();
                MinusOneArray(pointer, this.Array.Length);
            }
            finally
            {
                if (handle.IsAllocated)
                {
                    handle.Free();
                }
            }
        }
        #endregion
    }
}
