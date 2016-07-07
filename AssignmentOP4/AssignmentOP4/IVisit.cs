using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    public interface IVisit
    {
        void onButton(Button button);
        void onLabel(Label label);
    }
}
