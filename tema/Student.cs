using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    partial class Program
    {
        public class Student : IStudent, ICloneable, IComparable
        {
            public Student(string fn, string mn, string ln, int ssn, string address,
                string mobilePhone, string email, University university, Faculty factulty, Speciality speciality, string course)
            {
                this.FirstName = fn;
                this.MiddleName = mn;
                this.LastName = ln;
                this.SSN = ssn;
                this.Address = address;
                this.MobilePhone = mobilePhone;
                this.EMail = email;
                this.University = university;
                this.Faculty = factulty;
                this.Speciality = speciality;
                this.Course = course;

            }
            public string FirstName { get; }
            public string MiddleName { get; }
            public string LastName { get; }
            public int SSN { get; }
            public string Address { get; }
            public string MobilePhone { get; }
            public string EMail { get; set; }
            public string Course { get; }
            public Speciality Speciality { get; }
            public University University { get; }
            public Faculty Faculty { get; }

            public override string ToString()
            {

                return $"Student: [{this.FirstName}]  [{this.LastName}]";
            }
            public override bool Equals(object obj)
            {
                var s = (Student)obj;
                if (this.FirstName == s.FirstName && this.LastName == s.LastName)
                {
                    return true;
                }

                return false;
            }

            public static bool operator ==(Student s1, Student s2)
            {
                if (s1.Equals(s2))
                {
                    return true;
                }

                return false;
            }
            public static bool operator !=(Student s1, Student s2)
            {
                if (s1.Equals(s2))
                {
                    return false;
                }

                return true;
            }

            public override int GetHashCode()
            {
                return this.SSN;
            }

            public object Clone()
            {
                var s = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.EMail,
                    this.University, this.Faculty, this.Speciality, this.Course);

                return s;
            }

            public int CompareTo(object obj)
            {
                var s = (Student)obj;

                string sFull = s.LastName + s.MiddleName + s.FirstName + s.SSN;
                string thisFull = this.LastName + this.MiddleName + this.FirstName + this.SSN;

                return thisFull.CompareTo(sFull);
            }
        }


    }

}
