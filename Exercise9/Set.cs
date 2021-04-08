using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {

            // I would use the contains function for the list
            return elements.Contains(val);

            //for (int i = 0; i < elements.Count; i++)
            //{
            //    if (val == elements[i])
            //        return true;
            //    else
            //        return false;
            //}
            //return false;
        }

        public override string ToString()
        {

            // I would also like to sort the elements
            elements.Sort();

            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // we need to make sure there isn't a duplicate
                //this.addElement(rhs.elements[i]);
                if (!elements.Contains(rhs.elements[i]))
                    this.addElement(rhs.elements[i]);
            }
            return rhs;
        }

    }
}
