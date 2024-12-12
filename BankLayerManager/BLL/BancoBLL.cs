using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;



namespace BLL
{
    public class BancoBLL
    {
        private readonly BancoRepository _bancoRepository = new BancoRepository();

        public DataSet ObtenerBancos()
        {
            string sql = "SELECT idbco, descripcion FROM voucherdb.bancos";
            return _bancoRepository.ExecuteQuery(sql);
        }

        public void AgregarBanco(Banco banco) => _bancoRepository.InsertBanco(banco);
  
        public void ActualizarBanco(Banco banco) => _bancoRepository.UpdateBanco(banco);

        public void EliminarBanco(Banco banco) => _bancoRepository.DeleteBanco(banco);


    }
}
