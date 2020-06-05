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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private int _code1;

        private string testa;
        private DataGridView data;
        string _sql = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";



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

        

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            tema();
            carregar();

            linha();

          
            
        }

        private void carregar()
        {
            string query = "select id_produto as 'Código', nome_produto  as 'Nome', descricao_produto as 'Descrição', peso_produto as 'Peso', tamanho_produto as 'Tamanho', qtde_produto as 'Quantidade'," +
                "preco_produto as 'Preço', status_produto as 'Status', obs_produto as 'Observação' from produto where status_produto = 'Ativo'";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
            DataSet ds = new DataSet();




            try
            {
                dt.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
                metroGrid1.Columns["Código"].Visible = false;

                for (int i = 0; i < metroGrid1.Columns.Count; i++)
                {
                    int sla = metroGrid1.Columns[i].Width;
                    metroGrid1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    metroGrid1.Columns[i].Width = sla;
                    this.metroGrid1.DefaultCellStyle.Font = new Font("Tahoma", 10);
                    this.metroGrid1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
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

        private void cat()
        {
            string query = "SELECT categoria.nome_categoria as 'Categoria' FROM produtocategoria INNER JOIN produto on produtocategoria.id_produto_produtocategoria = produto.id_produto inner JOIN categoria on produtocategoria.id_categoria_produtocategoria = categoria.id_categoria where produto.id_produto=" + txtCode.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            cmd.CommandType = CommandType.Text;



            try
            {
                my.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ltCat.Items.Add(rd.GetString(0));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                my.Close();
            }
        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            
            string obs;
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para o produto");
                txtNome.Focus();
                return;
            }
            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma Descrição para o produto");
                txtNome.Focus();
                return;
            }
            if (txtObs.Text.Trim() == "")
            {
                obs = "Sem observação";
                txtObs.Text = obs;

            }
            if (txtPeso.Text.Trim() == "")
            {
                MessageBox.Show("Insira um peso para o produto");
                txtPeso.Focus();
                return;

            }
            if (txtPreço.Text.Trim() == "")
            {
                MessageBox.Show("Insira um preço para o produto");
                txtPreço.Focus();
                return;
            }
            if (txtTamanho.Text.Trim() == "")
            {
                MessageBox.Show("Insira um tamanho para o produto");
                txtTamanho.Focus();
                return;
            }
            if (txtCode.Text == "")
            {
                MessageBox.Show("Insira um produto");
                return;
            }
            var form = new FrmProCad(int.Parse(txtCode.Text));
            _code1 = int.Parse(txtCode.Text);
           


            form.ShowDialog();
          
            carregar();

            ltCat.Items.Clear();
            cat();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public int codigo
        {
          get { return _code1; }
        }

        private void linha()
        {
            this.metroGrid1.GridColor = cores.secundaria;
            this.metroGrid1.DefaultCellStyle.ForeColor = cores.secundaria;
            cores.secundaria = cores.ChangeColorBrightness(cores.primaria, -0.2);
            this.metroGrid1.ColumnHeadersDefaultCellStyle.BackColor = cores.secundaria;
            this.metroGrid1.ColumnHeadersDefaultCellStyle.SelectionBackColor = cores.secundaria;
            cores.secundaria = cores.ChangeColorBrightness(cores.primaria, 0.55);
            this.metroGrid1.RowHeadersDefaultCellStyle.SelectionBackColor = cores.secundaria;


            this.metroGrid1.DefaultCellStyle.SelectionBackColor = cores.secundaria;
            this.metroGrid1.DefaultCellStyle.SelectionForeColor = Color.White;
        }
        private void limpar()
        {
            txtCode.Text = "";
            txtDes.Text = "";
            txtNome.Text = "";
            txtObs.Text = "";
            txtPes.Text = "";
            txtPeso.Text = "";
            txtPreço.Text = "";
            txtQtde.Text = "";
            txtTamanho.Text = "";
            comboBox1.SelectedIndex = -1;
            ltCat.Items.Clear();
            txtNome.Focus();
        }

        private void btoAlt_Click(object sender, EventArgs e)
        {
            string obs;
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para o produto");
                txtNome.Focus();
                return;
            }
            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma Descrição para o produto");
                txtNome.Focus();
                return;
            }
            if (txtObs.Text.Trim() == "")
            {
                obs = "Sem observação";
                txtObs.Text = obs;

            }
            if (txtPeso.Text.Trim() == "")
            {
                MessageBox.Show("Insira um peso para o produto");
                txtPeso.Focus();
                return;

            }
            if (txtPreço.Text.Trim() == "")
            {
                MessageBox.Show("Insira um preço para o produto");
                txtPreço.Focus();
                return;
            }
            if (txtTamanho.Text.Trim() == "")
            {
                MessageBox.Show("Insira um tamanho para o produto");
                txtTamanho.Focus();
                return;
            }

            

            string query = "update produto set nome_produto = '" + txtNome.Text + "', descricao_produto = '" + txtDes.Text + "', obs_produto = '" + txtObs.Text + "', status_produto = '" + comboBox1.Text + "'," +
                "peso_produto = '"+txtPeso.Text+ "',tamanho_produto= '"+txtTamanho.Text+ "',preco_produto= '"+txtPreço.Text+"' where id_produto = " + txtCode.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Alteração realizada com sucesso");
                   

                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o Produto");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                limpar();
                carregar();


            }
        }

        private void btoDel_Click(object sender, EventArgs e)
        {
            string obs;
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para o produto");
                txtNome.Focus();
                return;
            }
            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma Descrição para o produto");
                txtNome.Focus();
                return;
            }
            if (txtObs.Text.Trim() == "")
            {
                obs = "Sem observação";
                txtObs.Text = obs;

            }
            if (txtPeso.Text.Trim() == "")
            {
                MessageBox.Show("Insira um peso para o produto");
                txtPeso.Focus();
                return;

            }
            if (txtPreço.Text.Trim() == "")
            {
                MessageBox.Show("Insira um preço para o produto");
                txtPreço.Focus();
                return;
            }
            if (txtTamanho.Text.Trim() == "")
            {
                MessageBox.Show("Insira um tamanho para o produto");
                txtTamanho.Focus();
                return;
            }

            string query = "DELETE FROM produto WHERE id_produto=" + txtCode.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Produto deletado com sucesso");
                    metroGrid1.Update();
                    metroGrid1.Refresh();
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o produto");
                }
            }
            catch (MySqlException ex)
            {

                

                if (ex.Number == 1451)
                {
                    string tei = "update produto set status_produto= 'Inativo' where id_produto= "+ txtCode.Text ;
                    MySqlConnection mi = new MySqlConnection(_sql);
                    MySqlCommand cm = new MySqlCommand(tei, mi);
                    try
                    {
                        mi.Open();
                        int z = cm.ExecuteNonQuery();
                        if (z > 0)
                        {
                            MessageBox.Show("Produto deletado com sucesso");
                           
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível deletar o produto");
                        }
                    }
                    catch (MySqlException exx)
                    {

                        MessageBox.Show(exx.Message);
                        

                    }
                }
            }
            finally
            {
                limpar();
                carregar();
            }
        }

    
        private void txtPes_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (txtPes.Text.Trim() == "")
            {
                sql = "select id_produto as 'Código', nome_produto  as 'Nome', descricao_produto as 'Descrição', peso_produto as 'Peso', tamanho_produto as 'Tamanho', qtde_produto as 'Quantidade'," +
                "preco_produto as 'Preço', status_produto as 'Status', obs_produto as 'Observação' from produto";
            }
            else
            {
                sql = "select id_produto as 'Código', nome_produto  as 'Nome', descricao_produto as 'Descrição', peso_produto as 'Peso', tamanho_produto as 'Tamanho', qtde_produto as 'Quantidade'," +
                "preco_produto as 'Preço', status_produto as 'Status', obs_produto as 'Observação' from produto where nome_produto like '%" + txtPes.Text + "%'";


            }


            MySqlConnection con = new MySqlConnection(_sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);

            DataSet ds = new DataSet();

            con.Open();

            try
            {
                adapter.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];

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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ltCat.Items.Clear();
            cat();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btoCad_Click_1(object sender, EventArgs e)
        {
            

            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para o produto");
                txtNome.Focus();
                return;
            }
            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma Descrição para o produto");
                txtNome.Focus();
                return;
            }
          
            if (txtPeso.Text.Trim() == "")
            {
                MessageBox.Show("Insira um peso para o produto");
                txtPeso.Focus();
                return;

            }
            if (txtPreço.Text.Trim() == "")
            {
                MessageBox.Show("Insira um preço para o produto");
                txtPreço.Focus();
                return;
            }
            if (txtTamanho.Text.Trim() == "")
            {
                MessageBox.Show("Insira um tamanho para o produto");
                txtTamanho.Focus();
                return;
            }
            if (txtObs.Text.Trim() == "")
            {
                txtObs.Text = "Sem observação";
            }
            string q = "insert into produto (nome_produto,descricao_produto,peso_produto,tamanho_produto,qtde_produto,preco_produto,status_produto,obs_produto) values ('" + txtNome.Text + "'," +
                "'" + txtDes.Text + "', '" + txtPeso + "', '" + txtTamanho.Text + "', '" + 0 + "', '" + txtPreço.Text + "', '" + comboBox1.Text + "', '" + txtObs.Text + "') ";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(q, my);
            txtObs.Text = "";
            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    

                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro");
                }
            }
            catch (MySqlException ex)
            {

                if (ex.Number == 1062)
                {
                    if (txtObs.Text.Trim() == "")
                    {
                        txtObs.Text = "Sem observação";
                    }
                    string tei = "update produto set nome_produto = '" + txtNome.Text + "', descricao_produto = '" + txtDes.Text + "', obs_produto = '" + txtObs.Text + "', status_produto = 'Ativo'," +
                "peso_produto = '" + txtPeso.Text + "',tamanho_produto= '" + txtTamanho.Text + "',preco_produto= '" + txtPreço.Text + "' where nome_produto= '" + txtNome.Text+"'";
                    MySqlConnection mi = new MySqlConnection(_sql);
                    MySqlCommand cm = new MySqlCommand(tei, mi);
                    try
                    {
                        mi.Open();
                        int z = cm.ExecuteNonQuery();
                        if (z > 0)
                        {
                            MessageBox.Show("Produto cadastrado com sucesso");

                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar o produto");
                        }
                    }
                    catch (MySqlException exx)
                    {

                        MessageBox.Show(exx.Message);


                    }
                }
            }
            finally
            {
                limpar();
               
                carregar();
                txtObs.Text = "";


            }
        }

        private void ltCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtDes.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            txtPeso.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            txtTamanho.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
            txtPreço.Text = metroGrid1.CurrentRow.Cells[6].Value.ToString();
            comboBox1.Text = metroGrid1.CurrentRow.Cells[7].Value.ToString();
            txtObs.Text = metroGrid1.CurrentRow.Cells[8].Value.ToString();
            ltCat.Items.Clear();
            cat();

        }
    }
}
