using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Robert", "", "Manole", 123456, "Iasi", "0744444444", "robertmri95@gmail.com",
                University.Alexandru_Ioan_Cuza, Faculty.FEAA, Speciality.Finante_Banci, "Course");

            var s2 = s.Clone();

            s.EMail = "robertmri99@gmail.com";

            var p = new Person("Manole");
            Console.WriteLine(p.ToString());
        }

        public enum University
        {
            Alexandru_Ioan_Cuza,
            Gheorge_Asachi,
            UMF
        }

        public enum Faculty 
        {
            FEAA,
            Constructions,
            Mechanics,
            Medicine,
            Stomatologie
        }

        public enum Speciality
        {
            Finante_Banciiii,
            Informatica_Contabilitatii,
            Finante_Banci,
            Mecanica,
            Inginerie,
            Medicina_Dentara
            

        }


    }
}

