using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3
{
    abstract class Animal
    {
        //3.3.14 Om all djur behöver ny atribyt bör jag skriva det här

        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public String Size { get; set; }

        public Animal(string name, int age, int weight, string size)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Size = size;
        }
        public virtual string Stats()
        {
            string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Name:" + this.Name , Age, Weight, Size, name;
            return ret;
        }

        public abstract string DoSound();
    }
}
