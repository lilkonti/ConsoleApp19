using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Money
    {
        public string valute;
        public string cent;
        public void Show()
        {
            Console.WriteLine(valute + "." + cent);
        }
        public void getValute()
        {
            this.valute = Console.ReadLine();
        }
        public void getCent()
        {
            this.cent = Console.ReadLine();
        }
    }
    internal class Product : Money
    {
        public Money money = new Money();
        public string sell;
        void changeSell () 
        {
            this.sell = Console.ReadLine();
        }
    }
}
