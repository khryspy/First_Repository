

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Knowledge_ns;

namespace Student_ns
{
    class Student
    {
        public Knowledge knowledge { get; set; } 
        public string name { get; set; } 

        public Student(string name) 
        {
            this.name = name;
        }

        public void setKnowledge(Knowledge knowledge) 
        {
            this.knowledge = knowledge;
        }
    }
}

