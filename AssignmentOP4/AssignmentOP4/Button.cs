using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    public class Button : IElement
    {

        public Button(Color color, Point location, Point size, Texture2D texture, Action action)
        {
            this.Color = color;
            this.Location = location;
            this.Size = size;
            this.Texture = texture;
            this.Action = action;
        }

        public Color Color { get; }
        public Point Location { get; }
        public Point Size { get; }
        public Rectangle MakeButton { get { return new Rectangle(Location, Size); } }
        public Texture2D Texture { get; }
        public Action Action { get; }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, MakeButton, Color.Red);
        }

        public void Update(float dt)
        {
            MouseState input = Mouse.GetState();
            Point mousePosition = new Point(input.X, input.Y);
            if (MakeButton.Contains(mousePosition) && input.LeftButton == ButtonState.Pressed)
            {
                Console.WriteLine("clicked");
                // change color of button or text?
            }
        }

        void IElement.Visit(IVisit visitor)
        {
            visitor.onButton(this);
        }
    }
}
