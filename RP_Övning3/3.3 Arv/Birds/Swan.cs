using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3._3._3_Arv
{
    internal class Swan : Bird
    {
        public double neckLegnth;

        public Swan(string name, int age, int weight, string size, double wingspan, double neckLegnth) : base(name, age, weight, size, wingspan)
        {
            this.neckLegnth = neckLegnth;
        }

        public override string Stats()
        {
            string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Wingspan:" + this.wingspan + " NeckLegnth:" + this.neckLegnth + " Name:" + this.Name, Age, Weight, Size, wingspan, neckLegnth, name;
            return ret;
        }
    }
}
