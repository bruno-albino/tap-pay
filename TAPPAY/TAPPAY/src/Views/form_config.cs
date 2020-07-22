using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPPAY.src.Views
{
    public partial class form_config : Form
    {
        public form_config()
        {
            InitializeComponent();
        }

        private void btn_addCerveja_Click(object sender, EventArgs e)
        {
            form_addCerveja addCerveja = new form_addCerveja();
            addCerveja.ShowDialog();

        }

        private void btn_addCliente_Click(object sender, EventArgs e)
        {
            form_addCliente addClient = new form_addCliente();
            addClient.Show();
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            form_buscaCliente buscaCliente = new form_buscaCliente();
            buscaCliente.Show();
        }

        private void form_config_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_addCerveja formAddCerveja = new form_addCerveja();
            formAddCerveja.Show();
        }
    }
}
