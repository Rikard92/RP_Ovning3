namespace RP_Övning3._3._3_Arv
{
    internal class Wolfman : Wolf, Iperson
    {
        public bool IsCursed { get; set; }
        public Wolfman(string name, int age, int weight, string size, int pacSize, bool isCursed) : base(name, age, weight, size, pacSize)
        {
            IsCursed = isCursed;
        }

        public string Talk()
        {
            return "Hello world, I'm Wolfman!";
        }

        string Stats()
        {
            //string ret = "Age:" + this.Age + " Weight:" + this.Weight + " Size:" + this.Size + " Name:" + this.Name, Age, Weight, Size, name;
            string ret = base.Stats() + $"Is Cursed: {IsCursed}.";
            return ret;
        }
    }
}
