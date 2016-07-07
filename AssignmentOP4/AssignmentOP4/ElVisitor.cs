using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    class ElVisitor : IVisit
    {
        public void onButton(Button button)
        {
            MouseState input = Mouse.GetState();
            Point mousePosition = new Point(input.X, input.Y);
            if (button.MakeButton.Contains(mousePosition) && input.LeftButton == ButtonState.Pressed)
            {
                Console.WriteLine("----");
            }
        }

        public void onLabel(Label label)
        {
            throw new NotImplementedException();
        }
    }
}
