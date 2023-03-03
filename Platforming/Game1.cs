using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Platforming.Characters;

namespace Platforming
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D tankSprite;

        SpriteFont fontSprite;

        Vector2 tankPosition;
        double tankRotation;

        CharacterOne playerOne;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            tankSprite = Content.Load<Texture2D>("tank1");
            fontSprite = Content.Load<SpriteFont>("galleryFont");
            tankPosition = new Vector2(0, 0);
            tankRotation = 0;

            playerOne = new CharacterOne(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState keyboardState = Keyboard.GetState();

            //KeyboardState keyboardState = Keyboard.GetState();

            //if (keyboardState.IsKeyDown(Keys.S))
            //{
            //    Vector2 vect = playerOne.Position;
            //    playerOne.Position.Y += 1;
            //}
            //if (keyboardState.IsKeyDown(Keys.Z))
            //{
            //    tankPosition.Y -= 1;
            //}
            //if (keyboardState.IsKeyDown(Keys.D))
            //{
            //    tankPosition.X += 1;
            //}
            //if (keyboardState.IsKeyDown(Keys.Q))
            //{
            //    tankPosition.X -= 1;
            //}

            //if (keyboardState.IsKeyDown(Keys.N))
            //{
            //    tankRotation += 0.1;
            //}

            //if (keyboardState.IsKeyDown(Keys.B))
            //{

            //}
            //playerOne.MoveLeft();
            //playerOne.CheckActions(keyboardState);
            if (keyboardState.IsKeyDown(Keys.S))
            {
                playerOne.MoveDown();
            }
            if (keyboardState.IsKeyDown(Keys.Z))
            {
                playerOne.MoveUp();
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                playerOne.MoveRight();
            }
            if (keyboardState.IsKeyDown(Keys.Q))
            {
                playerOne.MoveLeft();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(playerOne.Texture, playerOne.Position, null, Color.White, (float)tankRotation, new Vector2(0, 0), 1, SpriteEffects.None, 1);
            //_spriteBatch.Draw(tankSprite, tankPosition, null, Color.White, (float)tankRotation, new Vector2(0, 0), 1, SpriteEffects.None, 1);
            _spriteBatch.DrawString(fontSprite, playerOne.Position.X.ToString(), new Vector2(0, 0), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}