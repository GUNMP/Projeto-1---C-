using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 850)
            {
                FrmLogin frmlogin = new FrmLogin();
                frmlogin.Show(); // abre o form principal
                timer1.Stop();       // para o relógio
                this.Hide();         //fecha a janela após completar os 100%

            }

        }
    }
}
