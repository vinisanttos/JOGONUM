using JOGONUM.controller;
using JOGONUM.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
            Command.CommandText = @"INSERT INTO Usuario VALUES (@user, @pass)";

            Command.Parameters.AddWithValue("@user", usu.User);
            Command.Parameters.AddWithValue("@pass", usu.Pass);

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " + "problemas ao inserir no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public void Update(Usuario usu)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Usuario SET 
            Usuario = @usuario 
            WHERE Senha = @senha";
            Command.Parameters.AddWithValue("@usuario", usu.User);
            Command.Parameters.AddWithValue("@senha", usu.Pass);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public void Delete(int CodUsuario)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Usuario WHERE CodUsuario = @code";
            Command.Parameters.AddWithValue("@code", CodUsuario);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Usuario> ListALLUsuario()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Usuario";

            List<Usuario> users = new List<Usuario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario usu = new Usuario(
                        (string)rd["User"],
                        (string)rd["Pass"]
                        );
                    users.Add(usu);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();

            }
            return users;
        }
    }
}