using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAuteticacao.Classes;


namespace ModuloAuteticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {

            CarregarResponsabilidades();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidades();


        }

        private void CarregarResponsabilidades()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dvgNivel.DataSource = nivelPesquisa.Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            dvgNivel.DataSource = nivel.PesquisarPorNome(txtNome.Text);

        }
    }
    }