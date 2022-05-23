using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Hedgehog : Animal
    {
        public float spikeLegnth;
        public override string DoSound()
        {
            return "Pip";
        }

        public Hedgehog(string name, int age, int weight, string size, float spikeLegnth) : base(name, age, weight, size)
        {
            this.spikeLegnth = spikeLegnth;
        }
        public override string Stats()
        {
            string ret = base.Stats() + $", SpikeLegnth: {spikeLegnth}";
            return ret;
        }
    }
}
