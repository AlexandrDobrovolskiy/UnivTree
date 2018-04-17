using System;

namespace UnivTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Department FIT = new Department("FIT", "Faculty");
            Department KNU = new Department("KNU", "University");
            Department kafedra = new Department("kafedra", "kafedra");
            Student leha = new Student("leha", 1);
            Student sanya = new Student("sanya", 1);
            Student sasha = new Student("sasha", 1);
            Teacher popereshnyak = new Teacher("postav' 3", "pozhalusta");
            Exam OOP = new Exam("OOP", 100);

            KNU.AddChild(FIT.AddChild(kafedra.AddChild(leha.AddChild(OOP)).AddChild(sasha).AddChild(sanya).AddChild(popereshnyak)));

            UnivTree KNUTree = new UnivTree(KNU);

            KNUTree.PrintFormatted();

            Console.ReadKey();
        }
    }
}
