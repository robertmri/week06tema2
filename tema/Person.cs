using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return $"This person's name is: {this.Name} but age is unknown";
            }
            return $"This person's name is {this.Name} and is {this.Age} years old";
        }
    }

}
