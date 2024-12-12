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
            else
            {
                banco.idbco = Convert.ToInt32(codigo.Text);
                BLL.ActualizarBanco(banco);
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
        private void BuscarInformacion(TextBox valorBuscar)
        { 
            DataView dv = null;
            dv=new DataView(dsdatos.Tables["Datos"],"descripcion LIKE '*"+ valorBuscar.Text.Replace("'","")+"*' ", "descripcion Desc",DataViewRowState.CurrentRows);
            gridbancos.DataSource= dv;
        }

        private void gridbancos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tipo = 1;
            codigo.Text = gridbancos[0,gridbancos.CurrentCell.RowIndex].Value.ToString();
            descripcion.Text = gridbancos[1,gridbancos.CurrentCell.RowIndex].Value.ToString();
            descripcion.Focus();
        }

        private void busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) BuscarInformacion(busqueda);

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (codigo.Text.Length > 0)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el registro?", Application.ProductName, MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var banco = new Banco
                    {
                        idbco = Convert.ToInt32(codigo.Text)
                    };
                    BLL.EliminarBanco(banco);
                    CargarBancos();
                }
            }
        }
    }
}
