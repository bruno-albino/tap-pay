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
using TAPPAY.src.config;
using TAPPAY.src.Domain.Models;

namespace TAPPAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            //DataTable retorno = new DataTable();
            //retorno.Load(config.getAll());
            //var linha = retorno.DefaultView[0].Row;
            //Console.WriteLine(linha.ToString());

            ClientBusiness clientbusiness = new ClientBusiness();
            var clients = clientbusiness.GetList();
            clients.ForEach(client => Console.WriteLine(client.name));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
