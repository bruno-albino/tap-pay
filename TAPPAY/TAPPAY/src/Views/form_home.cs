﻿using System;
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
using TAPPAY.src.config;
using TAPPAY.src.Domain.Models;
using TAPPAY.src.Views;

namespace TAPPAY
{
    public partial class form_home : Form
    {
        Clients selectedClient;
        public form_home()
        {
            InitializeComponent();
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
            ClientBusiness clientBusiness = new ClientBusiness();

            Clients client = clientBusiness.findByTAG(TAG);

            if (client is null)
            {
                MessageBox.Show("Cliente não encontrado");
                tbTAG.Text = "";
                tbTAG.Focus();
                this.selectedClient = null;
                return;
            }

            this.selectedClient = client;
        }
    }
}