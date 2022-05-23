namespace RP_Övning3._3._3_Arv
{
    internal class Horse : Animal, Iperson
    {
        public bool Isrideble { get; set; }
        public override string DoSound()
        {
            return "Neigh";
        }

        public Horse(string name, int age, int weight, string size, bool isrideble) : base(name, age, weight, size)
        {
            Isrideble = isrideble;

        }
        public override string Stats()
        {
            //string ret = "Age:"+this.Age+" Weight:"+this.Weight+" Size:"+this.Size+ " Is it rideble:" + this.isrideble + " Name:" + this.Name, Age, Weight, Size, isrideble, name;
            string ret = base.Stats() + $", Ridable: {Isrideble}.";
            return ret;
        }

        public string Talk()
        {
            return $"I am a Centaur!";
        }
    }
}
