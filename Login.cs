using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mercadao
{
    public partial class Login : Form
    {
        public bool habilita;
        public Login(bool habilita)
        {
            InitializeComponent();
            habilita = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String senha = textBox2.Text;
            if (login.Equals("")|| senha.Equals(""))
            {
                MessageBox.Show("Preencha todos os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string query = "SELECT 1 FROM usuarios WHERE login = '" + login + "' and senha = '" + senha +"'";

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=Mercado;Integrated Security=True;Pooling=False"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    habilita = false;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }

        }
    }
}
