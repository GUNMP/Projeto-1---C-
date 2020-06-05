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
using MySql.Data;

namespace Projeto.Forms
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
            
        }

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

        private void tema2()
        {
            foreach (Control cbo in this.Controls)
            {
                if (cbo.GetType() == typeof(ComboBox))
                {
                    ComboBox btns = (ComboBox)cbo;
                    btns.BackColor = cores.terceira;
                    btns.ForeColor = cores.terceira;
                    
                }
            }
        }

        private void btoDel_Click(object sender, EventArgs e)
        {
            string obs;
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para a categoria", "Erro");
                txtNome.Focus();
                return;
            }

            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma descrição para a categoria", "Erro");
                txtDes.Focus();
                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Insira um status para a categoria", "Erro");
                cboStatus.Focus();
                return;
            }

            if (txtObs.Text.Trim() == String.Empty)
            {
                obs = "Sem observação";
                txtObs.Text = obs;

            }
            string query = "DELETE FROM categoria WHERE id_categoria=" + txtCode.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Categoria deletada com sucesso");
                    metroGrid1.Update();
                    metroGrid1.Refresh();
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar a categoria");
                }
            }
            catch (MySqlException ex)
            {


                if (ex.Number == 1451)
                {
                    MessageBox.Show("Existe produtos ligado a essa categoria", "Erro");

                }
            }
            finally
            {
                limpar();
                metroGrid1.Update();
                metroGrid1.Refresh();
                carregar();
            }

        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            string obs;
          

            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para a categoria", "Erro");
                txtNome.Focus();
                return;
            }

            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma descrição para a categoria", "Erro");
                txtDes.Focus();
                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Insira um status para a categoria", "Erro");
                cboStatus.Focus();
                return;
            }

            if (txtObs.Text.Trim() == String.Empty)
            {
                obs = "Sem observação";
                txtObs.Text = obs;

            }
            string query = "INSERT INTO categoria (nome_categoria,descricao_categoria, status_categoria, obs_categoria) VALUES ('"+txtNome.Text+"', '"+txtDes.Text+"',  '"+cboStatus.Text+"', '"+txtObs.Text+"')";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            txtObs.Text = "";
            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    metroGrid1.Update();
                    metroGrid1.Refresh();

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
                    string tei = "update categoria set nome_categoria = '" + txtNome.Text + "', descricao_categoria = '" + txtDes.Text + "', obs_categoria = '" + txtObs.Text + "', status_categoria = '" + cboStatus.Text + "' where nome_categoria= '" + txtNome.Text + "'";
                    MySqlConnection mi = new MySqlConnection(_sql);
                    MySqlCommand cm = new MySqlCommand(tei, mi);
                    try
                    {
                        mi.Open();
                        int z = cm.ExecuteNonQuery();
                        if (z > 0)
                        {
                            MessageBox.Show("Categoria cadastrado com sucesso");

                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar a categoria");
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
                metroGrid1.Update();
                metroGrid1.Refresh();
                carregar();


            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            tema();
            carregar();
            linha();
            tema2();
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
            txtNome.Text = "";
            txtDes.Text = "";
            cboStatus.SelectedIndex = -1;
            txtObs.Text = "";
            txtNome.Focus();
            
        }

        private void  carregar()
        {
            string query = "select id_categoria as 'Código' ,nome_categoria as 'Nome', descricao_categoria as 'Descrição', status_categoria as 'Status', obs_categoria as 'Observação' from categoria where status_categoria = 'Ativo'";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
            DataSet ds = new DataSet();


            

            try
            {
                dt.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
                this.metroGrid1.Columns["Código"].Visible = false;
                
                    this.metroGrid1.DefaultCellStyle.Font = new Font("Tahoma", 10);
                    this.metroGrid1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
               
                

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


        private void btoAlt_Click(object sender, EventArgs e)
        {
            string obs;
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome para a categoria", "Erro");
                txtNome.Focus();
                return;
            }

            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma descrição para a categoria", "Erro");
                txtDes.Focus();
                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Insira um status para a categoria", "Erro");
                cboStatus.Focus();
                return;
            }

            if (txtObs.Text.Trim() == String.Empty)
            {
                obs = "Sem observação";
                txtObs.Text = obs;

            }

            string query = "update categoria set nome_categoria = '" + txtNome.Text + "', descricao_categoria = '" + txtDes.Text + "', obs_categoria = '" + txtObs.Text + "', status_categoria = '" + cboStatus.Text + "' where id_categoria = " + txtCode.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Alteração realizada com sucesso");
                    metroGrid1.RefreshEdit();

                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar a categoria");
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



        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtDes.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            cboStatus.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            txtObs.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroGrid1.RefreshEdit();
            limpar();

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtDes.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            cboStatus.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            txtObs.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtPes_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (txtPes.Text.Trim() == "")
            {
                sql = "select id_categoria as 'Código' ,nome_categoria as 'Nome', descricao_categoria as 'Descrição', status_categoria as 'Status', obs_categoria as 'Observação' from categoria";
            }
            else
            {
                sql = "select id_categoria as 'Código' ,nome_categoria as 'Nome', descricao_categoria as 'Descrição', status_categoria as 'Status', obs_categoria as 'Observação' from categoria where nome_categoria like '%" + txtPes.Text + "%'";


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

        private void metroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtDes.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            cboStatus.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            txtObs.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
