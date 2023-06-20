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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

      

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mercadoDataSet.USUARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.uSUARIOSTableAdapter.Fill(this.mercadoDataSet.USUARIOS);

        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mercadoDataSet);

        }
    }
}
