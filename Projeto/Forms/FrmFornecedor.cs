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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
            
        }

       
        private string _sql = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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

        private void btoCadastar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser prenchidos", "Atenção");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser prenchidos", "Atenção");
                return;
            }
            if (txtendereço.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser prenchidos", "Atenção");
                return;
            }
            if (CNJP.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser prenchidos", "Atenção");
                return;
            }
            if (mskCel.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser prenchidos", "Atenção");
                return;
            }
            if (MskTelefone.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser prenchidos", "Atenção");
                return;
            }
            if (txtObs.Text.Trim() == "")
            {
                txtObs.Text = "Sem observação";
            }
            string conex = "INSERT INTO Fornecedor (nome_fornecedor, cnpj_fornecedor,email_fornecedor,endereco_fornecedor,telFixo_fornecedor,telCel_fornecedor,status_fornecedor,obs_fornecedor) VALUES ('" + txtNome.Text + "','" + CNJP.Text + "' , '" + txtEmail.Text + "','" + txtendereço.Text + "','"+ MskTelefone.Text + "','" + mskCel.Text + "','" + cboStatus.Text + "','" + txtObs.Text + "')";
            MySqlConnection sql = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(conex, sql);
            try
            {
                sql.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0 )
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso", "Atenção");
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar o cadastro");
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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string conex = "update fornecedor set nome_fornecedor = '" + txtNome.Text + "', cnpj_fornecedor = '" + CNJP.Text + "', email_fornecedor = '" + txtEmail.Text + "', endereco_fornecedor = '" + txtendereço.Text + "',telFixo_fornecedor= '" + MskTelefone.Text + "',telCel_fornecedor = '" + mskCel.Text + "',status_fornecedor = '"+cboStatus.Text+ "',obs_fornecedor ='"+ txtObs.Text + "' where id_fornecedor = " + txtID.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(conex, my);
            
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
                my.Close();
            }
        }     
        void limpar()
        {
            txtDataGrid.Text = "";
            txtNome.Text = "";
            txtendereço.Text = "";
            txtObs.Text = "";
            CNJP.Text = "";
            mskCel.Text = "";
            MskTelefone.Text = "";
            cboStatus.SelectedIndex = -1;
            txtNome.Focus();
        }
        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            tema();
            carregar();
            linha();
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string Conex = "DELETE FROM fornecedor WHERE id_fornecedor =" + txtID.Text;
            SqlConnection my = new SqlConnection(_sql);
            SqlCommand cmd = new SqlCommand(Conex, my);
            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Fornecedor deletada com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o Fornecedor");
                }
            }
            catch (Exception ex)
            {

             MessageBox.Show(ex.Message);
            }
            finally
            {
                limpar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void carregar()
        {
            string query = "select id_fornecedor as 'Código', nome_fornecedor as 'Nome', cnpj_fornecedor as 'CNPJ', email_fornecedor as 'e-Mail', endereco_fornecedor as 'Endereço', telFixo_fornecedor as 'Tel. Fixo'," +
               "telCel_fornecedor as 'Celular', status_fornecedor as 'Status', obs_fornecedor as 'Observação' from fornecedor";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
            DataSet ds = new DataSet();




            try
            {
                dt.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
                metroGrid1.Columns["Código"].Visible = false;
                
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

       

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void CNJP_Click(object sender, EventArgs e)
        {
            CNJP.SelectAll();
        }

        private void CNJP_Enter(object sender, EventArgs e)
        {
            CNJP.SelectAll();
            
        }

        private void mskCel_Enter(object sender, EventArgs e)
        {
            mskCel.SelectAll();
        }

        private void mskCel_Click(object sender, EventArgs e)
        {
            mskCel.SelectAll();
        }

        private void MskTelefone_Click(object sender, EventArgs e)
        {
            MskTelefone.SelectAll();
        }

        private void MskTelefone_Enter(object sender, EventArgs e)
        {
            MskTelefone.SelectAll();
        }

        private void txtDataGrid_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (txtDataGrid.Text.Trim() == "")
            {
                sql = "select id_fornecedor as 'Código', nome_fornecedor as 'Nome', cnpj_fornecedor as 'CNPJ', email_fornecedor as 'e-Mail', endereco_fornecedor as 'Endereço', telFixo_fornecedor as 'Tel. Fixo'," +
               "telCel_fornecedor as 'Celular', status_fornecedor as 'Status', obs_fornecedor as 'Observação' from fornecedor";
            }
            else
            {
                sql = "select id_fornecedor as 'Código', nome_fornecedor as 'Nome', cnpj_fornecedor as 'CNPJ', email_fornecedor as 'e-Mail', endereco_fornecedor as 'Endereço', telFixo_fornecedor as 'Tel. Fixo'," +
               "telCel_fornecedor as 'Celular', status_fornecedor as 'Status', obs_fornecedor as 'Observação' from fornecedor where nome_fornecedor like '%" + txtDataGrid.Text + "%'";


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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            CNJP.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            txtendereço.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
            MskTelefone.Text = metroGrid1.CurrentRow.Cells[5].Value.ToString();
            mskCel.Text = metroGrid1.CurrentRow.Cells[6].Value.ToString();
            cboStatus.Text = metroGrid1.CurrentRow.Cells[7].Value.ToString();
            txtObs.Text = metroGrid1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
