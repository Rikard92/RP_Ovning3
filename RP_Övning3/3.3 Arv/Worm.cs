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
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Size = size;
        }

        public override string Stats()
        {
            string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Poisonous:" + this.IsPoisonous + " Name:" + this.Name, Age, Weight, Size, IsPoisonous, name;
            return ret;
        }
    }
}
