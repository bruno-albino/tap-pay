namespace TAPPAY.src.Views
{
    partial class form_addClient
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
            this.title = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTAG = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.btn_addClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(164, 25);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(268, 29);
            this.title.TabIndex = 0;
            this.title.Text = "ADICIONAR CLIENTE";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(1, 76);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(90, 29);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "NOME";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(1, 137);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(150, 29);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "TELEFONE";
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tag.Location = new System.Drawing.Point(344, 137);
            this.lbl_tag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(65, 29);
            this.lbl_tag.TabIndex = 3;
            this.lbl_tag.Text = "TAG";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(105, 82);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(523, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbTAG
            // 
            this.tbTAG.Location = new System.Drawing.Point(421, 143);
            this.tbTAG.Margin = new System.Windows.Forms.Padding(4);
            this.tbTAG.MaxLength = 8;
            this.tbTAG.Name = "tbTAG";
            this.tbTAG.Size = new System.Drawing.Size(207, 22);
            this.tbTAG.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(169, 143);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhone.Mask = "(00)00000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(148, 22);
            this.tbPhone.TabIndex = 6;
            // 
            // btn_addClient
            // 
            this.btn_addClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addClient.Location = new System.Drawing.Point(193, 194);
            this.btn_addClient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addClient.Name = "btn_addClient";
            this.btn_addClient.Size = new System.Drawing.Size(203, 49);
            this.btn_addClient.TabIndex = 7;
            this.btn_addClient.Text = "ADICIONAR";
            this.btn_addClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addClient.UseVisualStyleBackColor = true;
            this.btn_addClient.Click += new System.EventHandler(this.btn_addClient_Click);
            // 
            // form_addClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_addClient;
            this.ClientSize = new System.Drawing.Size(645, 260);
            this.Controls.Add(this.btn_addClient);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbTAG);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_addClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADICIONAR CLIENTE";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_addClient_KeyDown);
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
        private System.Windows.Forms.Button btn_addClient;
    }
}