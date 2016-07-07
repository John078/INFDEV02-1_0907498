using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    interface IIterator<T>
    {
        IOption<T> GetNext();
    }

}
