using System;
using System.Collections.Generic;
using System.Drawing;

namespace PStarsWrapper
{
    public static partial class Util
    {
        public struct PosSizes
        {
            public struct CardSize
            {
                public static int width = 59;
                public static int height = 30;
            }

            public static Point posCarta1 = new Point(512, 536);
            public static Point posCarta2 = new Point(584, 536);
            public static Rectangle RectDestinoCarta1 = new Rectangle(0, 0, CardSize.width, CardSize.height);
            public static Rectangle RectDestinoCarta2 = new Rectangle(0, 0, CardSize.width, CardSize.height);
            public static Rectangle RectOrigenCarta1 = new Rectangle(posCarta1.X, posCarta1.Y, CardSize.width, CardSize.height);
            public static Rectangle RectOrigenCarta2 = new Rectangle(posCarta2.X, posCarta2.Y, CardSize.width, CardSize.height);
        }

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

        public static void RealizarCapturaCartas()
        {
            IEnumerable<IntPtr> ListaVentanas = Util.FindWindowsWithText("No Limit");
            foreach (IntPtr ventana in ListaVentanas)
            {
                Image img = CapturarW10(ventana);
                Bitmap carta1 = new Bitmap(PosSizes.CardSize.width, PosSizes.CardSize.height);
                Bitmap carta2 = new Bitmap(PosSizes.CardSize.width, PosSizes.CardSize.height);

                using (Graphics gr = Graphics.FromImage(carta1))
                {
                    gr.DrawImage(img, PosSizes.RectDestinoCarta1, PosSizes.RectOrigenCarta1, GraphicsUnit.Pixel);
                }
                using (Graphics gr = Graphics.FromImage(carta2))
                {
                    gr.DrawImage(img, PosSizes.RectDestinoCarta2, PosSizes.RectOrigenCarta2, GraphicsUnit.Pixel);
                }

                if (!ExisteImagen(carta1))
                {
                    GuardarImagenCarta(carta1);
                    carta1.Dispose();
                    Console.WriteLine("No Se ha encontrado la imagen de La primera carta, se Guarda");
                }
                else Console.WriteLine("Se ha encontrado la imagen de La primera carta, no se Guarda");

                if (!ExisteImagen(carta2))
                {
                    GuardarImagenCarta(carta2);
                    carta2.Dispose();
                    Console.WriteLine("No se ha encontrado la imagen de La segunda carta, se Guarda");
                }
                else Console.WriteLine("Se ha encontrado la imagen de La segunda carta, no se Guarda");
            }
        }

        public static void RealizarCapturaCartas(IntPtr handle)
        {

            Image img = CapturarW10(handle);
            Bitmap carta1 = new Bitmap(PosSizes.CardSize.width, PosSizes.CardSize.height);
            Bitmap carta2 = new Bitmap(PosSizes.CardSize.width, PosSizes.CardSize.height);

            using (Graphics gr = Graphics.FromImage(carta1))
            {
                gr.DrawImage(img, PosSizes.RectDestinoCarta1, PosSizes.RectOrigenCarta1, GraphicsUnit.Pixel);
            }
            using (Graphics gr = Graphics.FromImage(carta2))
            {
                gr.DrawImage(img, PosSizes.RectDestinoCarta2, PosSizes.RectOrigenCarta2, GraphicsUnit.Pixel);
            }

            if (!ExisteImagen(carta1))
            {
                GuardarImagenCarta(carta1);
                carta1.Dispose();
                Console.WriteLine("No Se ha encontrado la imagen de La primera carta, se Guarda");
            }
            else Console.WriteLine("Se ha encontrado la imagen de La primera carta, no se Guarda");

            if (!ExisteImagen(carta2))
            {
                GuardarImagenCarta(carta2);
                carta2.Dispose();
                Console.WriteLine("No se ha encontrado la imagen de La segunda carta, se Guarda");
            }
            else Console.WriteLine("Se ha encontrado la imagen de La segunda carta, no se Guarda");
        }
    }
}