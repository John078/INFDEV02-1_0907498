using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    public interface ITraditionalIterator<T>
    {
        bool MoveNext();
        T Current { get; }
    }
}
