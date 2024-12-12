using DAL.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.ComponentModel;
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
        public void UpdateBanco(Banco banco)
        {
            using (var conn = dBConnection.GetConnection())
            {
                conn.Open();
                var sql = "UPDATE voucherdb.bancos SET descripcion= @descripcion " +
                        " WHERE idbco=@id";
                using (var command=new MySqlCommand(sql,conn))
                {
                    command.Parameters.AddWithValue("@descripcion", banco.descripcion);
                    command.Parameters.AddWithValue("@id", banco.idbco);
                    command.ExecuteNonQuery();
                }
            }            
        }
        public  void DeleteBanco(Banco banco)
        {
            using (var conn=dBConnection.GetConnection())
            {
                conn.Open();
                var sql = "DELETE FROM voucherdb.bancos WHERE idbco= @id";
                using (var command= new MySqlCommand(sql,conn))
                {
                    command.Parameters.AddWithValue("id", banco.idbco);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
