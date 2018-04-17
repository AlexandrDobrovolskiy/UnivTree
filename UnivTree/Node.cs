using System;
using System.Collections.Generic;
using System.Text;

namespace UnivTree
{
    abstract class Node 
    {
        protected string Description;
        protected List<Node> ChildNodes = new List<Node>();
        protected Node ParentNode;
        protected static int indent = 0;

        public int ChildCount { get; set; }

        public string NodeType => Description;
        public Node GetParent() => ParentNode;

        public string GetIndent()
        {
            string res = String.Empty;
            Node parent = this.GetParent();
            while (parent != null)
            {
                res += '\t';
                parent = parent.GetParent();
            }

            return res;
        }

        public string GetPropertyJson(string name, Object prop, bool isLast = false)
        {
            string propJSON = $"{this.GetIndent()}\"{name}\" : \"{prop}\"";
            propJSON += isLast ? String.Empty : ",";

            return propJSON;
        }

        public void PrintChildsJson()
        {
            Console.Write($"{GetIndent()}\"ChildNodes\" : ");
            if (ChildNodes.Count > 0)
            {

                Console.Write($"{ChildNodes[0].GetIndent()}\n{GetIndent()}[\n");
                for (int i = 0; i < ChildNodes.Count; i++)
                {
                    ChildNodes[i].Print();
                    if (i != ChildCount - 1)
                        Console.Write(",");
                    Console.Write("\n");
                }
                Console.Write($"{ChildNodes[0].GetIndent()}\n{GetIndent()}]\n");
            }
            else
            {
                Console.Write("[]\n");
            }
        }

        public Node AddChild(Node child)
        {
            child.ParentNode = this;
            ChildCount++;
            ChildNodes.Add(child);
            return this;
        }

        public void RemoveChild(int i) 
        {
            ChildNodes.RemoveAt(i);
        }

        public abstract void Print();
    }
}
