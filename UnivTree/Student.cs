using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Student : Person //типи: студент  
    {
        public Student(string personName, int course) : base(personName)
        {

        }

        float AvgScore { get { return 0; } }
        int Course { get; set; }
        public override void Print()
        {

        }

    }
}
