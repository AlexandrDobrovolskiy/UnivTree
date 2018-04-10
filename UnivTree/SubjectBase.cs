using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    abstract class SubjectBase : Node  //самостійно не використовується   
    {
        public SubjectBase(string name)
        {

        }

        string SubjectName { get; set; }
        public override void Print()
        {

        }

    }
}
