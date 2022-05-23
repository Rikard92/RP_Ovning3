using RP_Övning3._3._3_Arv;
using System;

namespace RP_Övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person1 = new Person();
                person1.age = 15;
                person1.height = 160;
                person1.weight = 50;
                person1.lName = "Jonas";
                person1.fName = "Oster";
            }
            catch
            {

            }
            

            PersonHandler PH = new PersonHandler();

            Person person2 = PH.CreatePerson(18, "Elinor", "Johansen", 160, 65);

            List<UserError> UEL = new List<UserError>();

            UEL.Add(new TextInputError());
            UEL.Add(new NumericInputError());
            UEL.Add(new DataInputError());
            UEL.Add(new ListInputError());
            UEL.Add(new BoolInputError());

            foreach (UserError error in UEL)
            {
                Console.WriteLine(error.UEMessage()); 
            }
            Console.WriteLine();
            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Wolfman("Herald", 25, 40, "Large", 1));
            Animals.Add(new Dog("Oskar",5,5,"Small", 3));
            Animals.Add(new Worm("Jim", 2, 1, "Tiny", false));
            Animals.Add(new Wolf("Gerard", 6, 6, "Small", 3));
            Animals.Add(new Hedgehog("Sonic", 6, 2, "Tiny", 3));
            Animals.Add(new Bird("Woody", 20, 3, "Tiny", 4));
            Animals.Add(new Pelican("Mingo", 9, 3, "Medium", 4, 5));
            Animals.Add(new Swan("Hasel", 8, 3, "Medium", 4, 7));
            Animals.Add(new Pelican("Pel", 14, 3, "Medium", 4, 4));
            Animals.Add(new Horse("Silver", 10, 70, "Large", true));

            

            foreach (Animal A in Animals)
            {
                //3.4.13 Listen anropar functionen och skriver ut resultatet. 
                Iperson I = A as Iperson;
                if (I!=null)
                {
                    Console.WriteLine("Person: {0} say {1}.", I.Stats(), I.Talk());
                }
                else
                {
                    Console.WriteLine("Animal: {0} goes {1}.", A.Stats(), A.DoSound());
                }
                
            }

            //3.4.9 Det går inte att lägga till En häst i en hundlista eftersom Listan har besignerat att den ska bara ta emot object som är av type Hund
            //3.4.10 Listen måste designera att den sak ta emot Animals, så som listan "Animals" 

            string s = Console.ReadLine();
        }
    }
}