using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OpdrachtButton
{

    public class Game1 : Game
    {
        private SpriteBatch m_spriteBatch;

        private IGameScreenManager m_screenManager;
        private Rectangle m_screenBounds = new Rectangle(0, 0, 1000, 600);


        public Game1()
        {
            var graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = m_screenBounds.Width,
                PreferredBackBufferHeight = m_screenBounds.Height
            };
            graphics.ApplyChanges();

        Content.RootDirectory = "Content";

            IsMouseVisible = true;
        }


        protected override void LoadContent()
        {
        // Create a new SpriteBatch, which can be used to draw textures.
            m_spriteBatch = new SpriteBatch(GraphicsDevice);

            m_screenManager = new GameScreenManager(m_spriteBatch, Content, m_screenBounds);
            m_screenManager.OnGameExit += Exit;

            m_screenManager.ChangeScreen(new IntroScreen(m_screenManager));
        }


        protected override void UnloadContent()
        {
            if(m_screenManager != null)
            {
                m_screenManager.Dispose();

                m_screenManager = null;
            }
        }

        protected override void Update(GameTime gameTime)
        {

            m_screenManager.ChangeBetweenScreens();

            m_screenManager.Update(gameTime);
            m_screenManager.HandleInput(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            m_screenManager.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}
