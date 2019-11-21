using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    interface IStudent
    {
        string FirstName { get; }
        string MiddleName { get; }
        string LastName { get; }
        int SSN { get; }
        string Address { get; }
        string MobilePhone { get; }
        string EMail { get; }
        string Course { get; }
        Program.Speciality Speciality { get; }
        Program.University University { get; }
        Program.Faculty Faculty { get; }

    }
}
