using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Win32Api;

namespace PursuitCapture
{
    public static class WindowManager
    {
        #region Public Methods

        public static IntPtr[] GetWindowHandle(string filter, bool regEx)
        {
            var handles = new List<IntPtr>();
            ((string, bool), List<IntPtr>) arguments = ((filter, regEx), handles);
            GCHandle handle = GCHandle.Alloc(arguments);

            try
            {
                var wndEnumProc = new WNDENUMPROC(EnumWindow);
                User32.EnumWindows(wndEnumProc, GCHandle.ToIntPtr(handle));
            }
            finally
            {
                if (handle.IsAllocated)
                {
                    handle.Free();
                }
            }

            return handles.ToArray();
        }

        #endregion

        #region Private Methods

        private static bool EnumWindow(IntPtr hWnd, IntPtr lParam)
        {
            GCHandle gch = GCHandle.FromIntPtr(lParam);
            ((string, bool), List<IntPtr>) arguments;

            try
            {
                arguments = (((string, bool), List<IntPtr>))(gch.Target);
            }
            catch
            {
                throw;
            }

            var builder = new StringBuilder(byte.MaxValue);
            string windowName = string.Empty;

            if (User32.GetWindowText(hWnd, builder, builder.Capacity) > 0)
            {
                windowName = builder.ToString();
            }
            else
            {
                if (User32.GetClassName(hWnd, builder, builder.Capacity) > 0)
                {
                    windowName = builder.ToString();
                }
            }

            (string, bool) item1 = arguments.Item1;
            bool isMatch;
            string filter = item1.Item1;

            if (item1.Item2)
            {
                isMatch = Regex.IsMatch(windowName, filter);
            }
            else
            {
                isMatch = windowName.Contains(filter);
            }

            if (isMatch)
            {
                arguments.Item2.Add(hWnd);
            }

            return true;
        }

        #endregion
    }
}
