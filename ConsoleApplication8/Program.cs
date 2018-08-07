


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Student_ns;
using University_ns;
using Internship_ns;

namespace ConsoleApplication1 
{
    class Program 
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I"); 


            university.addStudent(new Student("Andrew Kostenko")); 
            university.addStudent(new Student("Julia Veselkina"));
            university.addStudent(new Student("Maria Perechrest"));

            foreach (Student item in university.students)
            {
                university.setStudent(item);

                Console.WriteLine(item.knowledge.level);//Виводимо значення

            }


            Internship internship = new Internship("Interlink"); 
            foreach (Student student in university.students)//Заповнюємо список студентів на інтернатуру за рівнем знань
            {
                internship.setStudent(student);
            }


            Console.WriteLine("List of internship students: "); 
            Console.WriteLine(internship.getStudents()); 


            Console.ReadLine();//Дякую за можливість та розуміння!
        }
    }
}
