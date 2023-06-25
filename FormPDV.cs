using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mercadao

{

    public partial class FormPDV : Form
    {
        private const int larguraColunaCodigo = 8;
        private const int larguraColunaProduto = 30;
        private const int larguraColunaQuantidade = 10;
        private const int larguraColunaTotalItem = 8;
        private double ValorTotal { get; set; }
        private List<Produto> produtos { get; set; } = new List<Produto>();

        public FormPDV()
        {
            InitializeComponent();
        }

        private void numericUpDown2_Leave(object sender, EventArgs e)
        {
            int codigo = (int)numericUpDown2.Value;

            if (codigo == 0 && !numericUpDown2.ReadOnly)
            {
                MessageBox.Show("O código não pode ser zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (codigo > 0)
            {
                string query = "SELECT descricao, precoUnit FROM ITENS WHERE Id = " + codigo;

                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=Mercado;Integrated Security=True;Pooling=False"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox6.Text = reader["descricao"].ToString();
                        textBox5.Text = reader["precoUnit"].ToString();
                        textBox4.Text = reader["precoUnit"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        numericUpDown2.Focus();
                    }

                    reader.Close();
                }
            }
        }

        private void FormPDV_KeyDown(object sender, KeyEventArgs e)
        {
            // LOGIN
            if (e.KeyCode == Keys.F11)
            {
                if (label4.Text.Length > 1) // usuário já está logado
                {
                    MessageBox.Show("Você já está logado, para trocar de usuário, finalize o PDV!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var form = new Login(numericUpDown2.ReadOnly);
                    form.ShowDialog();
                    if (!form.naoLogado) // logou
                    {
                        label3.Text = "Usuário: " + form.usuario;
                        label4.Text = "<F12> Nova Fita";
                    }
                }

                e.Handled = true;
            }

            // NOVA FITA
            if (e.KeyCode == Keys.F12 && label4.Text.Length > 1)
            {
                numericUpDown2.ReadOnly = false;
                label4.Text = "<F1> Adiciona <F12> Nova Fita";
                numericUpDown2.Focus();
                string cupomFiscal = "Supermercado Bom de Preço - CNPJ 00.000.000/0000-00";
                string cabecalho = "Cód".PadRight(larguraColunaCodigo) +
                                    "Produto".PadRight(larguraColunaProduto) +
                                    "Qtd".PadRight(larguraColunaQuantidade) +
                                    "Total item(R$)".PadRight(larguraColunaTotalItem);
                string linhaSeparadora = new string('-', larguraColunaCodigo + larguraColunaProduto + larguraColunaQuantidade + larguraColunaTotalItem + 6);
                textBox1.AppendText(cupomFiscal + Environment.NewLine);
                textBox1.AppendText(linhaSeparadora + Environment.NewLine);
                textBox1.AppendText(cabecalho + Environment.NewLine);
                textBox1.AppendText(linhaSeparadora + Environment.NewLine);
                e.Handled = true;
            }

            // MENU SUPERVISOR
            if (e.KeyCode == Keys.F8)
            {
                var form = new FormMenu();
                form.Show();
                e.Handled = true;
            }

            // ADICIONAR NA FITA
            if (e.KeyCode == Keys.F1 && textBox6.Text.Length > 2)
            {
                int qtdProduto = 1;
                string codigo = numericUpDown2.Value.ToString();
                string nome = textBox6.Text;
                string quantidade = qtdProduto.ToString();
                string totalItem = textBox4.Text;

                if (ValidaProdutoJaExiste(codigo))
                {
                    Produto prodExiste = RetornaProdutoExistente(codigo);
                    AtualizaValoresProduto(prodExiste);
                    AtualizarCupom();

                }
                else
                {
                    Produto product = new Produto(codigo, nome, quantidade, totalItem);
                    produtos.Add(product);
                    AtualizarCupom();
                }

                e.Handled = true;
            }
        }

        private void AdicionarProduto(Produto product)
        {
            string item = product.cod.PadRight(larguraColunaCodigo) +
                product.produto.PadRight(larguraColunaProduto) +
                product.qtd.PadRight(larguraColunaQuantidade) +
                product.valorTot.PadRight(larguraColunaTotalItem) +
                " +";

            textBox1.AppendText(item + Environment.NewLine);

            double valorItem = double.Parse(product.valorTot);
            ValorTotal += valorItem;
        }

        private void AddTotalCupom()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('=', larguraColunaCodigo + larguraColunaProduto + larguraColunaQuantidade + larguraColunaTotalItem + 6));
            sb.AppendLine("Total geral".PadRight(larguraColunaCodigo + larguraColunaProduto + larguraColunaQuantidade) + ValorTotal.ToString("F2"));

            textBox1.AppendText(sb.ToString());
        }

        private void AtualizarCupom()
        {
            textBox1.Clear();

            string cupomFiscal = "Supermercado Bom de Preço - CNPJ 00.000.000/0000-00";
            string cabecalho = "Cód".PadRight(larguraColunaCodigo) +
                                "Produto".PadRight(larguraColunaProduto) +
                                "Qtd".PadRight(larguraColunaQuantidade) +
                                "Total item(R$)".PadRight(larguraColunaTotalItem);
            string linhaSeparadora = new string('-', larguraColunaCodigo + larguraColunaProduto + larguraColunaQuantidade + larguraColunaTotalItem + 6);

            textBox1.AppendText(cupomFiscal + Environment.NewLine);
            textBox1.AppendText(linhaSeparadora + Environment.NewLine);
            textBox1.AppendText(cabecalho + Environment.NewLine);
            textBox1.AppendText(linhaSeparadora + Environment.NewLine);

            foreach (var product in produtos)
            {
                AdicionarProduto(product);
            }

            AddTotalCupom();
        }

        private bool ValidaProdutoJaExiste(String codigo)
        {
            int index = -1;
            bool existe = false;
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].cod == codigo)
                {
                    existe = true;
                    index = i;
                    break;
                }
                else
                {
                    existe = false;
                }
            }
            return existe;
        }

        private Produto RetornaProdutoExistente(string codigo)
        {
            int index = -1;

            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].cod == codigo)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                return produtos[index];
            }

            return null;
        }

        private void AtualizaValoresProduto(Produto produto)
        {
            //Atualiza quantidade
            double quant = double.Parse(produto.qtd);
            quant++;
            produto.qtd = quant.ToString();
            //Atualiza valor
            double vlr = double.Parse(produto.valorTot);
            vlr *= 2;
            produto.valorTot = vlr.ToString();
            //Atualizar valor total tela
            textBox4.Text = vlr.ToString();
        }
    }
}
