using System;

namespace CustomIndexerSample
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime Birthday { get; }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
