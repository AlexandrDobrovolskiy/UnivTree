using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Exam : SubjectBase  //тип: екзамен
    {
        public Exam(string name, int scores) : base(name)
        {

        }

        public int Scores { get; set; }
        public override void Print()
        {

        }

    }
}
