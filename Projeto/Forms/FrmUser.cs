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

namespace Projeto.Forms
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void linha()
        {
            this.dataGridView1.GridColor = cores.secundaria;
            this.dataGridView1.DefaultCellStyle.ForeColor = cores.secundaria;
        }

        private void tema()
        {
            foreach (Control btn in this.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    Button btns = (Button)btn;
                    btns.BackColor = cores.primaria;
                    btns.ForeColor = Color.White;
                    btns.FlatAppearance.BorderColor = cores.secundaria;
                }
            }
        }

        string _sql = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";

        private void FrmUser_Load(object sender, EventArgs e)
        {
            tema();
            linha();
            carregar();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void carregar()
        {
            string query = "select id_usuario as 'Código', pessoa_usuario as 'Nome', nome_usuario as 'Usuário', senha_usuario as 'Senha' from usuario where nome_usuario != 'admin'";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
            DataSet ds = new DataSet();




            try
            {
                dt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["Código"].Visible = false;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    int sla = dataGridView1.Columns[i].Width;
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[i].Width = sla;
                    this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
                    this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);


                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                my.Close();
            }
        }
        
        void limpar()
        {
            txtCode.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtUser.Text = "";
            txtNome.Focus();
        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para o usuário", "Erro");
                txtNome.Focus();
                return;
            }
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Insira um usuário", "Erro");
                txtUser.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma senha para o usuário", "Erro");
                txtSenha.Focus();
                return;
            }
            string query = "insert into usuario (pessoa_usuario,nome_usuario,senha_usuario) values ('"+txtNome.Text+"','"+txtUser.Text+"','"+txtSenha.Text+"')";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            cmd.CommandType = CommandType.Text;

            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso", "Atenção");
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar o cadastro");
                }
            }
            catch (MySqlException ex)
            {

                if (ex.Number == 1062)
                {
                    MessageBox.Show("Usuário já existente");
                }
            }
            finally
            {
                my.Close();
                limpar();
                carregar();
            }
        }

        private void btoAlt_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para o usuário", "Erro");
                txtNome.Focus();
                return;
            }
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Insira um usuário", "Erro");
                txtUser.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma senha para o usuário", "Erro");
                txtSenha.Focus();
                return;
            }
            string query = "update usuario set pessoa_usuario = '" + txtNome.Text + "',nome_usuario = '" + txtUser.Text + "',senha_usuario = '" + txtSenha.Text + "' where id_usuario =" + txtCode.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            cmd.CommandType = CommandType.Text;

            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Alteração Realizada com Sucesso", "Atenção");
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar a alteração");
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                my.Close();
                limpar();
                carregar();
                
            }
        }

        private void btoDel_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para o usuário", "Erro");
                txtNome.Focus();
                return;
            }
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Insira um usuário", "Erro");
                txtUser.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma senha para o usuário", "Erro");
                txtSenha.Focus();
                return;
            }
            string query = "delete from usuario where id_usuario = " + txtCode.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            cmd.CommandType = CommandType.Text;

            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Usuário deletado com sucesso", "Atenção");
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir o usuário");
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                my.Close();
                limpar();
                carregar();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUser.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }



    
}
