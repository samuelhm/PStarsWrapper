using System;
using System.Collections.Generic;
using System.Text;
using PStarsWrapper.Entidades;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
namespace PStarsWrapper
{
    static class Consola
    {
        

        public static void Main()
        {

            /*
            IEnumerable<IntPtr> ListaVentanas = Util.FindWindowsWithText("No Limit");
            Stack<IntPtr> ListaVentanasPoker = new Stack<IntPtr>();
            foreach (IntPtr ventana in ListaVentanas)
            {
                ListaVentanasPoker.Push(ventana);
            }
            foreach (var ventana in ListaVentanasPoker)
            {
                
                Thread hilo = new Thread(new ThreadStart(Util.RealizarCapturaContinuaCartas));
                hilo.Start();
            }
            Console.WriteLine("Hola!");
            //*/Application.Run(new MisForms.PsWrapper());
        }
    }
}
