using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace OpdrachtButton
{
    interface IGameScreenManager : IDisposable
    {
        void ChangeScreen(IGameScreen screen);
        void PushScreen(IGameScreen screen);
        void PopScreen();

        void Update(GameTime gameTime);

        void Draw(GameTime gameTime);

        void HandleInput(GameTime gameTime);

        void ChangeBetweenScreens();

        void Exit();

        event Action OnGameExit;
    }

    interface IGameScreen : IDisposable
    {
        bool IsPaused { get; }

        void Pause();

        void Resume();

        void Init(ContentManager content, Rectangle screenBounds);

        void Update(GameTime gameTime);

        void Draw(GameTime gameTime, SpriteBatch spritebatch);

        void HandleInput(GameTime gameTime);

        void ChangeBetweenScreens();
    }
}
