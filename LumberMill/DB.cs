using Npgsql;
using System.Data;

namespace LumberMill;

public static partial class DB
{
    public static DataTable Query(string sql, params NpgsqlParameter[] parameters)
    {
        using var conn = new NpgsqlConnection(ConnStr);
        using var da = new NpgsqlDataAdapter(sql, conn);
        da.SelectCommand!.Parameters.AddRange(parameters);
        var table = new DataTable();
        da.Fill(table);
        return table;
    }

    public static void Execute(string sql, params NpgsqlParameter[] parameters)
    {
        using var conn = new NpgsqlConnection(ConnStr);
        conn.Open();
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddRange(parameters);
        cmd.ExecuteNonQuery();
    }
}