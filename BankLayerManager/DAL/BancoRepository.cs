using DAL.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class BancoRepository
    {
        private readonly DBConnection dBConnection = new DBConnection();

        public DataSet ExecuteQuery(string sql)
        {
            using (var conn = dBConnection.GetConnection())
            {
                conn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Datos");
                return dataSet;
            }
        }

        public void InsertBanco(Banco banco)
        {
            using (var conn = dBConnection.GetConnection())
            {
                conn.Open();
                var sql = "INSERT INTO voucherdb.bancos(descripcion)" +
                    "VALUES (@descripcion)";
                using (var command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@descripcion", banco.descripcion);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
