
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Student_ns;
using Knowledge_ns;


namespace University_ns
{
    class University
    {
        private string name; 
        public List<Student> students { get; set; }

        public University(string name) 
        {
            this.name = name;
            students = new List<Student>(); 
        }

        public void setStudent(Student student) 
        {
            Random rand = new Random();
            student.setKnowledge(new Knowledge(rand.Next(1,5)));//Бали вибрала від 1 до 5
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }
    }
}
