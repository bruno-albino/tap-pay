namespace TAPPAY.src.Views
{
    partial class form_buscaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.TextBox();
            this.dgClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(13, 9);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(233, 29);
            this.title.TabIndex = 1;
            this.title.Text = "BUSCAR CLIENTE";
            // 
            // query
            // 
            this.query.AccessibleDescription = "";
            this.query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query.Location = new System.Drawing.Point(259, 9);
            this.query.Margin = new System.Windows.Forms.Padding(4);
            this.query.MaxLength = 50;
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(529, 30);
            this.query.TabIndex = 5;
            this.query.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToAddRows = false;
            this.dgClients.AllowUserToDeleteRows = false;
            this.dgClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClients.ColumnHeadersHeight = 25;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgClients.Location = new System.Drawing.Point(18, 47);
            this.dgClients.Name = "dgClients";
            this.dgClients.ReadOnly = true;
            this.dgClients.RowHeadersWidth = 51;
            this.dgClients.RowTemplate.Height = 24;
            this.dgClients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(770, 256);
            this.dgClients.TabIndex = 6;
            this.dgClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClients_CellDoubleClick);
            // 
            // form_buscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 314);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.query);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_buscaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar cliente";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.form_buscaCliente_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_buscaCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.DataGridView dgClients;
    }
}