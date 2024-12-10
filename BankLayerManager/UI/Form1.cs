using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Models;
namespace UI
{
    public partial class frmbanco : Form
    {
        private BancoBLL BLL = new BancoBLL();
        DataSet dsdatos;
        int Tipo = 0;
        public frmbanco()
        {
            InitializeComponent();
            CargarBancos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CargarBancos()
        {
            dsdatos = BLL.ObtenerBancos();
            gridbancos.DataSource = dsdatos;
            gridbancos.DataMember = "Datos";
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            var banco = new Banco
            {
                descripcion = descripcion.Text
            };

            if (Tipo == 0)
            {
                BLL.AgregarBanco(banco);
            }
            CargarBancos();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Tipo = 0;
            codigo.Clear();
            descripcion.Clear();
            descripcion.Focus();
        }
    }
}
