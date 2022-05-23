using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3
{
    internal class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.age = age;
            person.height = height;
            person.weight = weight;
            person.lName = lname;
            person.fName = fname;

            return person;
        }

        public void SetAge(Person pers, int age)
        {
            pers.age = age;
        }
        public void SetFName(Person pers, string fname)
        {
            pers.fName = fname;
        }

        public void SetLName(Person pers, string lname)
        {
            pers.lName = lname;
        }

        public void SetLHeight(Person pers, double height)
        {
            pers.height = height;
        }
        public void SetLWidth(Person pers, double width)
        {
            pers.weight = width;
        }
    }
}
