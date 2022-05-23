using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Horse : Animal
    {
        public bool isrideble;
        public override string DoSound()
        {
            return "Neigh";
        }

        public Horse(string name, int age, int weight, string size, bool isrideble) : base(name, age, weight, size)
        {
            this.isrideble = isrideble;
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Size = size;
        }
        public override string Stats()
        {
            string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Is it rideble:" + this.isrideble + " Name:" + this.Name, Age, Weight, Size, isrideble, name;
            return ret;
        }
    }
}
