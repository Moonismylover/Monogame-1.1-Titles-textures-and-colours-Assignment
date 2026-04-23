using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_1._1___Titles__textures__and_colours__Assignment_
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dovetexture;
        Texture2D bordertexture;
        Texture2D cloudtexture;
        Texture2D skeletonhandtexture;
        Texture2D aurabgtexture;
        Texture2D glowtexture;
        Texture2D hearttexture;

        int randomX, randomY;

        Rectangle window;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            window = new Rectangle(0, 0, 800, 500);
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();   

            this.Window.Title = "Monogame 1.1 - Titles, Textures, and Colours (Assignment)";

            Random generator = new Random();

            randomX = generator.Next(0, window.Width);
            randomY = generator.Next(0, window.Height);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            aurabgtexture = Content.Load<Texture2D>("Aurabg");
            bordertexture = Content.Load<Texture2D>("Borderimg");
            cloudtexture = Content.Load<Texture2D>("blackcloud");
            skeletonhandtexture = Content.Load<Texture2D>("skeletonhand");
            dovetexture = Content.Load<Texture2D>("whitedove");
            glowtexture = Content.Load<Texture2D>("Glow");
            hearttexture = Content.Load<Texture2D>("Heart");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(aurabgtexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(bordertexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(cloudtexture, new Vector2(10, 0), Color.White);
            _spriteBatch.Draw(glowtexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(skeletonhandtexture, new Vector2(10, 0), Color.White);

            for (int row = 200; row < 300; row += 50)
            {
                for (int col = 50; col < 200; col += 50)
                {
                    _spriteBatch.Draw(hearttexture, new Vector2(col, row), Color.White);
                }
            }

            _spriteBatch.Draw(dovetexture, new Vector2(randomX, randomY), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}





// Try to guarantee that no part of the texture is drawn outside the window.
//o Load more than one potential background images into your program and randomly
//choose which one you will set as your background texture.
// You could randomly choose one in your LoadContent() method.
//o Generating a random number in a Monogame program is no different than in a console
//program.
