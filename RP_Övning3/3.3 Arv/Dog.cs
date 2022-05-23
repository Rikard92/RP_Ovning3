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

        public Dog(string name, int age, int weight, string size, int triksKnown) : base(name, age, weight, size)
        {
            this.triksKnown = triksKnown;
            this.Name = name;
            Age = age;
            this.Weight = weight;
            this.Size = size;
        }

        public override string Stats()
        {
            string ret = "Age:" + this.Age + " Weight:"+this.Weight+" Size:"+this.Size+ " Number of Triks it knows:" + this.triksKnown + " Name:" + this.Name, Age, Weight, Size, triksKnown, name;
            return ret;
        }
    }
}
