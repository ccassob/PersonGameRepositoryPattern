using PersonGame.Domain.SharedKernel;
using System;

namespace PersonGame.Domain
{
    public class Person : BaseEntity<int>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("You have to send a name");

            if (age < 1)
                throw new ArgumentNullException("You have to send a gameId");

            Name = name;
            Age = age;
        }
    }
}