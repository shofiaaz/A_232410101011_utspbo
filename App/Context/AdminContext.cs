using A_232410101011_utspbo.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101011_utspbo.App.Context
{
    internal class AdminContext : DatabaseWrapper
    {
        {
            private static string table = "admin";
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataAdmin = queryExecutor(query);
            return dataAdmin;
        }
        public static void AddProdi(M_dataAdmin newAdmin)
        {
            string query = $"INSERT INTO {table} (nama_admin) values (@nama_admin)";
            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@nama_admin", NpgsqlDbType.Varchar){Value =
        newProdi.nama_prodi},
};
            commandExecutor(query, parameters);
        }
        public static void UpdateProdi(M_Admin editProdi)
        {
            string query = $"UPDATE {table} SET nama_prodi = @nama_prodi WHERE id =
        @id";
        NpgsqlParameter[] parameters =
        {
        new NpgsqlParameter("@nama_admin", NpgsqlDbType.Varchar){Value =
        editProdi.nama_admin},
        new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = editAdmin.id}
};
            commandExecutor(query, parameters);
        }
}
