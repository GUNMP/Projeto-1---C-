namespace Projeto
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btoUser = new System.Windows.Forms.Button();
            this.btoHistorico = new System.Windows.Forms.Button();
            this.btoFornecedor = new System.Windows.Forms.Button();
            this.btoCompra = new System.Windows.Forms.Button();
            this.btoCategoria = new System.Windows.Forms.Button();
            this.btoProduto = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTit = new System.Windows.Forms.Panel();
            this.btoFechar = new System.Windows.Forms.Button();
            this.btoMini = new System.Windows.Forms.Button();
            this.btoVoltar = new System.Windows.Forms.Button();
            this.lblTil = new System.Windows.Forms.Label();
            this.panelPrograma = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.panelTit.SuspendLayout();
            this.panelPrograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btoUser);
            this.panelMenu.Controls.Add(this.btoHistorico);
            this.panelMenu.Controls.Add(this.btoFornecedor);
            this.panelMenu.Controls.Add(this.btoCompra);
            this.panelMenu.Controls.Add(this.btoCategoria);
            this.panelMenu.Controls.Add(this.btoProduto);
            this.panelMenu.Controls.Add(this.PanelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 641);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btoUser
            // 
            this.btoUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btoUser.FlatAppearance.BorderSize = 0;
            this.btoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btoUser.Image = global::Projeto.Properties.Resources.icons8_male_user_30px;
            this.btoUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoUser.Location = new System.Drawing.Point(0, 587);
            this.btoUser.Name = "btoUser";
            this.btoUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btoUser.Size = new System.Drawing.Size(200, 54);
            this.btoUser.TabIndex = 6;
            this.btoUser.Text = "   Usuário";
            this.btoUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoUser.UseVisualStyleBackColor = true;
            this.btoUser.Visible = false;
            this.btoUser.Click += new System.EventHandler(this.btoUser_Click);
            // 
            // btoHistorico
            // 
            this.btoHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btoHistorico.FlatAppearance.BorderSize = 0;
            this.btoHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoHistorico.ForeColor = System.Drawing.Color.Gainsboro;
            this.btoHistorico.Image = global::Projeto.Properties.Resources.icons8_agreement_30px;
            this.btoHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoHistorico.Location = new System.Drawing.Point(0, 315);
            this.btoHistorico.Name = "btoHistorico";
            this.btoHistorico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btoHistorico.Size = new System.Drawing.Size(200, 60);
            this.btoHistorico.TabIndex = 5;
            this.btoHistorico.Text = "   Histórico";
            this.btoHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoHistorico.UseVisualStyleBackColor = true;
            this.btoHistorico.Click += new System.EventHandler(this.btoHistorico_Click);
            // 
            // btoFornecedor
            // 
            this.btoFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btoFornecedor.FlatAppearance.BorderSize = 0;
            this.btoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoFornecedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btoFornecedor.Image = global::Projeto.Properties.Resources.icons8_company_30px;
            this.btoFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoFornecedor.Location = new System.Drawing.Point(0, 255);
            this.btoFornecedor.Name = "btoFornecedor";
            this.btoFornecedor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btoFornecedor.Size = new System.Drawing.Size(200, 60);
            this.btoFornecedor.TabIndex = 4;
            this.btoFornecedor.Text = "   Fornecedores";
            this.btoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoFornecedor.UseVisualStyleBackColor = true;
            this.btoFornecedor.Click += new System.EventHandler(this.btoFornecedor_Click);
            // 
            // btoCompra
            // 
            this.btoCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btoCompra.FlatAppearance.BorderSize = 0;
            this.btoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoCompra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btoCompra.Image = global::Projeto.Properties.Resources.icons8_cash_30px;
            this.btoCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoCompra.Location = new System.Drawing.Point(0, 195);
            this.btoCompra.Name = "btoCompra";
            this.btoCompra.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btoCompra.Size = new System.Drawing.Size(200, 60);
            this.btoCompra.TabIndex = 3;
            this.btoCompra.Text = "   Compras";
            this.btoCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoCompra.UseVisualStyleBackColor = true;
            this.btoCompra.Click += new System.EventHandler(this.btoCompra_Click);
            // 
            // btoCategoria
            // 
            this.btoCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btoCategoria.FlatAppearance.BorderSize = 0;
            this.btoCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btoCategoria.Image = global::Projeto.Properties.Resources.icons8_categorize_30px;
            this.btoCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoCategoria.Location = new System.Drawing.Point(0, 135);
            this.btoCategoria.Name = "btoCategoria";
            this.btoCategoria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btoCategoria.Size = new System.Drawing.Size(200, 60);
            this.btoCategoria.TabIndex = 2;
            this.btoCategoria.Text = "   Categorias";
            this.btoCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoCategoria.UseVisualStyleBackColor = true;
            this.btoCategoria.Click += new System.EventHandler(this.btoCategoria_Click);
            // 
            // btoProduto
            // 
            this.btoProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btoProduto.FlatAppearance.BorderSize = 0;
            this.btoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoProduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btoProduto.Image = global::Projeto.Properties.Resources.icons8_product_30px;
            this.btoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoProduto.Location = new System.Drawing.Point(0, 75);
            this.btoProduto.Name = "btoProduto";
            this.btoProduto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btoProduto.Size = new System.Drawing.Size(200, 60);
            this.btoProduto.TabIndex = 1;
            this.btoProduto.Text = "   Produtos";
            this.btoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoProduto.UseVisualStyleBackColor = true;
            this.btoProduto.Click += new System.EventHandler(this.btoProduto_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelLogo.Controls.Add(this.label2);
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 75);
            this.PanelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "NerdLândia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(206, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "NerdLândia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTit
            // 
            this.panelTit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.panelTit.Controls.Add(this.btoFechar);
            this.panelTit.Controls.Add(this.btoMini);
            this.panelTit.Controls.Add(this.btoVoltar);
            this.panelTit.Controls.Add(this.lblTil);
            this.panelTit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTit.Location = new System.Drawing.Point(200, 0);
            this.panelTit.Name = "panelTit";
            this.panelTit.Size = new System.Drawing.Size(1084, 75);
            this.panelTit.TabIndex = 1;
            this.panelTit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTit_Paint);
            this.panelTit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTit_MouseDown);
            // 
            // btoFechar
            // 
            this.btoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoFechar.FlatAppearance.BorderSize = 0;
            this.btoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoFechar.Image = global::Projeto.Properties.Resources.icons8_circle_10px;
            this.btoFechar.Location = new System.Drawing.Point(1048, 0);
            this.btoFechar.Name = "btoFechar";
            this.btoFechar.Size = new System.Drawing.Size(32, 28);
            this.btoFechar.TabIndex = 1;
            this.btoFechar.UseVisualStyleBackColor = true;
            this.btoFechar.Click += new System.EventHandler(this.btoFechar_Click);
            // 
            // btoMini
            // 
            this.btoMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoMini.FlatAppearance.BorderSize = 0;
            this.btoMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoMini.Image = global::Projeto.Properties.Resources.icons8_circle_10px;
            this.btoMini.Location = new System.Drawing.Point(1010, 0);
            this.btoMini.Name = "btoMini";
            this.btoMini.Size = new System.Drawing.Size(32, 28);
            this.btoMini.TabIndex = 1;
            this.btoMini.UseVisualStyleBackColor = true;
            this.btoMini.Click += new System.EventHandler(this.btoMini_Click);
            // 
            // btoVoltar
            // 
            this.btoVoltar.AutoSize = true;
            this.btoVoltar.FlatAppearance.BorderSize = 0;
            this.btoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoVoltar.Image = global::Projeto.Properties.Resources.icons8_delete_30px_2;
            this.btoVoltar.Location = new System.Drawing.Point(6, 12);
            this.btoVoltar.Name = "btoVoltar";
            this.btoVoltar.Size = new System.Drawing.Size(72, 57);
            this.btoVoltar.TabIndex = 0;
            this.btoVoltar.UseVisualStyleBackColor = true;
            this.btoVoltar.Click += new System.EventHandler(this.btoVoltar_Click);
            // 
            // lblTil
            // 
            this.lblTil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTil.AutoSize = true;
            this.lblTil.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTil.ForeColor = System.Drawing.Color.White;
            this.lblTil.Location = new System.Drawing.Point(514, 23);
            this.lblTil.Name = "lblTil";
            this.lblTil.Size = new System.Drawing.Size(67, 32);
            this.lblTil.TabIndex = 0;
            this.lblTil.Text = "HOME";
            // 
            // panelPrograma
            // 
            this.panelPrograma.Controls.Add(this.pictureBox1);
            this.panelPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrograma.Location = new System.Drawing.Point(200, 75);
            this.panelPrograma.Name = "panelPrograma";
            this.panelPrograma.Size = new System.Drawing.Size(1084, 566);
            this.panelPrograma.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Projeto.Properties.Resources.logoEmJpg;
            this.pictureBox1.Location = new System.Drawing.Point(345, 55);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(600, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 641);
            this.Controls.Add(this.panelPrograma);
            this.Controls.Add(this.panelTit);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.panelTit.ResumeLayout(false);
            this.panelTit.PerformLayout();
            this.panelPrograma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btoProduto;
        private System.Windows.Forms.FlowLayoutPanel PanelLogo;
        private System.Windows.Forms.Button btoHistorico;
        private System.Windows.Forms.Button btoFornecedor;
        private System.Windows.Forms.Button btoCompra;
        private System.Windows.Forms.Button btoCategoria;
        private System.Windows.Forms.Panel panelTit;
        private System.Windows.Forms.Label lblTil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btoVoltar;
        private System.Windows.Forms.Button btoMini;
        private System.Windows.Forms.Button btoFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPrograma;
        private System.Windows.Forms.Button btoUser;
    }
}