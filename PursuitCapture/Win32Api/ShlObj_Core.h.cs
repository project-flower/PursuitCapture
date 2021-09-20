using System;
using System.Runtime.InteropServices;

namespace Win32Api
{
    public static partial class Shell32
    {
        #region Public Methods

        [DllImport(AssemblyName)]
        public static extern int SHCreateShellItem(IntPtr pidlParent, IntPtr psfParent, IntPtr pidl, out IShellItem ppsi);

        [DllImport(AssemblyName)]
        public static extern int SHILCreateFromPath([MarshalAs(UnmanagedType.LPWStr)] string pszPath, out IntPtr ppIdl, ref uint rgflnOut);

        #endregion
    }
}
