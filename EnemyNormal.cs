using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Tower_Defense
{
    class EnemyNormal : Enemy
    {
        // Variabler hentes fra Enemy superklassen


        public int Death (int value)
        {
            value = 10;
            return value;
        }

        public void LoadContent(ContentManager content)
        {
            content.Load<Texture2D>("enemyNormal");
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        public void OnCollision(Enemy other)
        {
            if (other is /* Insert projectile */)
            {
                // Add damage or destruction/de-activate
            }
        }
    }
}
