// Conteúdo corrigido para app8/frmPrincipal.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app8
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmUsuario frmuser = new FmUsuario();
            frmuser.ShowDialog();
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmGenero frmgen = new fmGenero();
            frmgen.ShowDialog();
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCinema frmcinema = new fmCinema();
            frmcinema.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CORREÇÃO: Usar 'frmRoom'
            frmRoom frmroom = new frmRoom();
            frmroom.ShowDialog();
        }
    }
}