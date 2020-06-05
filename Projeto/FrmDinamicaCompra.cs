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
    public partial class FrmDinamicaCompra : Form
    {
        public FrmDinamicaCompra()
        {
            InitializeComponent();
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
        public static string Banco = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";
        float preco;
        int qtde;
        
        

      

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

        private void FrmDinamicaCompra_Load(object sender, EventArgs e)
        {
            teste();
            tema();
            CarregarCombo();
            
            txtIDCompra.Text = FrmCompra._COMPRA.ToString();
            
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                return;
            }

            if (e.KeyChar >= 33 && e.KeyChar < 64)
            {
                e.Handled = true;
            }
        }

        

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }

            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            
                     
            
        }

        private void cboValor_Leave(object sender, EventArgs e)
        {
            
        }

       

       

        void CarregarCombo()
        {
            string sql = "select id_produto, nome_produto,preco_produto from Produto";

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
                cboNomePrdo.DisplayMember = "nome_produto";
                cboNomePrdo.DataSource = tabela;

                cboCodePro.DisplayMember = "id_produto";
                cboCodePro.DataSource = tabela;

                cboValor.DisplayMember = "preco_produto";
                cboValor.DataSource = tabela;

               

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

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }

            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }
        private void txtQtde_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQtde.Text, out qtde))
            {
                MessageBox.Show("Insira uma quantidade válida", "Erro");
                return;
            }

            if (!float.TryParse(cboValor.Text, out preco))
            {
                return;
            }

            txtTotal.Text = (preco * qtde).ToString();
           
           
        }

        private void btoAdicionar_Click(object sender, EventArgs e)
        {
            if (cboNomePrdo.SelectedIndex == -1)
            {
                MessageBox.Show("Nome inválido", "Erro");
                cboValor.Focus();
                return;
            }
            if (cboValor.SelectedIndex == -1)
            {
                MessageBox.Show("Valor inválido", "Erro");
                cboValor.Focus();
                return;
            }
            if (txtQtde.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma quantidade", "Erro");
                txtQtde.Focus();
                return;
            }
            if (txtTotal.Text.Trim() == "")
            {
                MessageBox.Show("Total inválido", "Erro");
                txtQtde.Focus();
                return;
            }
          
           
            string sql = "INSERT INTO ItemCompra (id_produto_itemcompra, id_compra_itemcompra, valor_itemcompra, qtde_itemcompra) VALUES ('" + cboCodePro.Text + "', '" + txtIDCompra.Text + "', '" + cboValor.Text + "', '" + txtQtde.Text + "')";
                


            MySqlConnection praonde = new MySqlConnection(Banco);
            MySqlCommand cmd = new MySqlCommand(sql, praonde);
            cmd.CommandType = new CommandType();

            try
            {
                praonde.Open();
                int LinhaAfetada = cmd.ExecuteNonQuery();
                if (LinhaAfetada > 0)
                {
                    MessageBox.Show("Item adicionado!", "Adição realizada!");
                }
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

           string dale =  "update produto set qtde_produto = qtde_produto + " + txtQtde.Text + " where id_produto = " + cboCodePro.Text;


           
            MySqlCommand cm = new MySqlCommand(dale, praonde);
            cm.CommandType = new CommandType();

            try
            {
                praonde.Open();
                int Linha = cm.ExecuteNonQuery();
               
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


            string query = "update compra set valor_compra = valor_compra + "+txtTotal.Text+"  where id_compra= " + txtIDCompra.Text;



            MySqlCommand c = new MySqlCommand(query, praonde);
            c.CommandType = new CommandType();

            try
            {
                praonde.Open();
                int a = c.ExecuteNonQuery();

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

            cboValor.SelectedIndex = -1;
            txtQtde.Text = "";
            txtTotal.Text = "";
            cboCodePro.SelectedIndex = -1;
            cboNomePrdo.SelectedIndex = -1;
            
           
           
        }
    }
}
