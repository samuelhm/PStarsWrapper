using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PStarsWrapper
{
    public partial class Util
    {
        public static string ObtenerNombreVentana(IntPtr handle)
        {
            int size = User32.GetWindowTextLength(handle);
            if (size > 0)
            {
                var builder = new StringBuilder(size + 1);
                User32.GetWindowText(handle, builder, builder.Capacity);
                return builder.ToString();
            }
            else
            {
                return String.Empty;
            }
        }
        public static IEnumerable<IntPtr> FindWindows(User32.EnumWindowsProc filter)
        {
            IntPtr found = IntPtr.Zero;
            List<IntPtr> windows = new List<IntPtr>();

            User32.EnumWindows(delegate (IntPtr wnd, IntPtr param)
            {
                if (filter(wnd, param))
                {
                    // Añade la ventana a la lista, si pasa el filtro
                    windows.Add(wnd);
                }

                // but return true here so that we iterate all windows
                return true;
            }, IntPtr.Zero);

            return windows;
        }
        public static IEnumerable<IntPtr> FindWindowsWithText(string titulo)
        {
            return FindWindows(  delegate (IntPtr wnd, IntPtr param){ return ObtenerNombreVentana(wnd).Contains(titulo);}   );
        }
        public static bool MoverVentana(IntPtr handle,int width,int height)
        {
            User32.RECT r = new User32.RECT();
            User32.GetWindowRect(handle, ref r);
            return User32.MoveWindow(handle, r.Left, r.Top, width, height, true);
        }
        public static bool MoverVentana(IntPtr handle,int x,int y, int width, int height)
        {
            return User32.MoveWindow(handle, x, y, width, height, true);
        }
    }
}