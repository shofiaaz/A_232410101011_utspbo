using A_232410101011_utspbo.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101011_utspbo.App.Context
{
    internal class CustomerContext : DatabaseWrapper
    {
        private static string table = "customer";
        public static DataTable All()
        {
            string query = @"
SELECT
m.nama,
m.alamat
m.email,
m.telepon,
m.username,
FROM
customer m
        }
        public static DataTable getMahasiswaById(int id)
        {
            string query = @"
SELECT
m.nama,
m.alamat
m.email,
m.telepon,
m.username,
FROM
customer m
FROM
customer m
            {
new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {
Value = id }
};
            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }
    }
}
