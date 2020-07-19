namespace TAPPAY.src.Views
{
    partial class form_config
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
            this.btn_addCerveja = new System.Windows.Forms.Button();
            this.btn_addCliente = new System.Windows.Forms.Button();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addCerveja
            // 
            this.btn_addCerveja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCerveja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addCerveja.Location = new System.Drawing.Point(16, 42);
            this.btn_addCerveja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addCerveja.Name = "btn_addCerveja";
            this.btn_addCerveja.Size = new System.Drawing.Size(312, 49);
            this.btn_addCerveja.TabIndex = 0;
            this.btn_addCerveja.Text = "ADICIONAR CERVEJA";
            this.btn_addCerveja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCerveja.UseVisualStyleBackColor = true;
            this.btn_addCerveja.Click += new System.EventHandler(this.btn_addCerveja_Click);
            // 
            // btn_addCliente
            // 
            this.btn_addCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addCliente.Location = new System.Drawing.Point(364, 42);
            this.btn_addCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addCliente.Name = "btn_addCliente";
            this.btn_addCliente.Size = new System.Drawing.Size(312, 49);
            this.btn_addCliente.TabIndex = 1;
            this.btn_addCliente.Text = "ADICIONAR CLIENTE";
            this.btn_addCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCliente.UseVisualStyleBackColor = true;
            this.btn_addCliente.Click += new System.EventHandler(this.btn_addCliente_Click);
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscarCliente.Location = new System.Drawing.Point(717, 42);
            this.btn_buscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(312, 49);
            this.btn_buscarCliente.TabIndex = 2;
            this.btn_buscarCliente.Text = "BUSCAR CLIENTE";
            this.btn_buscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // form_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 137);
            this.Controls.Add(this.btn_buscarCliente);
            this.Controls.Add(this.btn_addCliente);
            this.Controls.Add(this.btn_addCerveja);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURAÇÕES";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_config_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addCerveja;
        private System.Windows.Forms.Button btn_addCliente;
        private System.Windows.Forms.Button btn_buscarCliente;
    }
}