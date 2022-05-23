using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Worm : Animal
    {
        public bool IsPoisonous;
        public override string DoSound()
        {
            return "";
        }
        public Worm(string name, int age, int weight, string size, bool IsPoisonous) : base(name, age, weight, size)
        {
            this.IsPoisonous = IsPoisonous;
        }

        public override string Stats()
        {
            string ret = base.Stats() + $", IsPoisonous: {IsPoisonous}";
            return ret;
        }
    }
}
