using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_1._1___Titles__textures__and_colours__Assignment_
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dovetexture;
        Texture2D bordertexture;
        Texture2D cloudtexture;
        Texture2D handtexture;
        Texture2D aurabgtexture;

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            aurabgtexture = Content.Load<Texture2D>("Aura");
            bordertexture = Content.Load<Texture2D>("Border");
            cloudtexture = Content.Load<Texture2D>("Clouds");
            handtexture = Content.Load<Texture2D>("Hand");
            dovetexture = Content.Load<Texture2D>("Dove");
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
            _spriteBatch.Draw(aurabgtexture, new Vector2(0, 0), Color.Red);
            _spriteBatch.Draw(bordertexture, new Vector2(0, 0), Color.Blue);
            _spriteBatch.Draw(dovetexture, new Vector2(10, 100), Color.White);
            _spriteBatch.Draw(cloudtexture, new Vector2(200, 100), Color.Black);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
