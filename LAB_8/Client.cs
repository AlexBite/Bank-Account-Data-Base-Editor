using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    [Serializable]
    public class Client
    {
        public int ID;
        public string Name;
        public int CreditAmount;
        public CreditType creditType;
        public int Term;
        public enum CreditType
        {
            Ипотека = 0,
            Потребительский = 1,
            Автокредит = 2
        }
    }
}
