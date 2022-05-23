using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3
{
    internal class Person
    {
        public string fName;
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Persons first name must be longer than 1 character.");
                }
                else if (value.Length > 10)
                {
                    throw new ArgumentException("Persons first name must be shorter than 10 character.");
                }
                fName = value;
            }
        }
        public string lName;
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Persons last name must be longer than 2 character.");
                }else if(value.Length > 15)
                {
                    throw new ArgumentException("Persons last name must be shorter than 16 character.");
                }
                lName = value;
            }
        }
        public int age;
        public int Age {
            get
            {
                return age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be greater than 0.");
                }
                age = value;
            }

        }
        public double height { get; set; }
        public double weight { get; set; }
    }
}
