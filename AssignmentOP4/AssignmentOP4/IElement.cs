using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    public interface IElement
    {
        Point Location { get; }
        Point Size { get; }
        Color Color { get; }
        Rectangle MakeButton { get; }
        Action Action { get; }

        void Draw(SpriteBatch spritebatch);
        void Update(float dt);
        void Visit(IVisit visitor);
    }
}
