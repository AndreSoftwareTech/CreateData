using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorBanco;

public class CreateData
{
    public void CriarBancoDeDados(string caminhoBancoDados)
    {
        using (SQLiteConnection conexao = new SQLiteConnection($"Data Source={caminhoBancoDados};Version=3;"))
        {
            conexao.Open();

            // Comando SQL para criar uma tabela simples
            string sqlCriarTabela = "CREATE TABLE IF NOT EXISTS Exemplo (ID INTEGER PRIMARY KEY AUTOINCREMENT, Nome TEXT NOT NULL, Idade INTEGER);";

            using (SQLiteCommand comando = new SQLiteCommand(sqlCriarTabela, conexao))
            {
                comando.ExecuteNonQuery();
            }
        }
    }
}
