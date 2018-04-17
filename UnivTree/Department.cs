using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Department : Node  //може мати тип університет, інститут, факультет, група або кафедра
    {
        private string _departmentType;
        public string DepartmentName { get; set; }

        public Department(string departmentName, string departmentType)
        {
            this.Description = "Department";
            this.DepartmentName = departmentName;
            this._departmentType = departmentType;
        }

        public override void Print()
        {
            Console.Write(GetIndent() + "{\n" +
                          $"{GetPropertyJson("NodeType", Description)} \n" +
                          $"{GetPropertyJson("DepartmentType", _departmentType)} \n" +
                          $"{GetPropertyJson("DepartmentName", DepartmentName)} \n" +
                          $"{GetPropertyJson("ChildCount", ChildCount)} \n");
            PrintChildsJson();
            Console.Write(GetIndent() + "}");
        }

    }
}
