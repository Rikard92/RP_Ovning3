using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Wolfman : Wolf, Iperson
    {
        public Wolfman(string name, int age, int weight, string size, int pacSize) : base(name, age, weight, size, pacSize)
        {
            this.pacSize = pacSize;
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Size = size;
        }

        public string Talk()
        {
            return "Hello world";
        }

        string Iperson.Stats()
        {
            string ret = "Age:" + this.Age + " Weight:" + this.Weight + " Size:" + this.Size + " Name:" + this.Name, Age, Weight, Size, name;
            return ret;
        }
    }
}
