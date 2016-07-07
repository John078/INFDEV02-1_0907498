using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Button
{
    internal enum ButtonState
    {
        //The button is in its default state
        None,
        //The buton is currently being hovered
        Hovered,
        //The button has been clicked
        Clicked
    }


    internal class Button
    {
        // represents the texture of a button
        internal Sprite Sprite;

        // represents the default color for sprites
        internal Color DefeaultSpriteColor;

        // represents the color when we hover over button 
        internal Color HoverSpriteColor;

        // represents the text of the button.
        internal Text Text;

        //represents color of text in default state
        internal Color DefaultTextColor;

        //represents the text when hovered
        internal Color HoverTextColor;

        private ButtonState m_previousButtonState;
        private ButtonState m_currentButtonState;

        private Action m_onClicked;
        private Action m_onHovered;

        //What happens if we click the button
        internal event Action OnClicked
        {
            add { m_onClicked += value; }
            remove { m_onClicked -= value; }
        }
        //What happens if we hover the button
        internal event Action OnHovered
        {
            add { m_onHovered += value; }
            remove { m_onHovered -= value; }
        }
        //true if position is constained within the bounds of our sprite
        private bool ContainsPosition(Vector2 position)
        {
            return Sprite.Bounds.Contains(position);
        }


        // Method that check if our mouse input is over our button position.
        // if it is we change the color and the text.
        // when click we see the state to clicked. 
        // finally check if any new events should be fired.
        internal void HandleInput(MouseState mouseState)
        {
            Sprite.Color = DefeaultSpriteColor;
            Text.Color = DefaultTextColor;

            if (ContainsPosition(new Vector2(mouseState.X, mouseState.Y)))
            {
                Sprite.Color = HoverSpriteColor;
                Text.Color = HoverTextColor;

                m_currentButtonState = ButtonState.Hovered;

                if(mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    m_currentButtonState = ButtonState.Clicked;
                }
            }
            else
            {
                m_currentButtonState = ButtonState.None;
            }

            FireEvents();
            m_previousButtonState = m_currentButtonState;
        }

        //Method that checks if we have changed button state recently and fires the required methods.
        private void FireEvents()
        {
            if(m_currentButtonState != m_previousButtonState)
                switch (m_currentButtonState)
                {
                    case ButtonState.Hovered;
                        if(m_onHovered != null)
                        {
                            m_onHovered();
                        }
                        break;

                    case ButtonState.Clicked;
                        if (m_onClicked != null)
                        {
                            m_onClicked();
                        }
                        break;
                }
        }
        // Method that draws our Sprite and text onto the screen
        internal void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch);
            Text.Draw(spriteBatch);
        }

    }
}
