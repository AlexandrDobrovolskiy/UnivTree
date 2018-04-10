using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    abstract class Person : Node  //самостійно не використовується  
    {
        public Person(string personName)
        {

        }

        public string PersonName { get; set; }
        public override void Print()
        {

        }

    }
}
