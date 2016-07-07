using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    class Some<T> : IOption<T>
    {
        public T value;
        public Some(T value)
        {
            this.value = value;
        }

        public U Visit<U>(IOptionVisitor<T,U> visitor)
        {
            return visitor.onSome(this.value);
        }
    }

    class None<T> : IOption<T>
    {
        public U Visit<U>(IOptionVisitor<T, U> visitor)
        {
            return visitor.onNone();
        }
    }
    
}