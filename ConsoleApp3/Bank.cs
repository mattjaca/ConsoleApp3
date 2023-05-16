using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bank
    {
        private decimal BankBalance = 10000m;
        private decimal John = 1250m;
        private decimal Paul = 2500m;
        private decimal George = 3000m;
        private decimal Ringo = 1000m;

        public decimal Withdraw(decimal y, decimal x)
        {
            if(x > 500)
            {
                y -= 500;
                return y;
            }
            y -= x;
            return y;
        }
        public decimal Deposit(decimal y, decimal x)
        {
            y += x;
            return y;
        }
        public decimal Vault
        {
            get { return BankBalance; }
        }

        public decimal Lennon
        {
            get { return John; }
        }
        public decimal Mccartney
        {
            get { return Paul; }
        }
        public decimal Harrison
        {
            get { return George; }
        }
        public decimal Starr
        {
            get { return Ringo; }
        }
    }
}

//jlennon      johnny	$1250
//pmccartney   pauly	$2500
//gharrison	   georgy	$3000
//rstarr	   ringoy	$1000
