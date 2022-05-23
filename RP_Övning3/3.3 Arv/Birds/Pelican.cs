using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Pelican : Bird
    {
        public int billVolume;

        public Pelican(string name,  int age, int weight, string size, double wingspan, int billVolume) : base(name, age, weight, size, wingspan)
        {
            this.billVolume = billVolume;
        }

        public override string Stats()
        {
            string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Wingspan:" + this.wingspan + " Bill Volume:" + this.billVolume + " Name:" + this.Name, Age, Weight, Size, wingspan, billVolume, name;
            return ret;
        }
    }
}
