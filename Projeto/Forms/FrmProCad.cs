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
    public partial class FrmProCad : Form
    {
        public FrmProCad()
        {
            InitializeComponent();
            tema();
            cat();
         
            carregar();

        }
        
        public FrmProCad(int codepro)
        {
            InitializeComponent();
            txtCodePro.Text = codepro.ToString();
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

        private void btoCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cat()
        {
            string q = "select id_categoria,nome_categoria from categoria";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(q,my);
            cmd.CommandType = CommandType.Text;
            DataTable tb = new DataTable();
            MySqlDataReader rr;

            try
            {
                

                my.Open();
                rr = cmd.ExecuteReader();
                tb.Load(rr);

                cboCat.DisplayMember = "nome_categoria";
                cboCat.DataSource = tb;                                        
                cboCodeCat.DisplayMember = "id_categoria";
                cboCodeCat.DataSource = tb;

                

            }
            catch (MySqlException ex)
            {
               
                
            }
            finally
            {
                my.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into produtocategoria (id_produto_produtocategoria,id_categoria_produtocategoria) values ('" + txtCodePro.Text + "', '"+cboCodeCat.Text+"')";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
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
                    MessageBox.Show("Não pode adicionar a mesma categoria duas vezes");
                    return;
                }
            }
            finally
            {


                carregar();



            }
        }

        private void carregar()
        {
            string query = "SELECT produtocategoria.*,  produto.nome_produto as 'Nome do produto',categoria.nome_categoria as 'Categoria' FROM produtocategoria INNER JOIN produto on produtocategoria.id_produto_produtocategoria = produto.id_produto inner JOIN categoria on produtocategoria.id_categoria_produtocategoria = categoria.id_categoria where produto.id_produto=" + int.Parse(txtCodePro.Text);

               MySqlConnection my = new MySqlConnection(_sql);
            MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
            DataSet ds = new DataSet();




            try
            {
                dt.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
                metroGrid1.Columns["id_produtocategoria"].Visible = false;
                metroGrid1.Columns["id_produto_produtocategoria"].Visible = false;
                metroGrid1.Columns["id_categoria_produtocategoria"].Visible = false;
                for (int i = 0; i < metroGrid1.Columns.Count; i++)
                {
                    int sla = metroGrid1.Columns[i].Width;
                    metroGrid1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void FrmProCad_Load(object sender, EventArgs e)
        {
            cat();
            linha();
            carregar();
        }

        private void btoDel_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM produtocategoria WHERE id_produtocategoria=" + txtcodigo.Text;
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

                if (ex.Number == 1064)
                {
                    MessageBox.Show("Insira uma categoria para deletar");
                    return;
                }
            }
            finally
            {
                
                carregar();
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

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodePro.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            txtcodigo.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
        }
    }
    
}
