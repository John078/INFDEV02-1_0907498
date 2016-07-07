using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpdrachtButton
{
    class GuiElCliclVisitor : IGuiElVisitor
    {
        public void m_onClicked(Button OnClicked)
        {
            Console.WriteLine("Ik heb op button geklikt");
        }
        public void m_onClicked(Button2 OnClicked)
        {
            Console.WriteLine("Ik heb button2 geklikt");
        }

    class GuiElHoverVisitor : IGuiEl2Visitor
        {
            public void m_onHovered(Button onHovered)
            {
                Console.WriteLine("Ik heb op button gehovered");
            }
            public void m_onHovered(Button2 onHovered)
            {
                Console.WriteLine("Ik heb op button gehovered");
            }
        }

    
    }
}
