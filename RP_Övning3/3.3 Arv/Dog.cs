using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Dog : Animal
    {
        public int triksKnown;
        public override string DoSound()
        {
            return "Bork";
        }

        public string GoodBoySound()
        {
            return "Bof";
        }

        public Dog(string name, int age, int weight, string size, int triksKnown) : base(name, age, weight, size)
        {
            this.triksKnown = triksKnown;
        }

        public override string Stats()
        {
            string ret = base.Stats() + $", TriksKnown: {triksKnown}"; 
            return ret;
        }
    }
}
