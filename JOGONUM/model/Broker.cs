using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGONUM.model
{
    internal class Broker
    {
        public int CodUsu { get; set; }
        public string Brokerusuario { get; set; }
        public string Usuario { get; set; }
        public string Modelo { get; set; }
        public float Preco { get; set; }
        public float Desconto { get; set; }
        public string Password { get; set; }


        public Broker(string Usuario, string Password)
        {
            Usuario = Usuario;
            Password = Password;
        }

        public Broker(string brokerusuario, string Usuario,
            string Password) : this(Usuario, Password)
        {
            CodUsu = CodUsu;
        }

        public Broker(string brokerusuario, string Usuario, string Modelo, float Preco, float Desconto, 
            string Password)
        {
            Brokerusuario = brokerusuario;
            Usuario = Usuario;
            Modelo = Modelo;
            Preco = Preco;
            Desconto = Desconto;
            Password = Password;
        }
    }
}
