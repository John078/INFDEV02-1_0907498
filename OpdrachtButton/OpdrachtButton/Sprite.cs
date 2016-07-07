using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpdrachtButton
{
    class Sprite
    {

        internal Texture2D Texture;
        internal Vector2 Position;
        internal Color Color = Color.White;

        internal Rectangle Bounds
        {
            get
            {
                return new Rectangle
                {
                    X = (int)Position.X,
                    Y = (int)Position.Y,
                    Width = Texture.Width,
                    Height = Texture.Height
                };
            }
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color);
        }

        internal void CenterHorizontal(Rectangle bounds)
        {
            Position = Utility.CenterSpriteHorizontal(bounds, Texture);
        }

        internal void CenterVertival(Rectangle bounds)
        {
            Position = Utility.CenterSpriteVertical(bounds, Texture);
        }

        internal void Center(Rectangle bounds)
        {
            Position = Utility.CenterSprite(bounds, Texture);
        }

        internal void Draw(object spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
