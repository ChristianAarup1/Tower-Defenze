using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Tower_Defense
{
    abstract class Enemy : Game1
    {
        // Variabler/fields
        protected Vector2 position;
        protected float speed = 0f;
        protected int value = 0;
        protected Texture2D sprite;
        protected int health;

        // Metode til at instantiere content
        public void LoadContent(ContentManager content)
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }


    }
}
