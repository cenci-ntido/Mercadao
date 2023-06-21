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
    public partial class FormProdutosCadastro : Form
    {
        public FormProdutosCadastro()
        {
            InitializeComponent();
        }

        private void iTENSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mercadoDataSet);

        }

        private void FormProdutosCadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mercadoDataSet.ITENS' table. You can move, or remove it, as needed.
            this.iTENSTableAdapter.Fill(this.mercadoDataSet.ITENS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                imagemPathPictureBox.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
            }
        }

        
    }
}
