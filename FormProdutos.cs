using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadao
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }


        private void FormProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mercadoDataSet.ITENS'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSTableAdapter.Fill(this.mercadoDataSet.ITENS);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new FormProdutosCadastro().ShowDialog();
        }
    }
}
