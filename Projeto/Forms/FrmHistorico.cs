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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        public static string code, tipo;
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
        string Banco = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            tema();
            linha();
            carregardrig();
            
        }

        void carregardrig()
        {
            string query = "select id_compra as 'Código', compra.id_fornecedor as 'Código 2', 'Compra' as 'Tipo' , nome_fornecedor as 'Proprietário',cnpj_fornecedor as 'CPF/CNPJ', valor_compra as 'Valor', data_compra as 'Data', obs_compra as 'Observação' from compra inner join fornecedor on compra.id_fornecedor = fornecedor.id_fornecedor UNION ALL select id_venda, venda.id_cliente_venda, 'Venda', nome_Cliente,cpf_cliente, valor_venda, data_venda, obs_venda from venda inner join cliente on venda.id_cliente_venda = cliente.id_cliente";
            MySqlConnection my = new MySqlConnection(Banco);
            MySqlDataAdapter dt = new MySqlDataAdapter(query, my);
            DataSet ds = new DataSet();




            try
            {
                dt.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
                metroGrid1.Columns["Código"].Visible = false;
                metroGrid1.Columns["Código 2"].Visible = false;


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

        void linha()
        {
            this.metroGrid1.GridColor = cores.secundaria;
            this.metroGrid1.DefaultCellStyle.ForeColor = cores.secundaria ;
            cores.secundaria = cores.ChangeColorBrightness(cores.primaria, -0.2);
            this.metroGrid1.ColumnHeadersDefaultCellStyle.BackColor = cores.secundaria;
            this.metroGrid1.ColumnHeadersDefaultCellStyle.SelectionBackColor = cores.secundaria;
            cores.secundaria = cores.ChangeColorBrightness(cores.primaria, 0.55);
            this.metroGrid1.RowHeadersDefaultCellStyle.SelectionBackColor = cores.secundaria;
            
          
            this.metroGrid1.DefaultCellStyle.SelectionBackColor = cores.secundaria;
            this.metroGrid1.DefaultCellStyle.SelectionForeColor =  Color.White;
        }

        private void metroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtTipo.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            code = txtCode.Text;
            tipo = txtTipo.Text;
            var fr = new FrmItens();
            fr.ShowDialog();
        }

        
    }
}
