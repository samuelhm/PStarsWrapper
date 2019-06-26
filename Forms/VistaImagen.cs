using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PStarsWrapper.MisForms
{
    public partial class VistaImagen : Form
    {
        public VistaImagen(Image i)
        {
            InitializeComponent();
            cajaImagen.Image = i;
            this.Size = new Size(i.Width, i.Height);
        }

        private void cajaImagen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
