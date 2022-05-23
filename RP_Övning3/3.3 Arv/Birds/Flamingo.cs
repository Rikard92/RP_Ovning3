
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Flamingo : Bird
    {
        public double legLenth;

        public Flamingo(string name, int age, int weight, string size, double wingspan, double legLenth) : base(name,age, weight, size, wingspan)
        {
            this.legLenth = legLenth;
        }

        public override string Stats()
        {
            string ret = base.Stats() + $", LegLenth: {legLenth}";
            return ret;
        }
    }
}
