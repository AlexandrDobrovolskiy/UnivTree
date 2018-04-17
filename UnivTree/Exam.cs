using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class Exam : SubjectBase  //тип: екзамен
    {
        public int Scores { get; set; }

        public Exam(string name, int scores) : base(name)
        {
            this.Description = "Exam";
            this.Scores = scores;
        }

        public override void Print()
        {
            base.Print();
            Console.Write($"{GetPropertyJson("Scores", Scores)}\n");
            PrintChildsJson();
            Console.Write($"\n{GetIndent()}" + "}");
        }

    }
}
