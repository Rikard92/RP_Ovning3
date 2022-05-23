namespace RP_Övning3._3._3_Arv
{
    internal class Wolf : Animal
    {
        public int pacSize;
        public override string DoSound()
        {
            return "Wrof";
        }

        public Wolf(string name, int age, int weight, string size, int pacSize) : base(name, age, weight, size)
        {
            this.pacSize = pacSize;
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Size = size;
        }

        public override string Stats()
        {
            //string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Size of its pac:" + this.pacSize + " Name:" + this.Name, Age, Weight, Size, pacSize, name;
            string ret = base.Stats() + $"Pack Size: {pacSize}, ";
            return ret;
        }
    }
}
