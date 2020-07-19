namespace TAPPAY.src.Views
{
    partial class form_addCerveja
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
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btAddBeers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(12, 20);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(178, 22);
            this.tbTag.TabIndex = 0;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(245, 20);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(178, 22);
            this.tbQuantity.TabIndex = 1;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // btAddBeers
            // 
            this.btAddBeers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddBeers.Location = new System.Drawing.Point(469, 8);
            this.btAddBeers.Name = "btAddBeers";
            this.btAddBeers.Size = new System.Drawing.Size(112, 34);
            this.btAddBeers.TabIndex = 2;
            this.btAddBeers.Text = "Adicionar";
            this.btAddBeers.UseVisualStyleBackColor = true;
            this.btAddBeers.Click += new System.EventHandler(this.btAddBeers_Click);
            // 
            // form_addCerveja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 54);
            this.Controls.Add(this.btAddBeers);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbTag);
            this.Name = "form_addCerveja";
            this.Text = "Adicionar Cerveja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btAddBeers;
    }
}