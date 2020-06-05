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
    public partial class FrmItens : Form
    {
        public FrmItens()
        {
            InitializeComponent();
        }

        void linha()
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
        string _sql = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";
        private void FrmItens_Load(object sender, EventArgs e)
        {
            linha();
            carregar();
           
        }

        void carregar()
        {
            if (FrmHistorico.tipo == "Venda")
            {
                string query = "select nome_produto as 'Nome do Produto', valor_itemvenda as 'Preço',qtde_itemvenda as 'Quantidade' from itemvenda inner join produto on itemvenda.id_produto_itemvenda = produto.id_produto where itemvenda.id_venda_itemvenda = " + FrmHistorico.code;
                MySqlConnection my = new MySqlConnection(_sql);
                MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
                DataSet ds = new DataSet();




                try
                {
                    dt.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    

                  
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

            if (FrmHistorico.tipo == "Compra")
            {
                string query = "select nome_produto as 'Nome do Produto', valor_itemcompra as 'Preço',qtde_itemcompra as 'Quantidade' from itemcompra inner join produto on itemcompra.id_produto_itemcompra = produto.id_produto where itemcompra.id_compra_itemcompra =" + FrmHistorico.code;
                MySqlConnection my = new MySqlConnection(_sql);
                MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
                DataSet ds = new DataSet();




                try
                {
                    dt.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    

                 
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
        }
    }
}
