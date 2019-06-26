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

        private void btnCapturarPulsado(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy && backgroundWorker1.WorkerSupportsCancellation)
            {
                backgroundWorker1.CancelAsync();
                btnCaptura.Text = "WorkerCancelado";
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                btnCaptura.Text = "WorkerComenzando";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCaptura.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Util.ObtenerTodosLosArchivos(Util.ruta).Count < 54)
            {
                Util.RealizarCapturaContinuaCartas();
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnCaptura.Text = "Finalizado!!!";
        }
    }
}
