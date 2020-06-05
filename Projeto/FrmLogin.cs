using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Projeto
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string us;
        private MySqlConnection CX;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            teste();
        }
        private string connectionString = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";
        void teste()
        {
            string connectionString;
            connectionString = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";

            CX = new MySqlConnection(connectionString);

            try
            {
                CX.Open();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possível conectar ao servidor");

                if (ex.Number == 1042)
                {
                    
                    Application.Exit();
                    
                }
            }
            finally
            {
                CX.Close();
            }

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btoEntrar_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where nome_usuario ='" + txtUser.Text + "' and senha_usuario= '" + txtSenha.Text+ "'";
            frmPrincipal._us = txtUser.Text;
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader leitura;
            con.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    frmPrincipal frm = new frmPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
       
    }
}
