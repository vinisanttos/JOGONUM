using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            con.Open(); //ABRIR a conexao com o banco.
        }
        //TENTA FECHAR A CONEXAO COM O BANCO.
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //RETORNA A CONEXAO QUE FOI ABERTA.
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
        //Data Source = sqlexpress; Initial Catalog = PR2CJ302217XTNSDOVINI; User ID = aluno; Password = ***********; Encrypt = False