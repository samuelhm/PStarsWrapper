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
        public static bool ExisteImagen(Image img)
        {
            
            List<String> ListaArchivos = ObtenerTodosLosArchivos(ruta);
            List<Image> ListaImagenes = new List<Image>();
            foreach (string ruta in ListaArchivos)
            {
                Image i = Image.FromFile(ruta);
                ListaImagenes.Add(i);
            }
            bool buffer = true;
            foreach (Image i in ListaImagenes)
            {
                if (i.Width == img.Width && i.Height == img.Height)
                {
                    Bitmap b1 = new Bitmap(i);
                    Bitmap b2 = new Bitmap(img);
                    
                    for (int h = 0; h < b1.Width; h++)
                    {
                        for (int j = 0; j < b1.Height; j++)
                        {
                            if (b1.GetPixel(h, j).ToString() == b2.GetPixel(h, j).ToString())
                            {
                                string a = b1.GetPixel(h, j).ToString();
                                string b = b2.GetPixel(h, j).ToString();
                            }
                            else
                            {
                                string a = b1.GetPixel(h, j).ToString();
                                string b = b2.GetPixel(h, j).ToString();
                                buffer = false;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error, Tamaños de imagen no Son Iguales.");
                    return false;
                }
                
            }
            if (buffer) Console.WriteLine("Imagen Exacta encontrada!");
            if (!buffer) Console.WriteLine("Imagen Discordante!");

            Util.MostrarImagen(img);
            return buffer;
            
        }

        public static List<string> ObtenerTodosLosArchivos(string ruta)
        {
            ruta += "Cartas\\";
            List<string> lista = new List<string>();
            lista.AddRange(Directory.GetFiles(ruta));
            return lista;
        }
    }


}
