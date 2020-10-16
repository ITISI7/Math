using System;
using System.Collections.Generic;

namespace hierarchies
{
    class SceneObject
    {
        protected SceneObject parent = null;
        protected List<SceneObject> children = new List<SceneObject>();

        public SceneObject Parent 
        { 
            get { return parent; }
        }

        public SceneObject()
        {
        }

        public int GetChildCount() { return children.Count; }
        public SceneObject GetChild(int index) { return children[index]; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
