using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projeto.Forms
{
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        string Banco = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";
       
       public static int _COMPRA;

        private void tema()
        {
            foreach (Control btn in groupBox1.Controls)
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



        void teste()
        {
            MySqlConnection sql = new MySqlConnection(Banco);

            try
            {
                sql.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na conexao do banco: " + erro.ToString());
                Application.Exit();
            }
            finally
            {
                sql.Close();
            }
        }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            teste();
            CarregarCombo();
            carregardatagrid();
            tema();
        }
        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btoLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void btoComprar_Click(object sender, EventArgs e)
        {
            if (txtObs.Text.Trim() == "")
            {
                txtObs.Text = "Sem observação";
            }

            if (cboStatus.Text == "")
            {
                MessageBox.Show("Insira um status para a compra");
                cboStatus.Focus();
                return;
            }
            if (cboFKFornecedor.Text == "")
            {
                MessageBox.Show("Insira um fornecedor para a compra");
                cboFKFornecedor.Focus();
                return;
            }
            string  sql = "INSERT INTO Compra (id_fornecedor, status_compra, obs_compra) VALUES ('" + cboCodeFK.Text + "','" + cboStatus.Text + "','" + txtObs.Text + "')";
 
            MySqlConnection praonde = new MySqlConnection(Banco);
            MySqlCommand cmd = new MySqlCommand(sql, praonde);
            cmd.CommandType = new CommandType();

            try
            {
                praonde.Open();
                int LinhaAfetada = cmd.ExecuteNonQuery();
                if (LinhaAfetada > 0)
                {
                    MessageBox.Show("Compra realizada!", "Comprado!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " +erro.ToString());
                Application.Exit();
            }
            finally
            {
                praonde.Close();
                carregardatagrid();
                txtObs.Text = "";
                
                
            }
           
            cboCodeCom.Text = DataGridCompra.CurrentRow.Cells[0].Value.ToString();
           _COMPRA = int.Parse(cboCodeCom.Text);
            
            FrmDinamicaCompra frm = new FrmDinamicaCompra();
            frm.ShowDialog();
            Limpar();

        }

        void CarregarCombo()
        {
            string sql = "select id_fornecedor, nome_fornecedor from Fornecedor";

            MySqlConnection praonde = new MySqlConnection(Banco);
            MySqlCommand cmd = new MySqlCommand(sql, praonde);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;

            DataTable tabela = new DataTable();

            praonde.Open();

            try
            {
                reader = cmd.ExecuteReader();

                tabela.Load(reader);
                cboFKFornecedor.DisplayMember = "nome_fornecedor";
                cboFKFornecedor.DataSource = tabela;

                cboCodeFK.DisplayMember = "id_fornecedor";
                cboCodeFK.DataSource = tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.ToString());
                Application.Exit();
            }
            finally
            {
                praonde.Close();
            }
        }

         void Limpar()
        {
            cboStatus.SelectedIndex = -1;
            txtObs.Text = "";
            cboCodeCom.SelectedIndex = -1;
            
            cboCodeFK.SelectedIndex = -1;
            cboFKFornecedor.SelectedIndex = -1;
            
            
            
        }
        
        private void cboStatus_Leave(object sender, EventArgs e)
        {
            if (cboStatus.Text == "")
            {
                cboStatus.Focus();
                return;
            }
        }
        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                return;
            }
        }
                                                       //ABAIXO DATAGRID
        void carregardatagrid()
        {
            string Conexao = "select  id_compra as 'ID', id_fornecedor as 'ID Fornecedor', data_compra as 'Data', status_compra as 'Status', obs_compra as 'Observação' from Compra  order by  ID_compra desc";

            MySqlConnection praonde = new MySqlConnection(Banco);
            MySqlDataAdapter adapter = new MySqlDataAdapter(Conexao, praonde);
            DataSet ds = new DataSet();
            praonde.Open();

            try
            {
                adapter.Fill(ds);
                DataGridCompra.DataSource = ds.Tables[0];
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.ToString());
            }
            finally
            {
                praonde.Close();
            }
        }

        private void txtDatagridCompra_TextChanged(object sender, EventArgs e)
        {
            carregardatagrid();
        }

        private void dataGridCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            tema();
        }
    }
}


