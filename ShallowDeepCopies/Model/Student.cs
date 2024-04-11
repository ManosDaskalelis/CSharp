using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopies.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public Address? Address{ get; set; }

        public Student GetCopyRef()
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
            student.Address = new()
            {
                Street = Address?.Street,
                Number = Address?.Number,
                ZipCode = Address?.ZipCode,
            };
            return student;
        }

        public Student(Student? student)
        {
            Id = student!.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            Address = new()
            {
                Street = student.Address?.Street,
                Number = student.Address?.Number,
                ZipCode = student.Address?.ZipCode,
            };
        }

    }
}
