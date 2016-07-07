using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using OpdrachtButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpdrachtButton
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


    class Button : number, IGuiEl
    {

        void number.Visit(IGuiElVisitor visitor)
        {
            visitor.m_onClicked(this);
        }


        // represents the texture of a button
        internal Sprite Sprite;

        // represents the default color for sprites
        internal Color DefaultSpriteColor;

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
        private SpriteBatch spriteBatch;

        event Action IGuiEl.OnClicked
        {
            add
            { m_onClicked += value; }
            remove
            { m_onClicked -= value; }
        }

        event Action IGuiEl.OnHovered
        {
            add
            { m_onHovered += value; }
            remove
            { m_onHovered -= value; }
        }

        public void Draw()
        {
            Sprite.Draw(spriteBatch);
            Text.Draw(spriteBatch);
        }
    }
}
