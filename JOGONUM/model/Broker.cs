using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGONUM.model
{
    internal class Broker
    {
        public int CodUser { get; set; }
        public string Brokerusuario { get; set; }
        public int User { get; set; }
        public string Pass { get; private set; }
        

        public Broker(string CodUser, string Pass)
        {
            CodUser = CodUser;
            Pass = Pass;
        }

        public Broker(int CodUser, string brokerName, string brokerCode,
            string state, int codeArea, string telephone, string email,
            string password) : this(brokerName, brokerCode, state, codeArea,
            telephone, email, password)
        {
            Id = id;
        }

        public Broker(string brokerName, string brokerCode,
            string state, int codeArea, string telephone, string email, string password)
        {
            BrokerName = brokerName;
            BrokerCode = brokerCode;
            State = state;
            CodeArea = codeArea;
            Telephone = telephone;
            Email = email;
            Password = password;
        }
    }
}
