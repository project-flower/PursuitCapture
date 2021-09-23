using System;
using System.Runtime.InteropServices;

namespace Win32Api
{
    public static class CSIDL
    {
        /// <summary>&lt;desktop&gt;</summary>
        public const int DESKTOP = 0x0000;
        /// <summary>Internet Explorer (icon on desktop)</summary>
        public const int INTERNET = 0x0001;
        /// <summary>Start Menu\Programs</summary>
        public const int PROGRAMS = 0x0002;
        /// <summary>My Computer\Control Panel</summary>
        public const int CONTROLS = 0x0003;
        /// <summary>My Computer\Printers</summary>
        public const int PRINTERS = 0x0004;
        /// <summary>My Documents</summary>
        public const int PERSONAL = 0x0005;
        /// <summary>&lt;user name&gt;\Favorites</summary>
        public const int FAVORITES = 0x0006;
        /// <summary>Start Menu\Programs\Startup</summary>
        public const int STARTUP = 0x0007;
        /// <summary>&lt;user name&gt;\Recent</summary>
        public const int RECENT = 0x0008;
        /// <summary>&lt;user name&gt;\SendTo</summary>
        public const int SENDTO = 0x0009;
        /// <summary>&lt;desktop&gt;\Recycle Bin</summary>
        public const int BITBUCKET = 0x000a;
        /// <summary>&lt;user name&gt;\Start Menu</summary>
        public const int STARTMENU = 0x000b;
        /// <summary>Personal was just a silly name for My Documents</summary>
        public const int MYDOCUMENTS = PERSONAL;
        /// <summary>"My Music" folder</summary>
        public const int MYMUSIC = 0x000d;
        /// <summary>"My Videos" folder</summary>
        public const int MYVIDEO = 0x000e;
        /// <summary>&lt;user name&gt;\Desktop</summary>
        public const int DESKTOPDIRECTORY = 0x0010;
        /// <summary>My Computer</summary>
        public const int DRIVES = 0x0011;
        /// <summary>Network Neighborhood (My Network Places)</summary>
        public const int NETWORK = 0x0012;
        /// <summary>&lt;user name&gt;\nethood</summary>
        public const int NETHOOD = 0x0013;
        /// <summary>windows\fonts</summary>
        public const int FONTS = 0x0014;
        public const int TEMPLATES = 0x0015;
        /// <summary>All Users\Start Menu</summary>
        public const int COMMON_STARTMENU = 0x0016;
        /// <summary>All Users\Start Menu\Programs</summary>
        public const int COMMON_PROGRAMS = 0X0017;
        /// <summary>All Users\Startup</summary>
        public const int COMMON_STARTUP = 0x0018;
        /// <summary>All Users\Desktop</summary>
        public const int COMMON_DESKTOPDIRECTORY = 0x0019;
        /// <summary>&lt;user name&gt;\Application Data</summary>
        public const int APPDATA = 0x001a;
        /// <summary>&lt;user name&gt;\PrintHood</summary>
        public const int PRINTHOOD = 0x001b;
    }

    public static partial class Shell32
    {
        #region Public Methods

        [DllImport(AssemblyName)]
        public static extern int SHCreateShellItem(IntPtr pidlParent, IntPtr psfParent, IntPtr pidl, out IShellItem ppsi);

        [DllImport(AssemblyName)]
        public static extern int SHGetSpecialFolderLocation(IntPtr hwnd, int csidl, out IntPtr ppidl);

        [DllImport(AssemblyName)]
        public static extern int SHILCreateFromPath([MarshalAs(UnmanagedType.LPWStr)] string pszPath, out IntPtr ppIdl, ref uint rgflnOut);

        #endregion
    }
}
