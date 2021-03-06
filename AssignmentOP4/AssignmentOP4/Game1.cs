﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace AssignmentOP4
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D texture;
        ElementsFactory elementsfactory;
        ITraditionalIterator<IElement> elements;
        List<IElement> elementsList;
        SpriteFont font;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {


            // TODO: Add your initialization logic here
            texture = new Texture2D(GraphicsDevice, 1, 1);
            elementsfactory = new ElementsFactory();
            elementsList = new List<IElement>();
            elements = new ElementsList<IElement>(elementsList);

            string message;
            Action tmp = () => message = "yoo";
            var action = new Action(tmp);

            IElement Button1 = elementsfactory.Create(1, texture, action);
            IElement Button2 = elementsfactory.Create(2, texture, action);

            elementsList.Add(Button1);
            elementsList.Add(Button2);

            base.Initialize(); 
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            texture.SetData(new[] { Color.White });
            font = Content.Load<SpriteFont>("Title");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            IVisit visit = new ElVisitor();

            // TODO: Add your update logic here

            foreach (var item in elementsList)
            {
                item.Visit(visit);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            elements.MoveNext();
            //for (int i = 0; i <= elementsList.Count; i++)
            //{
            //    spriteBatch.Draw(texture, elements.Current.MakeButton, elements.Current.Color);
            //    elements.MoveNext();
            //}

            foreach (var item in elementsList)
            {
                item.Draw(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
