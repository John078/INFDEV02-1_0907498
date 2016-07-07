using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpdrachtButton
{
    interface IGuiElVisitor
    {
        void m_onClicked(Button button);
        void m_onClicked(Button2 button2);
    }

    interface IGuiEl2Visitor
    { 
        void m_onHovered(Button button);
        void m_onHovered(Button2 button2);
    }
}
