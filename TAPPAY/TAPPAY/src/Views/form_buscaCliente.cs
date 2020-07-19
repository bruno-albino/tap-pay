using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAPPAY.src.Business.Models;
using TAPPAY.src.Domain.Models;

namespace TAPPAY.src.Views
{
    public partial class form_buscaCliente : Form
    {
        private ClientBus clientBusiness;
        private List<Clients> clients;
        public form_buscaCliente()
        {
            InitializeComponent();
            
            clientBusiness = new ClientBus();
            clients = new List<Clients>();

        }

        private void loadClients()
        {
            clients = clientBusiness.GetAll();

            clients.ForEach(client => client.phone = phoneMask(client.phone));
            
            dgClients.DataSource = clients;
            dgClients.Columns["id"].HeaderText = "ID";
            dgClients.Columns["id"].DisplayIndex = 0;
            dgClients.Columns["name"].HeaderText = "NOME";
            dgClients.Columns["beers"].HeaderText = "CERVEJAS";
            dgClients.Columns["phone"].HeaderText = "TELEFONE";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgClients.DataSource = clients.FindAll(client => client.name.ToString().ToLower().Contains(query.Text.ToLower()) || client.phone.Contains(query.Text.ToLower()) || client.TAG.Contains(query.Text.ToLower()));
        }

        private void dgClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Clients> teste = (List<Clients>) dgClients.DataSource;
            form_addClient formAddClient = new form_addClient(teste[e.RowIndex]);
            formAddClient.Show();
        }

        private string phoneMask(string value)
        {
            if (value is null)
            {
                return value;
            }

            //Máscara para Celular
            if (value[2] == '9')
            {

                if (value.Length > 1 && value.Length <= 2)
                {
                    return '(' + value;
                }
                if (value.Length > 1 && value.Length <= 3)
                {
                    return '(' + value.Substring(0, 2) + ") " + value.Substring(2, 3);
                }

                if (value.Length > 3 && value.Length <= 7)
                {
                    return '(' + value.Substring(0, 2) + ") " + value.Substring(2, 3) + ' ' + value.Substring(3, 7);
                }

                if (value.Length > 7)
                {
                    return '(' + value.Substring(0, 2) + ") " + value.Substring(2, 5) + '-' + value.Substring(7, value.Length - 7);
                }
                return value;
            }

            //Máscara para Telefone fixo
            if (value.Length >= 1 && value.Length <= 2)
            {
                return '(' + value;
            }

            if (value.Length > 1 && value.Length <= 3)
            {
                return '(' + value.Substring(0, 2) + ") " + value.Substring(2, 3);
            }

            if (value.Length > 3 && value.Length <= 6)
            {
                return '(' + value.Substring(0, 2) + ") " + value.Substring(2, 3);
            }

            if (value.Length > 6)
            {
                //string real = value;
                //string initial = value.Substring(0, 2);
                //string number = real.Substring(2, real.Length - 2);
                //string cell = $"({initial}){number}";
                return '(' + value.Substring(0, 2) + ") " + value.Substring(2, 4) + '-' + value.Substring(6, value.Length - 6);
                //return cell;
            }

            return value;
        }

        private void form_buscaCliente_Activated(object sender, EventArgs e)
        {
            this.loadClients();
        }

        private void form_buscaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
