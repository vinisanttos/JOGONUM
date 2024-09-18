using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGONUM.model
{
    internal class TELADELOGIN
    {
        public int CodTELADELOGIN { get; set; }
        public string Usuario { get; set; }
        public string Senha {  get; set; }

        public TELADELOGIN(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
