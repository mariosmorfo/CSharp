using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingApp.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Address? Address { get; set; }

        public Student() { }

        public Student(int id, string? firstName, string? lastName, Address? address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public Student GetRef()
        {
            return this;
        }

        public Student GetShallowCopy()
        {
            return (Student)MemberwiseClone();
        }

        public Student GetDeepCopy()
        {
            Student student = (Student)MemberwiseClone();
            student.Address = new Address()
            {
                StreetName = Address!.StreetName,
                StreetNo = Address!.StreetNo,
                ZipCode = Address!.ZipCode
            };
            return student;
        }
    }
}
