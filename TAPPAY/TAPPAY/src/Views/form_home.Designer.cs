namespace TAPPAY
{
    partial class form_home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tbTAG = new System.Windows.Forms.TextBox();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(429, 11);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(168, 39);
            this.title.TabIndex = 0;
            this.title.Text = "TAP PAY";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd.Location = new System.Drawing.Point(19, 74);
            this.lbl_qtd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(155, 29);
            this.lbl_qtd.TabIndex = 1;
            this.lbl_qtd.Text = "Quantidade:";
            // 
            // tb_quantity
            // 
            this.tb_quantity.AcceptsReturn = true;
            this.tb_quantity.AcceptsTab = true;
            this.tb_quantity.Location = new System.Drawing.Point(192, 79);
            this.tb_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(132, 22);
            this.tb_quantity.TabIndex = 2;
            this.tb_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // tbTAG
            // 
            this.tbTAG.AcceptsReturn = true;
            this.tbTAG.AcceptsTab = true;
            this.tbTAG.Location = new System.Drawing.Point(437, 79);
            this.tbTAG.Margin = new System.Windows.Forms.Padding(4);
            this.tbTAG.Name = "tbTAG";
            this.tbTAG.Size = new System.Drawing.Size(188, 22);
            this.tbTAG.TabIndex = 4;
            this.tbTAG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTAG_KeyDown);
            this.tbTAG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tag.Location = new System.Drawing.Point(352, 79);
            this.lbl_tag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(72, 29);
            this.lbl_tag.TabIndex = 3;
            this.lbl_tag.Text = "TAG:";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(820, 68);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(123, 39);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_config
            // 
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.Location = new System.Drawing.Point(659, 68);
            this.btn_config.Margin = new System.Windows.Forms.Padding(4);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(123, 39);
            this.btn_config.TabIndex = 6;
            this.btn_config.Text = "\r\n";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 137);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbTAG);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.title);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAP PAY";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_home_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tbTAG;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_config;
    }
}

