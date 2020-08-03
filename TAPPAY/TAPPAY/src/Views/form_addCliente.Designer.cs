namespace TAPPAY.src.Views
{
    partial class form_addCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_addCliente));
            this.title = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTAG = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.panel_addCliente = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addClient = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_addCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(343, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(250, 30);
            this.title.TabIndex = 0;
            this.title.Text = "ADICIONAR CLIENTE";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome.Location = new System.Drawing.Point(12, 71);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(68, 22);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "NOME";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_telefone.Location = new System.Drawing.Point(12, 104);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(97, 22);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "TELEFONE";
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tag.Location = new System.Drawing.Point(233, 104);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(50, 22);
            this.lbl_tag.TabIndex = 3;
            this.lbl_tag.Text = "TAG";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(393, 27);
            this.tbName.TabIndex = 4;
            // 
            // tbTAG
            // 
            this.tbTAG.Location = new System.Drawing.Point(289, 102);
            this.tbTAG.MaxLength = 8;
            this.tbTAG.Name = "tbTAG";
            this.tbTAG.Size = new System.Drawing.Size(190, 27);
            this.tbTAG.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(115, 102);
            this.tbPhone.Mask = "(00)00000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(112, 27);
            this.tbPhone.TabIndex = 6;
            // 
            // panel_addCliente
            // 
            this.panel_addCliente.Controls.Add(this.pictureBox1);
            this.panel_addCliente.Controls.Add(this.btn_addClient);
            this.panel_addCliente.Location = new System.Drawing.Point(528, 66);
            this.panel_addCliente.Name = "panel_addCliente";
            this.panel_addCliente.Size = new System.Drawing.Size(270, 60);
            this.panel_addCliente.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addClient
            // 
            this.btn_addClient.FlatAppearance.BorderSize = 0;
            this.btn_addClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_addClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addClient.Location = new System.Drawing.Point(65, 5);
            this.btn_addClient.Name = "btn_addClient";
            this.btn_addClient.Size = new System.Drawing.Size(200, 50);
            this.btn_addClient.TabIndex = 0;
            this.btn_addClient.Text = "ADICIONAR CLIENTE";
            this.btn_addClient.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 60);
            this.panel4.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_qtd);
            this.panel1.Controls.Add(this.tb_quantity);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(94, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 60);
            this.panel1.TabIndex = 13;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd.Location = new System.Drawing.Point(2, 19);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(124, 24);
            this.lbl_qtd.TabIndex = 1;
            this.lbl_qtd.Text = "Quantidade:";
            this.lbl_qtd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_quantity
            // 
            this.tb_quantity.AcceptsReturn = true;
            this.tb_quantity.AcceptsTab = true;
            this.tb_quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_quantity.Location = new System.Drawing.Point(132, 18);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(112, 27);
            this.tb_quantity.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(749, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(780, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 23;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // form_addCliente
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(810, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_addCliente);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbTAG);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "form_addCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADICIONAR CLIENTE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_addClient_KeyDown);
            this.panel_addCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTAG;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.Panel panel_addCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addClient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_close;
    }
}