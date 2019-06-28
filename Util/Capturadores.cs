using System;
using System.Collections.Generic;
using System.Drawing;

namespace PStarsWrapper
{
    public static partial class Util
    {
        public static Bitmap Capturar(IntPtr handle)
        {
            var rect = new User32.RECT();
            User32.GetWindowRect(handle, ref rect);
            var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
            var result = new Bitmap(bounds.Width, bounds.Height);

            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return result;
        }

        public static Bitmap CapturarW10(IntPtr handle)
        {
            var rect = new User32.RECT();
            User32.GetWindowRect(handle, ref rect);

            // Ajustamos los bordes invisibles de W10
            rect.Bottom -= 8;
            rect.Left += 8;
            rect.Right -= 8;
            rect.Top += 1;

            var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
            var result = new Bitmap(bounds.Width, bounds.Height);

            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return result;
        }

        public static void RealizarCapturaContinuaCartas()
        {
            IEnumerable<IntPtr> ListaVentanas = Util.FindWindowsWithText("No Limit");
            foreach (IntPtr ventana in ListaVentanas)
            {
                Image img = CapturarW10(ventana);
                Bitmap carta1 = new Bitmap(29, 56);
                Bitmap carta2 = new Bitmap(29, 56);
                Rectangle RectDestinoCarta1 = new Rectangle(0, 0, carta1.Width, carta1.Height);
                Rectangle RectDestinoCarta2 = new Rectangle(0, 0, carta2.Width, carta2.Height);
                Rectangle RectOrigenCarta1 = new Rectangle(578, 619, carta1.Width, carta1.Height);
                Rectangle RectOrigenCarta2 = new Rectangle(661, 619, carta2.Width, carta2.Height);

                using (Graphics gr = Graphics.FromImage(carta1))
                {
                    gr.DrawImage(img, RectDestinoCarta1, RectOrigenCarta1, GraphicsUnit.Pixel);
                }
                using (Graphics gr = Graphics.FromImage(carta2))
                {
                    gr.DrawImage(img, RectDestinoCarta2, RectOrigenCarta2, GraphicsUnit.Pixel);
                }

                if (!ExisteImagen(carta1))
                {
                    GuardarImagenCarta(carta1);
                    carta1.Dispose();
                    Console.WriteLine("No se ha encontrado la imagen de La primera carta, se Guarda");
                }
                else Console.WriteLine("Se ha encontrado la imagen de La primera carta, no se Guarda");


                if (!ExisteImagen(carta2))
                {
                    GuardarImagenCarta(carta2);
                    carta2.Dispose();
                    Console.WriteLine("No se ha encontrado la imagen de La segunda carta, se Guarda");
                }
                else Console.WriteLine("No se ha encontrado la imagen de La primera carta, no se Guarda");
            }
        }
    }
}