using System;
using System.Collections.Generic;
using System.Text;
    
namespace UnivTree
{
    abstract class Person : Node  //самостійно не використовується  
    {
        public string PersonName { get; set; }

        protected Person(string personName)
        {
            PersonName = personName;
        }

        public override void Print()
        {
            Console.Write(GetIndent() + "{\n" +
                          $"{GetPropertyJson("NodeType", Description)} \n" +
                          $"{GetPropertyJson("PersonName", PersonName)} \n" +
                          $"{GetPropertyJson("ChildCount", ChildCount)} \n");
        }

    }
}
