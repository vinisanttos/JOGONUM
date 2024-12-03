using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows;

namespace JOGONUM.controller
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ302217XTNSDOVINI";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";
        public Connection()
        {
            string stringConnection = @"Data Source = " + Server
            + ";Initial Catalog = " + DataBase
             + "; DataBase = " + DataBase
             + "; User Id = " + Username
            + "; Password= " + Password
            + "; Encrypt = false";

            con = new SqlConnection(stringConnection);
            con.Open(); // Abrir a conexão com o banco
        }

        // Método para fechar a conexão
        public void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Método para retornar a conexão aberta
        public SqlConnection ReturnConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                return con; // Retorna a conexão se estiver aberta
            }
            else
            {
                throw new InvalidOperationException("A conexão não está aberta.");
            }
        }
    }
}
            //string stringConnection = @"Data Source = " + Server
            //+ ";Initial Catalog = " + DataBase
            // + "; DataBase = " + DataBase
            // + "; User Id = " + Username
            //+ "; Password= " + Password
            //+ "; Encrypt = false";

//con = new SqlConnection(stringConnection);
//con.Open(); //ABRIR a conexao com o banco.
//}
//TENTA FECHAR A CONEXAO COM O BANCO.
//public void CloseConnection()
//  {
//     if (con.State == ConnectionState.Open)
//         con.Close();
// }

// internal SqlConnection ReturnConnection()
//  {
//     throw new NotImplementedException();
// }

//RETORNA A CONEXAO QUE FOI ABERTA.
//  public SqlConnection

//}
//Data Source = sqlexpress; Initial Catalog = PR2CJ302217XTNSDOVINI; User ID = aluno; Password = ***********; Encrypt = False