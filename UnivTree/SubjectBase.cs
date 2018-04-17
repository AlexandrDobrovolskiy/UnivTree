using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    abstract class SubjectBase : Node  //самостійно не використовується   
    {
        string SubjectName { get; set; }
        protected SubjectBase(string name)
        {
            this.SubjectName = name;
        }

        public override void Print()
        {
            Console.Write(GetIndent() + "{\n" +
                          $"{GetPropertyJson("NodeType", Description)} \n" +
                          $"{GetPropertyJson("Name", SubjectName)} \n" +
                          $"{GetPropertyJson("ChildCount", ChildCount)} \n");

        }

    }
}
