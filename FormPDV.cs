using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mercadao
{
    public partial class FormPDV : Form
    {
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
            else if(codigo > 0)
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
            if (e.KeyCode == Keys.F11)
            {
                if (label4.Text.Length > 1)//usuário já está logado
                {
                    MessageBox.Show("Você já está logado, para trocar de usuário, finalize o PDV!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    var form = new Login(numericUpDown2.ReadOnly);
                    form.ShowDialog();
                    if (!form.naoLogado)//logou
                    {
                        label3.Text = "Usuário: " + form.usuario;
                        label4.Text = "<F12> Nova Fita";
                    }
                }

                e.Handled = true;
            }

            if (e.KeyCode == Keys.F12 && label4.Text.Length > 1)
            {
                numericUpDown2.ReadOnly = false;
                label4.Text = "<F1> Adiciona <F12> Nova Fita";
                numericUpDown2.Focus();
                e.Handled = true;
            }
        }
    }
}
