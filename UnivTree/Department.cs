using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Department : Node  //може мати тип університет, інститут, факультет, група або кафедра
    {
        public Department(string departmentName)
        {

        }

        public string DepartmentName { get; set; }

        public override void Print()
        {

        }

    }
}
