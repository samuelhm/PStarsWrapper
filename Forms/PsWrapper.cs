using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PStarsWrapper;
using System.Threading;
using System.IO;

namespace PStarsWrapper.MisForms
{
    public partial class PsWrapper : Form
    {
        IEnumerable<IntPtr> ListaVentanas = Util.FindWindowsWithText("No Limit");

        public PsWrapper()
        {
            
            InitializeComponent();
            
            
        }

        private void PsWrapper_Load(object sender, EventArgs e)
        {
            LLenarListBox();
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Util.ObtenerTodosLosArchivos(Util.ruta).Count < 54)
            {
                Util.RealizarCapturaCartas();
                Thread.Sleep(3000);
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                IntPtr handle = Util.FindWindowsWithText(listBox1.SelectedItem.ToString()).First();
                Util.MoverVentana(handle, 1170, 835);
            }
        }

        private void obtenerSizeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                IntPtr handle = Util.FindWindowsWithText(listBox1.SelectedItem.ToString()).First();
                User32.RECT r = new User32.RECT();
                User32.GetWindowRect(handle, ref r);
                this.label1.Text = "Width = " + (r.Right - r.Left) + "Height = " + (r.Bottom - r.Top);
            }
        }

        private void capturarBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                using (Bitmap b = Util.CapturarW10(Util.FindWindowsWithText(listBox1.SelectedItem.ToString()).First()))
                {
                    int i = 0;
                    while (File.Exists(Util.ruta + "captura" + i.ToString() + ".bmp"))
                    {
                        i++;
                    }
                    b.Save(Util.ruta+"captura"+i.ToString()+".bmp");
                }
            }
        }

        private void btnCapCartas_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                IntPtr ventana = Util.FindWindowsWithText(listBox1.SelectedItem.ToString()).First();
                Util.RealizarCapturaCartas(ventana);
            }
        }
    }
}
