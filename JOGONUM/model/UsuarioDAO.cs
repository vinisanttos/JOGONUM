using JOGONUM.controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JOGONUM.model
{
    internal class UsuarioDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        public UsuarioDAO() //sempre o nome da Classe
        { 
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Usuario usu)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO TELADELOGIN VALUES (@user, @pass)";

            Command.Parameters.AddWithValue("@user", usu.User);
            Command.Parameters.AddWithValue("@pass", usu.Pass);

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        
    }
}
