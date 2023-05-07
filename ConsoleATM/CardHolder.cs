using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleATM
{
    public class CardHolder
    {
        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            CardNum = cardNum;
            Pin = pin;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;

        }


        public string CardNum { get; set; }

        public int Pin { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Balance { get; set; }
    }
}
