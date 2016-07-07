using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpdrachtButton
{
    interface IGuiEl
    {
        event Action OnClicked;

        event Action OnHovered;

        //bool ContainsPosition();

        //void HandleInput();

        //void FireEvents();

        void Draw();
    }
}
