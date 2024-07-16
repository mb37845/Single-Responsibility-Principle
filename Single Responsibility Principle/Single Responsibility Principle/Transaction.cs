using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class Transaction
    {
        public DateTime date { get; set; }
        public double amount { get; set; }
        public string source { get; set; }
        public string type { get; set; }
       


        public Transaction(DateTime Adate, double Aamount, string Asource, string Atype)
        {
            date = Adate;
            amount = Aamount;
            source = Asource;
            type = Atype;

        }

        



        


    }
}
