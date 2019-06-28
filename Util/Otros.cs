using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PStarsWrapper
{ 
    public  partial class Util
    {
        public static string ruta = @"D:\Pruebas\";
        public static void MostrarImagen(Image i)
        {
            Application.Run(new MisForms.VistaImagen(i));
        }
        public static void GuardarImagen (Image i)
        {
            i.Save(ruta + Guid.NewGuid().ToString() + ".bmp");
        }
        public static void GuardarImagenCarta(Image i)
        {
            i.Save(ruta + "Cartas\\" + Guid.NewGuid().ToString() + ".bmp");
        }
        public static bool ExisteImagen(Bitmap bmp)
        {
            List<String> ListaArchivos = ObtenerTodosLosArchivos(ruta);
            List<Bitmap> ListaImagenes = new List<Bitmap>();
            foreach (string path in ListaArchivos)
            {
                Bitmap i = new Bitmap(path);
                ListaImagenes.Add(i);
            }
            
            foreach (Bitmap b in ListaImagenes)
            {
                if (CompareBitmapsLazy(bmp, b)) return true;
            }
            // Si no ha retornado true, encontrando una imagen, entoces no existe, retornamos false
            Console.WriteLine("La Imagen no corresponde con La imagen destino.");
            return false;
            
        }

        public static List<string> ObtenerTodosLosArchivos(string ruta)
        {
            ruta += "Cartas\\";
            List<string> lista = new List<string>();
            lista.AddRange(Directory.GetFiles(ruta));
            return lista;
        }
        public static bool CompareBitmapsLazy(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1 == null || bmp2 == null)
                return false;
            if (object.Equals(bmp1, bmp2))
                return true;
            if (!bmp1.Size.Equals(bmp2.Size) || !bmp1.PixelFormat.Equals(bmp2.PixelFormat))
                return false;

            //Compare bitmaps using GetPixel method
            for (int column = 0; column < bmp1.Width; column++)
            {
                for (int row = 0; row < bmp1.Height; row++)
                {
                    if (!bmp1.GetPixel(column, row).Equals(bmp2.GetPixel(column, row)))
                        return false;
                }
            }

            return true;
        }
    }


}
