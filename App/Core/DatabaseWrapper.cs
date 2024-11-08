﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_232410101011_utspbo.App.Core
{
    internal class DatabaseWrapper
    {
        // Properti credential database dan koneksinya
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "UTS_pbodb";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "131313";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;
        // Method open dan close Koneksi
        public static void openConnection()
            connection = new
NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Da
tabase={ DB_DATABASE}; Port={DB_PORT
    }");
connection.Open();
command = new NpgsqlCommand();
    command.Connection = connection;
}
public static void closeConnection()
{
    connection.Close();
    command.Parameters.Clear();
}
public static DataTable queryExecutor(string query, NpgsqlParameter[]
parameters = null)
{
    try
    {
        openConnection();
        DataTable dataTable = new DataTable();
        command.CommandText = query;
        if (parameters != null)
        {
            command.Parameters.AddRange(parameters);
            command.Prepare();
        }
        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
        dataAdapter.Fill(dataTable);
        closeConnection();
        return dataTable;
    }
    catch (Exception e)
    {
        throw new Exception(e.Message);
    }
}

public static void commandExecutor(string query, NpgsqlParameter[]
parameters = null)
{
    try
    {
        openConnection();
        command.CommandText = query;
        command.Parameters.AddRange(parameters);
        command.Prepare();
        command.Parameters.Clear();
        command.ExecuteNonQuery();
        closeConnection();
    }
    catch (Exception e)
    {
        throw new Exception(e.Message);
    }
    }
}
