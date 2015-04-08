using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace tba.DataStructures
{
    public class FormulaLinearList : IDisposable
    {
        #region private fields
        private IntPtr pointerToObject;
        #endregion

        #region external calls
        // Constructor
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern IntPtr CreateFormulaLinearList(int maxSize);

        // Dispose
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern void DisposeFormulaLinearList(IntPtr pointerToObject);

        // IsEmpty
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern bool FormulaLinearListIsEmpty(IntPtr pointerToObject);

        //  Length
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern int FormulaLinearListLength(IntPtr pointerToObject);

        //  Find
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern int FormulaLinearListFind(IntPtr pointerToObject, int position);

        //  Search
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern int FormulaLinearListSearch(IntPtr pointerToObject, IntPtr pObjectToSearch);

        //  Delete
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern IntPtr FormulaLinearListDelete(IntPtr pointerToObject, int position, IntPtr ObjectDeleted);

        //  Insert
        [DllImport(@"tba.CppDatastructures.dll", CallingConvention = CallingConvention.Cdecl)]
        static private extern IntPtr FormulaLinearListInsert(IntPtr pointerToObject, int position, IntPtr pObjectToInsert);
        #endregion

        #region Ctor
        public FormulaLinearList(int maxSize)
        {
            // create pointer to the object in c++
            pointerToObject = CreateFormulaLinearList(maxSize);
        }
        #endregion

        #region Public Properties
        public bool IsEmpty { get { return FormulaLinearListIsEmpty(pointerToObject); } }

        public int Length { get { return FormulaLinearListLength(pointerToObject); } }
        #endregion

        #region Public Methods
        public int Find(int position)
        {
            return FormulaLinearListFind(pointerToObject, position);
        }

        public int Search(int entityToSearch)
        {
            GCHandle handle = GCHandle.Alloc(entityToSearch, GCHandleType.Pinned);
            int result = 0;
            try
            {
                IntPtr pointer = handle.AddrOfPinnedObject();
                result = FormulaLinearListSearch(pointerToObject, pointer);
            }
            finally
            {
                if (handle.IsAllocated)
                {
                    handle.Free();
                }
            }
            return result;
        }

        public int Delete(int position)
        {
            int entityDeleted = 0;
            GCHandle handle = GCHandle.Alloc(entityDeleted, GCHandleType.Pinned);
            int result = 0;
            try
            {
                IntPtr pointer = handle.AddrOfPinnedObject();
                result = FormulaLinearListSearch(pointerToObject, pointer);
            }
            finally
            {
                if (handle.IsAllocated)
                {
                    handle.Free();
                }
            }
            return result;
        }
        public void Insert(int entityToInsert)
        {

        }

        #endregion
        #region Dispose
        // Summary:
        //     Performs application-defined tasks associated with freeing, releasing, or
        //     resetting unmanaged resources.
        public virtual void Dispose()
        {
            // dispose in c++
            DisposeFormulaLinearList(this.pointerToObject);
            // Always NULL out deleted objects in order to prevent a dirty pointer
            this.pointerToObject = IntPtr.Zero;
        }

        public virtual void Dispose(bool native)
        {

        }
        #endregion

    }
}
