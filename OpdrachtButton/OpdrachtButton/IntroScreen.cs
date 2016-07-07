using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OpdrachtButton
{
    class IntroScreen : IGameScreen
    {
        private readonly IGameScreenManager m_screenManager;

        private readonly List<Sprite> m_spriteList = new List<Sprite>();
        private readonly List<IGuiEl> m_buttons = new List<IGuiEl>();
     

        private Text m_text;
        private bool m_exitGame;
        private bool m_continueGame;

        public bool IsPaused { get; private set; }

        private const int WindowWidth = 800;
        private const int WindowHeight = 600;

        public IntroScreen(IGameScreenManager screenManager)
        {
            m_screenManager = screenManager;
        }

        public void Init(ContentManager ContentManager, Rectangle screenBounds)
        {
            string text = "Klik op de button om verder te gaan";
            Vector2 position = new Vector2(100, 100);

            SpriteFont spritefont = ContentManager.Load<SpriteFont>("Title");
            Color colour = Color.Yellow;

            m_text = new Text();
            m_text.SpriteFont = spritefont;
            m_text.Color = colour;
            m_text.Position = position;
            m_text.Message = text;
            m_text.CenterHorizontal(new Rectangle(0, 100, screenBounds.Width, 0));
            
            //var spriteobj = new sprite
            //{
            //    texture = contentmanager.load<texture2d>(""),
            //    position = vector2.zero
            //};
            //m_spritelist.add(spriteobj);

            InitialiseContinueButton(ContentManager, screenBounds);
            InitialiseExitButton(ContentManager, screenBounds);
        }
        private void InitialiseContinueButton(ContentManager contentManager, Rectangle screenBounds)
        {
            var buttonSprite = new Sprite
            {
                Texture = contentManager.Load<Texture2D>("button2")
            };

            buttonSprite.CenterHorizontal(new Rectangle(200, 200, screenBounds.Width, 0));

            var buttonText = new Text
            {
                Message = "Press to Stay",
                Color = Color.Black,
                SpriteFont = contentManager.Load<SpriteFont>("Title")
            };

            buttonText.Center(buttonSprite.Bounds);

            IGuiEl buttonstay = new Button
            {
                Sprite = buttonSprite,
                DefaultSpriteColor = Color.White,
                HoverSpriteColor = Color.Black,
                Text = buttonText,
                DefaultTextColor = Color.Black,
                HoverTextColor = Color.White
            };
            buttonstay.OnClicked += ChangeBetweenScreens;

            m_buttons.Add(buttonstay);
        }

        private void InitialiseExitButton(ContentManager contentManager, Rectangle screenBounds)
        {
            var buttonSprite = new Sprite
            {
                Texture = contentManager.Load<Texture2D>("button")
            };

            buttonSprite.CenterHorizontal(new Rectangle(-200, 200, screenBounds.Width, 0));

            var buttonText = new Text
            {
                Message = "Press to Exit",
                Color = Color.Black,
                SpriteFont = contentManager.Load<SpriteFont>("Title")
            };

            buttonText.Center(buttonSprite.Bounds);

            IGuiEl buttonleave = new Button
            {
                //Sprite = buttonSprite,
                //DefaultSpriteColor = Color.White,
                //HoverSpriteColor = Color.Black,
                //Text = buttonText,
                //DefaultTextColor = Color.Black,
                //HoverTextColor = Color.White
            };
            

            m_buttons.Add(buttonleave);
        }
        public void ButtonExitClicked()
        {
            m_exitGame = true;
        }
        public void ChangeBetweenScreens()
        {
            if (m_exitGame)
            {
                m_screenManager.Exit();
            }
        }
        public void Pause()
        {
            IsPaused = true;
        }

        public void Resume()
        {
            IsPaused = false;
        }

        public void Update(GameTime gameTime)
        {

        }

        //public void Draw(GameTime gameTime, SpriteBatch spritebatch)
        //{
        //    spritebatch.DrawString(m_text.SpriteFont, m_text.Message, m_text.Position, m_text.Color);

        //    foreach (var sprite in m_spriteList)
        //    {
        //        sprite.Draw(spritebatch);
        //    }
        //    foreach (var button in m_buttons)
        //    {
        //        button.Draw(spritebatch);
        //    }

        //}
        //public void HandleInput(GameTime gameTime)
        //{
        //    var mouseState = Mouse.GetState();
        //    foreach (var button in m_buttons)
        //    {
        //        button.HandleInput(mouseState);
        //    }
        //}

        public void Dispose()
        {

        }

    }
}
