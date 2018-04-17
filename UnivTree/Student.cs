using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Student : Person //типи: студент  
    {
        private float AvgScore { get; set;}
        private int Course { get; set; }

        public Student(string personName, int course) : base(personName)
        {
            this.Description = "Student";
            this.Course = course;
        }

        public override void Print()
        {
            base.Print();
            Console.Write($"{GetPropertyJson("Course",Course)}\n");
            PrintChildsJson();
            Console.Write($"\n{GetIndent()}" +"}");
        }

    }
}
