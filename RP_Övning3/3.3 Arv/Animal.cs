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
            Name = name;
            Age = age;
            Weight = weight;
            Size = size;
        }
        public virtual string Stats()
        {
            //string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Name:" + this.Name , Age, Weight, Size, name;
            string ret = $"Age: {Age}, Weight: {Weight}, Size: {Size}, Name: {Name}, ";
            return ret;
        }

        public abstract string DoSound();
    }
}
