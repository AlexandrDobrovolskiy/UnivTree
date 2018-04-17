using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Teacher : Person  //типи: асистент, доцент, професор, завідувач  
    {
        public string AcademicDegree { get; set; }

        public Teacher(string name, string degree) : base(name)
        {
            Description = "Teacher";
            this.AcademicDegree = degree;
        }
   
        public override void Print()
        {
            base.Print();
            Console.Write($"{GetPropertyJson("Degree", AcademicDegree)}\n");
            PrintChildsJson();
            Console.Write($"{GetIndent()}" + "}");
        }

    }
}
