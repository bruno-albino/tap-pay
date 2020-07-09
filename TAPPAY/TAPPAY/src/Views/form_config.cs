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
            //form_addCerveja addCerveja = new form_addCerveja();
            //addCerveja.Show();

        }

        private void btn_addCliente_Click(object sender, EventArgs e)
        {
            //form_addCliente addCliente = new form_addCliente();
            //addCliente.Show();
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            form_buscaCliente buscaCliente = new form_buscaCliente();
            buscaCliente.Show();
        }
    }
}
