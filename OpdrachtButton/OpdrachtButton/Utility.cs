using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpdrachtButton
{
    internal class Utility
    {
        internal static Vector2 CenterTextHorizontal(Rectangle bounds, SpriteFont spritefont, string text)
        {
            var textSize = spritefont.MeasureString(text);

            return new Vector2
            {
                X = bounds.X + ((bounds.Width / 2.0f) - (textSize.X / 2.0f)),
                Y = bounds.Y
            };
        }
        internal static Vector2 CenterTextVertical(Rectangle bounds, SpriteFont spritefont, string text)
        {
            var textSize = spritefont.MeasureString(text);

            return new Vector2
            {
                X = bounds.X,
                Y = bounds.Y + ((bounds.Height / 2.0f) - (textSize.Y / 2.0f))
            };
        }
        internal static Vector2 CenterText(Rectangle bounds, SpriteFont spritefont, string text)
        {
            var textSize = spritefont.MeasureString(text);

            return new Vector2
            {
                X = bounds.X + ((bounds.Width / 2.0f) - (textSize.X / 2.0f)),
                Y = bounds.Y + ((bounds.Height / 2.0f) - (textSize.Y / 2.0f))
            };
        }


    
        internal static Vector2 CenterSpriteHorizontal(Rectangle bounds, Texture2D texture)
        {
            return new Vector2
            {
                X = bounds.X + ((bounds.Width / 2.0f) - (texture.Width / 2.0f)),
                Y = bounds.Y
            };
        }
        internal static Vector2 CenterSpriteVertical(Rectangle bounds, Texture2D texture)
        {
            return new Vector2
            {
                X = bounds.X,
                Y = bounds.Y + ((bounds.Height / 2.0f) - (texture.Height / 2.0f))
            };
        }
        internal static Vector2 CenterSprite(Rectangle bounds, Texture2D texture)
        {
            return new Vector2
            {
                X = bounds.X + ((bounds.Width / 2.0f) - (texture.Width / 2.0f)),
                Y = bounds.Y + ((bounds.Height / 2.0f) - (texture.Height / 2.0f))
            };
        }
    }
}
