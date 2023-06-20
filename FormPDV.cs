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
                    textBox6.Text = string.Empty;
                    textBox5.Text = string.Empty;
                    textBox4.Text = string.Empty;
                }

                reader.Close();
            }
        }

        private void FormPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11 )
            {
                var form = new Login(numericUpDown2.ReadOnly);
                form.ShowDialog();
                if (!form.habilita)
                {
                    numericUpDown2.ReadOnly = false;
                    label4.Text = "<F1> Adiciona <F5> Estornar <F10> Finalizar <F12> Nova Fita";
                }
                e.Handled = true;
            }
        }
    }
}
