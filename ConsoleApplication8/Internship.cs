
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Student_ns;

namespace Internship_ns
{
    class Internship
    {
        public string name; 

        private List<Student> students; 

        public Internship(string name) 
        {
            this.name = name;
            students = new List<Student>(); 
        }

        public void setStudent(Student student)
        {
            if (student.knowledge.level >= 4)//Перевіряємо чи рівень знань вище середнього
            {
                students.Add(student);
            }
        }

        public string getStudents()
        {
            string nameStudents = "";
            for (int i = 0; i < students.Count; i++)
            {
                nameStudents += students[i].name + "\n"; 
            }
            return nameStudents;
        }

    }
}

