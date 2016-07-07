using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    public class Label : IElement
    {

        public Label(Color color, Point location, Point size, Action action, string text, SpriteFont font)
        {
            this.Color = color;
            this.Location = location;
            this.Size = size;
            this.Action = action;
            this.Text = text;
            this.Font = font;
        }

        public Color Color { get; }
        public Point Location { get; }
        public Point Size { get; }
        public Rectangle MakeButton { get { return new Rectangle(Location, Size); } }
        public Texture2D Texture { get; }
        public Action Action { get; }
        public SpriteFont Font { get; }
        public string Text { get; }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Font, "Title", new Vector2(100, 100), Color.Yellow);
        }

        public void Visit(IVisit visitor)
        {
            visitor.onLabel(this);
        }

        public void Update(float dt)
        {
            throw new NotImplementedException();
        }
    }
}
