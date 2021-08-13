using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;
using System.Data.Common;

namespace LocadoraVeiculos.Controlador
{
    public delegate T ConverterDelegate<T>(IDataReader reader);
    public static class Db
    {
        
        private static readonly string banco;
        private static readonly string connectionString = "";
        private static readonly string nomeProvider;
        private static readonly DbProviderFactory fabricaProvedor;
        static Db()
        {
            banco = ConfigurationManager.AppSettings["bancoDeDados"];

            connectionString = ConfigurationManager.ConnectionStrings[banco].ConnectionString;

            nomeProvider = ConfigurationManager.ConnectionStrings[banco].ProviderName;

            fabricaProvedor = DbProviderFactories.GetFactory(nomeProvider);
        }

        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            if (banco == "sqlite")
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand command = new SQLiteCommand(sql.AppendSelectLastInsertRowId(), connection);

                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
                connection.Open();
                int id = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return id;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql.AppendSelectIdentity(), connection);

                command.SetParameters(parameters);

                connection.Open();
                int id = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return id;
            }

        }

        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            if (banco == "sqlite")
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand command = new SQLiteCommand(sql.AppendSelectLastInsertRowId(), connection);

                command.SetParametersSqlite(parameters);

                connection.Open();

                var list = new List<T>();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = convert(reader);
                        list.Add(obj);
                    }
                }

                connection.Close();
                return list;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql, connection);

                command.SetParameters(parameters);

                connection.Open();

                var list = new List<T>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var obj = convert(reader);
                    list.Add(obj);
                }

                connection.Close();
                return list;
            }

        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            if (banco == "sqlite")
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand command = new SQLiteCommand(sql.AppendSelectLastInsertRowId(), connection);

                command.SetParametersSqlite(parameters);
                connection.Open();

                T t = default;
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                        t = default;
                    else
                    {
                        reader.Read();
                        t = convert(reader);
                    }
                }
                connection.Close();
                return t;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql, connection);

                command.SetParameters(parameters);

                connection.Open();

                T t = default;

                var reader = command.ExecuteReader();

                if (reader.Read())
                    t = convert(reader);

                connection.Close();
                return t;
            }

        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            if (banco == "sqlite")
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand command = new SQLiteCommand(sql.AppendSelectLastInsertRowId(), connection);

                command.SetParametersSqlite(parameters);

                connection.Open();

                int numberRows = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return numberRows > 0;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql, connection);

                command.SetParameters(parameters);

                connection.Open();

                int numberRows = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return numberRows > 0;
            }

        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

        #region MÉTODOS PRIVADOS

        private static void SetParameters(this IDbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                IDataParameter dbParameter = command.CreateParameter();

                dbParameter.ParameterName = name;
                dbParameter.Value = value;

                command.Parameters.Add(dbParameter);
            }
        }

        private static void SetParametersSqlite(this SQLiteCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                SQLiteParameter dbParameter = new SQLiteParameter(name, value);

                command.Parameters.Add(dbParameter);
            }
        }

        private static string AppendSelectIdentity(this string sql)
        {
            return sql + ";SELECT SCOPE_IDENTITY()";
        }

        private static string AppendSelectLastInsertRowId(this string sql)
        {
            return sql + ";SELECT LAST_INSERT_ROWID();";
        }

        #endregion
    }
}

