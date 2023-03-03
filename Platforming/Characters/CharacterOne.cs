using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platforming.Characters
{
    public class CharacterOne : Game
    {

        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public double Speed { get; set; }
        public int LifePoint { get; set; }

        private readonly ContentManager _content;

        public CharacterOne(ContentManager content)
        {
            _content = content;
            Texture = _content.Load<Texture2D>("Punk_jump");
            Position = new Vector2(0, 0);
            Speed = 1;
            LifePoint = 20;
        }

        public void MoveLeft()
        {
            Vector2 vect = new Vector2(Position.X - 1, Position.Y);
            Position = vect;
        }
        public void MoveRight()
        {
            Vector2 vect = new Vector2(Position.X + 1, Position.Y);
            Position = vect;
        }
        public void MoveUp()
        {
            Vector2 vect = new Vector2(Position.X, Position.Y - 1);
            Position = vect;
        }
        public void MoveDown()
        {
            Vector2 vect = new Vector2(Position.X, Position.Y + 1);
            Position = vect;
        }

        public void CheckActions(KeyboardState keyboardState)
        {

            if (keyboardState.IsKeyDown(Keys.S))
            {
                MoveDown();
            }
            if (keyboardState.IsKeyDown(Keys.Z))
            {
                MoveUp();
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                MoveRight();
            }
            if (keyboardState.IsKeyDown(Keys.Q))
            {
                MoveLeft();
            }
            //MoveRight();
        }

        public void GetCurrentRectangle()
        {

            Rectangle sourceRectangle = new Rectangle(0, 0, 48, 48);
        }


    }
}
