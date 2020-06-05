namespace Projeto.Forms
{
    partial class FrmDinamicaCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btoAdicionar = new System.Windows.Forms.Button();
            this.txtIDCompra = new System.Windows.Forms.TextBox();
            this.cboNomePrdo = new System.Windows.Forms.ComboBox();
            this.cboCodePro = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboValor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(12, 180);
            this.txtQtde.MaxLength = 4;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(168, 29);
            this.txtQtde.TabIndex = 2;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // btoAdicionar
            // 
            this.btoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoAdicionar.Location = new System.Drawing.Point(12, 317);
            this.btoAdicionar.Name = "btoAdicionar";
            this.btoAdicionar.Size = new System.Drawing.Size(105, 35);
            this.btoAdicionar.TabIndex = 3;
            this.btoAdicionar.Text = "Adicionar";
            this.btoAdicionar.UseVisualStyleBackColor = true;
            this.btoAdicionar.Click += new System.EventHandler(this.btoAdicionar_Click);
            // 
            // txtIDCompra
            // 
            this.txtIDCompra.Location = new System.Drawing.Point(172, 59);
            this.txtIDCompra.MaxLength = 4;
            this.txtIDCompra.Name = "txtIDCompra";
            this.txtIDCompra.Size = new System.Drawing.Size(87, 29);
            this.txtIDCompra.TabIndex = 1002;
            this.txtIDCompra.Visible = false;
            // 
            // cboNomePrdo
            // 
            this.cboNomePrdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomePrdo.FormattingEnabled = true;
            this.cboNomePrdo.Location = new System.Drawing.Point(12, 32);
            this.cboNomePrdo.Name = "cboNomePrdo";
            this.cboNomePrdo.Size = new System.Drawing.Size(168, 32);
            this.cboNomePrdo.TabIndex = 0;
            // 
            // cboCodePro
            // 
            this.cboCodePro.FormattingEnabled = true;
            this.cboCodePro.Location = new System.Drawing.Point(186, 115);
            this.cboCodePro.Name = "cboCodePro";
            this.cboCodePro.Size = new System.Drawing.Size(73, 32);
            this.cboCodePro.TabIndex = 1003;
            this.cboCodePro.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(12, 253);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(168, 29);
            this.txtTotal.TabIndex = 1004;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // cboValor
            // 
            this.cboValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValor.Enabled = false;
            this.cboValor.FormattingEnabled = true;
            this.cboValor.Location = new System.Drawing.Point(12, 115);
            this.cboValor.Name = "cboValor";
            this.cboValor.Size = new System.Drawing.Size(168, 32);
            this.cboValor.TabIndex = 1005;
            this.cboValor.Leave += new System.EventHandler(this.cboValor_Leave);
            // 
            // FrmDinamicaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 371);
            this.Controls.Add(this.cboValor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cboCodePro);
            this.Controls.Add(this.cboNomePrdo);
            this.Controls.Add(this.txtIDCompra);
            this.Controls.Add(this.btoAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtde);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmDinamicaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Itens";
            this.Load += new System.EventHandler(this.FrmDinamicaCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btoAdicionar;
        private System.Windows.Forms.TextBox txtIDCompra;
        private System.Windows.Forms.ComboBox cboNomePrdo;
        private System.Windows.Forms.ComboBox cboCodePro;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboValor;
    }
}