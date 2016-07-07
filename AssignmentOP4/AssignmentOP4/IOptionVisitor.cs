using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    interface IOptionVisitor<T,U>
    {
        U onSome(T Value);
        U onNone();
    }
}
