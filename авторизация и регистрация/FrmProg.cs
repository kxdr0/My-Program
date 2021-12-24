using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace авторизация_и_регистрация
{
    public partial class FrmProg : Form
    {
        public FrmProg()
        {
            InitializeComponent();
        }

        private void btnScrin_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap
    (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, bmp.Size);

            pbScrin.Image = bmp;
        }

        private void pbScrin_Click(object sender, EventArgs e)
        {

        }
    }
}
