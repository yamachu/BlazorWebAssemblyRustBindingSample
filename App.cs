using System;
using System.Runtime.InteropServices;

namespace BlazorWebAssemblyRustBindingSample
{
    public partial class App
    {
        [DllImport("libsample", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte array_allocation(out IntPtr out_arr);

        [DllImport("libsample", CallingConvention = CallingConvention.Cdecl)]
        public static extern void array_deallocation(ref IntPtr out_arr);

        public static byte[] Allocation(out IntPtr out_arr)
        {
            var len = array_allocation(out out_arr);
            var arr = new byte[len];
            Marshal.Copy(out_arr, arr, 0, len);
            return arr;
        }

        public static void Dealloc(ref IntPtr out_arr)
        {
            array_deallocation(ref out_arr);
        }
    }
}