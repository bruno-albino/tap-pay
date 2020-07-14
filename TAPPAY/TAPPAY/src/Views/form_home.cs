using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAPPAY.src.Business.Models;
using TAPPAY.src.config;
using TAPPAY.src.Domain.Models;
using TAPPAY.src.Views;

namespace TAPPAY
{
    public partial class form_home : Form
    {
        private ClientBus clientBusiness;
        public form_home()
        {
            InitializeComponent();
            clientBusiness = new ClientBus();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            form_config formConfig = new form_config();
            formConfig.ShowDialog();
        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void form_home_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tbTAG_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchClient(tbTAG.Text);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            searchClient(tbTAG.Text);
        }


        private void searchClient(string TAG)
        {
            Clients client = clientBusiness.FindByTAG(TAG);

            if (client is null)
            {
                MessageBox.Show("Cliente não encontrado");
                tbTAG.Text = "";
                tbTAG.Focus();
                return;
            }


            this.reduceBeers(client);
        }

        private void reduceBeers(Clients client)
        {
            int beersToRemove = tb_quantity.Text == "" ? 1 : int.Parse(tb_quantity.Text);

            if(int.Parse(client.beers) <= 0 || int.Parse(client.beers) - beersToRemove < 0)
            {
                MessageBox.Show("Cliente sem cervejas disponíveis");
                return;
            }

            int beers = int.Parse(client.beers) - beersToRemove;
            client.beers = beers.ToString();

            try
            {
                clientBusiness.Update(client);
                MessageBox.Show($@"Removido {beersToRemove} cerveja(s)");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do cliente. Por favor, tente novamente");
            }
        }

        private void tb_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(tbTAG.Text == "")
                {
                    MessageBox.Show("Insira a TAG para remoção das cervejas");
                    return;
                }
                this.searchClient(tbTAG.Text);
            }
        }
    }
}
