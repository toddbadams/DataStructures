using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tba.DataStructures
{
    public class Person
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class HashExample
    {
        public ISet<Person> PersonHash { get; private set; }

        public HashExample(int numberPersons)
        {
            PersonHash = new HashSet<Person>();

            for (var i = 0; i < numberPersons; i++)
            {
                PersonHash.Add(new Person
                    {
                        Id = i,
                        First = Faker.Name.First(),
                        Last = Faker.Name.Last()
                    });

            }
        }


    }
}
