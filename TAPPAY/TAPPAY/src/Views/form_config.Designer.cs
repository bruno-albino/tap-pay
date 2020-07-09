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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_config));
            this.btn_addCerveja = new System.Windows.Forms.Button();
            this.btn_addCliente = new System.Windows.Forms.Button();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addCerveja
            // 
            this.btn_addCerveja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btn_addCerveja.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCerveja.Image")));
            this.btn_addCerveja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addCerveja.Location = new System.Drawing.Point(12, 34);
            this.btn_addCerveja.Name = "btn_addCerveja";
            this.btn_addCerveja.Size = new System.Drawing.Size(234, 40);
            this.btn_addCerveja.TabIndex = 0;
            this.btn_addCerveja.Text = "ADICIONAR CERVEJA";
            this.btn_addCerveja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCerveja.UseVisualStyleBackColor = true;
            this.btn_addCerveja.Click += new System.EventHandler(this.btn_addCerveja_Click);
            // 
            // btn_addCliente
            // 
            this.btn_addCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btn_addCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCliente.Image")));
            this.btn_addCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addCliente.Location = new System.Drawing.Point(273, 34);
            this.btn_addCliente.Name = "btn_addCliente";
            this.btn_addCliente.Size = new System.Drawing.Size(234, 40);
            this.btn_addCliente.TabIndex = 1;
            this.btn_addCliente.Text = "ADICIONAR CLIENTE";
            this.btn_addCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCliente.UseVisualStyleBackColor = true;
            this.btn_addCliente.Click += new System.EventHandler(this.btn_addCliente_Click);
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btn_buscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarCliente.Image")));
            this.btn_buscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscarCliente.Location = new System.Drawing.Point(538, 34);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(234, 40);
            this.btn_buscarCliente.TabIndex = 2;
            this.btn_buscarCliente.Text = "BUSCAR CLIENTE";
            this.btn_buscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // form_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 111);
            this.Controls.Add(this.btn_buscarCliente);
            this.Controls.Add(this.btn_addCliente);
            this.Controls.Add(this.btn_addCerveja);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURAÇÕES";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addCerveja;
        private System.Windows.Forms.Button btn_addCliente;
        private System.Windows.Forms.Button btn_buscarCliente;
    }
}