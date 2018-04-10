using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    abstract class Node //вершина
    {
        protected List<Node> childNodes;
        protected Node parentNode;

        public Node GetParent() //батьківська вершина
        {
            return null;
        }

        public Node AddChild(Node child)  // додає сина
        {
            return null;
        }

        public void RemoveChild(int i)  // вилучає сина та всіх його синів
        {

        }

        public int ChildCount { get { return 0; } }  // кількість синів

        public string NodeType { get { return null; } } //тип вузла

        public abstract void Print();  // виводить вузел та піддерево на консоль в JSON форматі 
    }
}
