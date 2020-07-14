using MySql.Data.MySqlClient.Memcached;
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
    public partial class form_addClient : Form
    {
        public form_addClient()
        {
            InitializeComponent();
        }

        private void btn_addClient_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbTAG.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
                return;
            }

            CreateClient();
        }

        private void CreateClient()
        {
            ClientBus clientBusiness = new ClientBus();
            Clients client = clientBusiness.FindByTAG(tbTAG.Text);

            if(client is null)
            {
                try
                {
                    clientBusiness.Insert(new Clients()
                    {
                        name = tbName.Text,
                        phone = Regex.Replace(tbPhone.Text, @"[^\d]", ""),
                        TAG = tbTAG.Text
                    });

                    MessageBox.Show("Cliente criado com sucesso");
                    this.Close();

                } catch(Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    MessageBox.Show("Ocorreu um erro ao criar o usuário. Por favor, tente novamente");
                }
            }
            else
            {
                MessageBox.Show("Já existe um cliente com a TAG inserida");
                return;
            }

        }
    }
}
