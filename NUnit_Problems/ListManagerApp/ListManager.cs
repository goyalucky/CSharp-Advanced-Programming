using System;
using System.Collections.Generic;

namespace ListManagerApp
{
    public class ListManager
    {
        // Adds an element to a list.
        public void Add(List<int> lst, int val)
        {
            if (lst == null)
                throw new ArgumentNullException(nameof(lst));

            lst.Add(val);
        }

        // Remove an element from a list
        public bool Remove(List<int> lst, int val)
        {
            if (lst == null)
                throw new ArgumentNullException(nameof(lst));

            return lst.Remove(val);
        }

        // Returns the size of the list.
        public int Size(List<int> lst)
        {
            if (lst == null)
                throw new ArgumentNullException(nameof(lst));

            return lst.Count;
        }
    }
}