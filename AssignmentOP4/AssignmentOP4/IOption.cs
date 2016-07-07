using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    interface IOption<T>
    {
        U Visit<U>(IOptionVisitor<T, U> visitor);
    }
}
