using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    internal sealed class ImmuTeacher
    {
        public int Id { get; init; }
        public string? FirstName { get; init; }
        public string? Lastname { get; init; }

        public ImmuTeacher() { }

        public ImmuTeacher(int id, string? firstName, string? lastname)
        {
            Id = id;
            FirstName = firstName;
            Lastname = lastname;
        }
    }
}
