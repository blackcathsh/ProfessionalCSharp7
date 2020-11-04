using System;
using System.Diagnostics.CodeAnalysis;

namespace SortingSample
{
    public class Person : IComparable<Person>
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo([AllowNull] Person other)
        {
            if (other == null)
            {
                return 1;
            }

            int result = string.Compare(this.LastName, other.LastName);

            if (result == 0)
            {
                result = string.Compare(this.FirstName, other.FirstName);
            }

            return result;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
