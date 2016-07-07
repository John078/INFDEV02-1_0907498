using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpdrachtButton
{
    class Text
    {
        internal string Message { get; set; }
        internal SpriteFont SpriteFont { get; set; }
        internal Vector2 Position { get; set; }
        internal Color Color { get; set; }


        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(SpriteFont, Message, Position, Color);
        }

        public void CenterHorizontal(Rectangle bounds)
        {
            Position = Utility.CenterTextHorizontal(bounds, SpriteFont, Message);
        }
        public void CenterVertical(Rectangle bounds)
        {
            Position = Utility.CenterTextVertical(bounds, SpriteFont, Message);
        }
        public void Center(Rectangle bounds)
        {
            Position = Utility.CenterText(bounds, SpriteFont, Message);
        }
    }


}
