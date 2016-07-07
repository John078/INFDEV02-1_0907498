using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    public class ElementsList<T> : ITraditionalIterator<T>
    {
        private List<T> elementsList;
        private int index = -1;
        public ElementsList(List<T> list)
        {
            this.elementsList = list;
        }

        public T Current
        {
            get
            {
                if (index< 0)
                    throw new Exception("Do move next first");
                return elementsList[index];
            }
        }

        public bool MoveNext()
        {
            if (index + 1 < elementsList.Count)
                index = 0;
            else
                index++;
            return true;
        }
    }   
}
