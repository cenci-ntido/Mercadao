namespace Mercadao
{
    partial class FormProdutosCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label unidadeLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.Label estoqueInternoLabel;
            System.Windows.Forms.Label estoqueGondolaLabel;
            System.Windows.Forms.Label imagemPathLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutosCadastro));
            this.mercadoDataSet = new Mercadao.MercadoDataSet();
            this.iTENSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSTableAdapter = new Mercadao.MercadoDataSetTableAdapters.ITENSTableAdapter();
            this.tableAdapterManager = new Mercadao.MercadoDataSetTableAdapters.TableAdapterManager();
            this.iTENSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iTENSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.unidadeTextBox = new System.Windows.Forms.TextBox();
            this.precoUnitMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.estoqueInternoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.estoqueGondolaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.imagemPathPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            unidadeLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            estoqueInternoLabel = new System.Windows.Forms.Label();
            estoqueGondolaLabel = new System.Windows.Forms.Label();
            imagemPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSBindingNavigator)).BeginInit();
            this.iTENSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPathPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(46, 66);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(46, 95);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "descricao:";
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new System.Drawing.Point(46, 121);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new System.Drawing.Size(48, 13);
            unidadeLabel.TabIndex = 5;
            unidadeLabel.Text = "unidade:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(46, 147);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(59, 13);
            precoUnitLabel.TabIndex = 7;
            precoUnitLabel.Text = "preco Unit:";
            // 
            // estoqueInternoLabel
            // 
            estoqueInternoLabel.AutoSize = true;
            estoqueInternoLabel.Location = new System.Drawing.Point(46, 173);
            estoqueInternoLabel.Name = "estoqueInternoLabel";
            estoqueInternoLabel.Size = new System.Drawing.Size(84, 13);
            estoqueInternoLabel.TabIndex = 9;
            estoqueInternoLabel.Text = "estoque Interno:";
            // 
            // estoqueGondolaLabel
            // 
            estoqueGondolaLabel.AutoSize = true;
            estoqueGondolaLabel.Location = new System.Drawing.Point(46, 199);
            estoqueGondolaLabel.Name = "estoqueGondolaLabel";
            estoqueGondolaLabel.Size = new System.Drawing.Size(91, 13);
            estoqueGondolaLabel.TabIndex = 11;
            estoqueGondolaLabel.Text = "estoque Gondola:";
            // 
            // imagemPathLabel
            // 
            imagemPathLabel.AutoSize = true;
            imagemPathLabel.Location = new System.Drawing.Point(303, 66);
            imagemPathLabel.Name = "imagemPathLabel";
            imagemPathLabel.Size = new System.Drawing.Size(71, 13);
            imagemPathLabel.TabIndex = 13;
            imagemPathLabel.Text = "imagem Path:";
            // 
            // mercadoDataSet
            // 
            this.mercadoDataSet.DataSetName = "MercadoDataSet";
            this.mercadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSBindingSource
            // 
            this.iTENSBindingSource.DataMember = "ITENS";
            this.iTENSBindingSource.DataSource = this.mercadoDataSet;
            // 
            // iTENSTableAdapter
            // 
            this.iTENSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUPONSTableAdapter = null;
            this.tableAdapterManager.ITENSCUPONSTableAdapter = null;
            this.tableAdapterManager.ITENSTableAdapter = this.iTENSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mercadao.MercadoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // iTENSBindingNavigator
            // 
            this.iTENSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSBindingNavigator.BindingSource = this.iTENSBindingSource;
            this.iTENSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iTENSBindingNavigatorSaveItem});
            this.iTENSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSBindingNavigator.Name = "iTENSBindingNavigator";
            this.iTENSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.iTENSBindingNavigator.TabIndex = 0;
            this.iTENSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iTENSBindingNavigatorSaveItem
            // 
            this.iTENSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSBindingNavigatorSaveItem.Image")));
            this.iTENSBindingNavigatorSaveItem.Name = "iTENSBindingNavigatorSaveItem";
            this.iTENSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSBindingNavigatorSaveItem.Text = "Save Data";
            this.iTENSBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSBindingNavigatorSaveItem_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iTENSBindingSource, "Id", true));
            this.idNumericUpDown.Location = new System.Drawing.Point(143, 66);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.idNumericUpDown.TabIndex = 2;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(143, 92);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(120, 20);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // unidadeTextBox
            // 
            this.unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSBindingSource, "unidade", true));
            this.unidadeTextBox.Location = new System.Drawing.Point(143, 118);
            this.unidadeTextBox.Name = "unidadeTextBox";
            this.unidadeTextBox.Size = new System.Drawing.Size(120, 20);
            this.unidadeTextBox.TabIndex = 6;
            // 
            // precoUnitMaskedTextBox
            // 
            this.precoUnitMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSBindingSource, "precoUnit", true));
            this.precoUnitMaskedTextBox.Location = new System.Drawing.Point(143, 144);
            this.precoUnitMaskedTextBox.Name = "precoUnitMaskedTextBox";
            this.precoUnitMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.precoUnitMaskedTextBox.TabIndex = 8;
            // 
            // estoqueInternoMaskedTextBox
            // 
            this.estoqueInternoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSBindingSource, "estoqueInterno", true));
            this.estoqueInternoMaskedTextBox.Location = new System.Drawing.Point(143, 170);
            this.estoqueInternoMaskedTextBox.Name = "estoqueInternoMaskedTextBox";
            this.estoqueInternoMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.estoqueInternoMaskedTextBox.TabIndex = 10;
            // 
            // estoqueGondolaMaskedTextBox
            // 
            this.estoqueGondolaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSBindingSource, "estoqueGondola", true));
            this.estoqueGondolaMaskedTextBox.Location = new System.Drawing.Point(143, 196);
            this.estoqueGondolaMaskedTextBox.Name = "estoqueGondolaMaskedTextBox";
            this.estoqueGondolaMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.estoqueGondolaMaskedTextBox.TabIndex = 12;
            // 
            // imagemPathPictureBox
            // 
            this.imagemPathPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iTENSBindingSource, "imagemPath", true));
            this.imagemPathPictureBox.Location = new System.Drawing.Point(306, 88);
            this.imagemPathPictureBox.Name = "imagemPathPictureBox";
            this.imagemPathPictureBox.Size = new System.Drawing.Size(453, 218);
            this.imagemPathPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemPathPictureBox.TabIndex = 14;
            this.imagemPathPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(453, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProdutosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(unidadeLabel);
            this.Controls.Add(this.unidadeTextBox);
            this.Controls.Add(precoUnitLabel);
            this.Controls.Add(this.precoUnitMaskedTextBox);
            this.Controls.Add(estoqueInternoLabel);
            this.Controls.Add(this.estoqueInternoMaskedTextBox);
            this.Controls.Add(estoqueGondolaLabel);
            this.Controls.Add(this.estoqueGondolaMaskedTextBox);
            this.Controls.Add(imagemPathLabel);
            this.Controls.Add(this.imagemPathPictureBox);
            this.Controls.Add(this.iTENSBindingNavigator);
            this.Name = "FormProdutosCadastro";
            this.Text = "FormProdutosCadastro";
            this.Load += new System.EventHandler(this.FormProdutosCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSBindingNavigator)).EndInit();
            this.iTENSBindingNavigator.ResumeLayout(false);
            this.iTENSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPathPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MercadoDataSet mercadoDataSet;
        private System.Windows.Forms.BindingSource iTENSBindingSource;
        private MercadoDataSetTableAdapters.ITENSTableAdapter iTENSTableAdapter;
        private MercadoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton iTENSBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox unidadeTextBox;
        private System.Windows.Forms.MaskedTextBox precoUnitMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox estoqueInternoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox estoqueGondolaMaskedTextBox;
        private System.Windows.Forms.PictureBox imagemPathPictureBox;
        private System.Windows.Forms.Button button1;
    }
}