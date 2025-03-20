using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Classes
{
    class Tree
    {
        public List<Tree> treeList { get; set; }
        public string value { get; set; }
        public Tree(string value)
        {
            this.treeList = new List<Tree>();
            this.value = value;
        }

        public void AddStruct(Tree obj)
        {
            treeList.Add(obj);
        }

        public void DisplayValues()
        {
            Console.WriteLine(value);
            foreach (Tree num in treeList)
            {
                num.DisplayValues();
            }
        }
    }
}

