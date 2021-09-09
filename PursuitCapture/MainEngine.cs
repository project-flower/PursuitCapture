using PursuitCapture.Events;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win32Api;

namespace PursuitCapture
{
    public class MainEngine : Component
    {
        #region Private Fields

        private (IntPtr, Size) previous = (IntPtr.Zero, Size.Empty);

        #endregion

        #region Public Properties

        public event RequireDialogEventHandler RequireDialog = delegate { };

        #endregion

        #region Public Methods

        public Image Capture(string filter, bool regEx, Size size, string fileName)
        {
            Size prevSize = previous.Item2;
            IntPtr prevHandle = previous.Item1;
            bool matchSize = !size.IsEmpty;
            (IntPtr, Rectangle) window = (IntPtr.Zero, Rectangle.Empty);

            if ((size == prevSize) && (prevHandle != IntPtr.Zero))
            {
                Rectangle rectangle_;

                try
                {
                    rectangle_ = GetWindowRectangle(prevHandle);

                    if (!matchSize || (size == rectangle_.Size))
                    {
                        window = (prevHandle, rectangle_);
                    }
                }
                catch
                {
                }
            }

            if (window.Item1 == IntPtr.Zero)
            {
                IntPtr[] handles = WindowManager.GetWindowHandle(filter, regEx);

                foreach (IntPtr h in handles)
                {
                    Rectangle rectangle_;

                    try
                    {
                        rectangle_ = GetWindowRectangle(h);
                    }
                    catch
                    {
                        continue;
                    }

                    if (!matchSize || (rectangle_.Size == size))
                    {
                        window = (h, rectangle_);
                        break;
                    }
                }
            }

            if (window.Item1 == IntPtr.Zero)
            {
                throw new Exception("ウィンドウが見つかりません。");
            }

            Rectangle rectangle = window.Item2;
            var result = new Bitmap(rectangle.Width, rectangle.Height);

            try
            {
                using (Graphics graphics = Graphics.FromImage(result))
                {
                    try
                    {
                        Capture(rectangle, result);
                    }
                    catch
                    {
                        throw;
                    }
                }

                if (File.Exists(fileName))
                {
                    var eventArgs = new RequireDialogEventArgs($"{fileName}\r\n\r\n上書きしますか？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    RequireDialog(this, eventArgs);

                    if (eventArgs.Result != DialogResult.Yes)
                    {
                        result.Dispose();
                        return null;
                    }
                }

                result.Save(fileName, ImageFormat.Png);
                previous = (window.Item1, window.Item2.Size);
            }
            catch
            {
                result.Dispose();
                throw;
            }

            return result;
        }

        #endregion

        #region Private Methods

        private void Capture(Rectangle rectangle, Bitmap bitmap)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                try
                {
                    graphics.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, bitmap.Size);
                }
                catch
                {
                    throw;
                }
            }
        }

        private Rectangle GetWindowRectangle(IntPtr handle)
        {
            if (!User32.GetWindowRect(handle, out RECT rect))
            {
                throw new Exception(PlatformMessage.Get(Marshal.GetLastWin32Error()));
            }

            return new Rectangle(rect.Left, rect.Top, (rect.Right - rect.Left), (rect.Bottom - rect.Top));
        }

        #endregion
    }
}
