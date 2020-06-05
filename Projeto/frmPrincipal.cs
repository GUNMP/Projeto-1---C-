using MySql.Data.MySqlClient;
using MySql.Data;
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

namespace Projeto
{
    public partial class frmPrincipal : Form
    {
        private Button botao;
        private Random random;
        private int temp;
        private Form ativar;
        private string _sql = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";

        public static string _us;
        public frmPrincipal()
        {
            InitializeComponent();
            random = new Random();
            btoVoltar.Visible = false;
            this.Text = string.Empty;
            FrmLogin frm = new FrmLogin();
           


            if (this.MaximizedBounds == Screen.FromHandle(this.Handle).WorkingArea)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            testar();

        }

        private void testar()
        {
            try
            {
                MySqlConnection cx = new MySqlConnection(sql);
                cx.Open();
                cx.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());  
            }
            finally
            {
                
            }
            
        }

        private void max()
        {
            if (this.MaximizedBounds == Screen.FromHandle(this.Handle).WorkingArea)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(cores.color.Count);
            while (temp == index)
            {
                index = random.Next(cores.color.Count);
            }
            temp = index;
            string color = cores.color[index];
            return ColorTranslator.FromHtml(color);
        }

        public string sql
        {
            get { return _sql; }
        }



        private void ativarbto(object btn)
        {
            if (btn != null)
            {
                if (botao != (Button)btn)
                {
                    disable();
                    Color color = SelectThemeColor();
                    botao = (Button)btn;
                    botao.BackColor = color;
                    botao.ForeColor = Color.White;
                    botao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTit.BackColor = color;
                    PanelLogo.BackColor = cores.ChangeColorBrightness(color, -0.3);
                    cores.primaria = color;
                    cores.secundaria = cores.ChangeColorBrightness(color, -0.3);
                    btoVoltar.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form abrir, object bto)
        {
            if (ativar != null)
            {
                ativar.Close();                                          
            }
            ativarbto(bto);
            ativar = abrir;
            abrir.TopLevel = false;
            abrir.FormBorderStyle = FormBorderStyle.None;
            abrir.Dock = DockStyle.Fill;
            this.panelPrograma.Controls.Add(abrir);
            this.panelPrograma.Tag = abrir;
            abrir.BringToFront();
            abrir.Show();
            lblTil.Text = abrir.Text;

        }

        private void disable()
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(51, 51, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

      

       
         
      

    

        

        
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btoProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmProdutos(), sender);
        }

        private void btoCategoria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmCategoria(), sender);
        }

        private void btoCompra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmCompra(), sender);
        }

        private void btoFornecedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmFornecedor(), sender);
        }

        private void btoHistorico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmHistorico(), sender);
        }

        private void btoVoltar_Click(object sender, EventArgs e)
        {
            if (ativar != null)
            {
                ativar.Close();
                reset();
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        private  void reset()
        {
            disable();
            lblTil.Text = "HOME";
            panelTit.BackColor = Color.FromArgb(254, 0, 0);
            PanelLogo.BackColor = Color.FromArgb(39, 39, 58);
            botao = null;
            btoVoltar.Visible = false;
        }
        
       

        private void panelTit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btoMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (_us == "admin")
            {
                btoUser.Visible = true;
            }
        }

        private void btoUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmUser(), sender);
        }
    }
}
