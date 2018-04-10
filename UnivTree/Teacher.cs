using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Teacher : Person  //типи: асистент, доцент, професор, завідувач  
    {
        public Teacher(string name, string degree) : base(name)
        {

        }

        public string AcademicDegree { get; set; }
        public override void Print()
        {

        }

    }
}
