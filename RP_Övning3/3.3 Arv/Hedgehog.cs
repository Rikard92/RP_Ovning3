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
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Size = size;
        }
        public override string Stats()
        {
            string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " SpikeLegnth:" + this.spikeLegnth + " Name:" + this.Name, Age, Weight, Size, spikeLegnth, name;
            return ret;
        }
    }
}
