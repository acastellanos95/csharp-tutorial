using System;

namespace Classes
{
    public class Person
    {
        private string firstName, lastName;
        private byte age;
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public byte getAge()
        {
            return age;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void setAge(byte age)
        {
            this.age = age;
        }
        public Person(string firstName, string lastName, byte age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}