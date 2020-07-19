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
        private ClientBus clientBusiness;
        private int? clientId;
        private string clientBeers;
        public form_addClient()
        {
            InitializeComponent();
            clientBusiness = new ClientBus();
            clientId = null;

        }

        public form_addClient(Clients client)
        {
            InitializeComponent();
            clientBusiness = new ClientBus();

            btn_addClient.Text = "Atualizar";
            tbName.Text = client.name;
            tbPhone.Text = Regex.Replace(client.phone, @"[^\d]", "");
            tbTAG.Text = client.TAG;
            this.clientId = client.id;
            this.clientBeers = client.beers;

        }

        private void btn_addClient_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbTAG.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
                return;
            }

            if (Regex.Replace(tbPhone.Text, @"[^\d]", "").Length < 11)
            {
                MessageBox.Show("Telefone incompleto");
                return;
            }


            Clients client = clientBusiness.FindByTAG(tbTAG.Text);

            if(client is null)
            {
                if(this.clientId is null)
                {
                    this.CreateClient();
                }
                else
                {
                    this.UpdateClient();
                }

            }
            else
            {
                if (client.id == this.clientId)
                {
                    this.UpdateClient();
                }
                else
                {
                    MessageBox.Show("Já existe um cliente com a TAG inserida");
                    return;
                }
            }
        }

        private void CreateClient()
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

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Ocorreu um erro ao criar o usuário. Por favor, tente novamente");
            }
        }


        private void UpdateClient()
        {
            try
            {
                clientBusiness.Update(new Clients()
                {
                    id = int.Parse(clientId.ToString()),
                    name = tbName.Text,
                    phone = Regex.Replace(tbPhone.Text, @"[^\d]", ""),
                    TAG = tbTAG.Text,
                    beers = this.clientBeers
                });

                MessageBox.Show("Cliente atualizado com sucesso");
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Ocorreu um erro ao criar o usuário. Por favor, tente novamente");
            }
        }

        private void form_addClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
