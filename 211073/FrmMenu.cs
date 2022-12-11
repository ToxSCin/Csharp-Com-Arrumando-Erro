using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211073.Views;

namespace _211073
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

      
        private void caixaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
                FrmCaixa form = new FrmCaixa();
                form.Show();
            
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos form = new FrmProdutos();
            form.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas form = new FrmVendas();
            form.Show();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidade form = new FrmCidade();
            form.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas form = new FrmMarcas();
            form.Show();
        }
    }
}
