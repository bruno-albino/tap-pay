using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAPPAY.src.Business.Models;
using TAPPAY.src.Domain.Models;

namespace TAPPAY.src.Views
{
    public partial class form_addCerveja : Form
    {
        ClientBus clientBusiness;
        public form_addCerveja()
        {
            InitializeComponent();

            clientBusiness = new ClientBus();
        }

        private void btAddBeers_Click(object sender, EventArgs e)
        {
            if(tbTag.Text == "" || tbQuantity.Text == "")
            {
                MessageBox.Show("Insira todos os campos");
                return;
            }

            Clients client = this.clientBusiness.FindByTAG(tbTag.Text);

            if(client is null)
            {
                MessageBox.Show("Cliente não encontrado");
                return;
            }

            client.beers = (int.Parse(client.beers) + int.Parse(tbQuantity.Text)).ToString();

            this.clientBusiness.Update(client);

            MessageBox.Show("Cerveja adicionadas");
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            tbQuantity.Text = Regex.Replace(tbQuantity.Text, @"[^\d]", "");
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
