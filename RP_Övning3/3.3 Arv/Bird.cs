using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Bird : Animal
    {
        //3.3.13 Om all fåglar behöver ny attribut bör jag skriva det här, annarsom en specifik fågel behöver ett nytt attribut skriver jag i den klassen som tillhör 

        public double wingspan;
        public override string DoSound()
        {
            return "Caw";   
        }
        public Bird(string name, int age, int weight, string size, double wingspan) : base( name, age, weight, size)
        {
            this.wingspan = wingspan;
        }

        public override string Stats()
        {
            string ret = base.Stats() + $", Wingspan: {wingspan}";
            return ret;
        }
    }
}
