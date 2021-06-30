using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dias_de_Vida
{
    public partial class frmAnosdeIdade : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
              int left,
              int top,
              int right,
              int bottom,
              int width,
              int height
          );
        public frmAnosdeIdade()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void btnDescobrirIdade_Click(object sender, EventArgs e)
        {
            int anasc, ano, calc;

            anasc = Convert.ToInt32(txtAnodeNasc.Text);
            ano = Convert.ToInt32(txtAnoAtual.Text);

            calc =  ano - anasc;
      

            txtResultado.Text = Convert.ToString(calc);
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            txtAnodeNasc.Clear();
            txtAnoAtual.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
