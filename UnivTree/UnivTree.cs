using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    class UnivTree
    {
        public Node univ;

        public UnivTree(Node main)
        {
            this.univ = main;
        }

        public void PrintFormatted()  // виводить дерево на екран в JSON форматі
        {
            univ.Print();
        }

    }
}
