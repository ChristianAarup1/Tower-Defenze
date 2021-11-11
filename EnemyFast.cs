using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Tower_Defense
{
    class EnemyFast : Enemy
    {
        // Variabler hentes fra Enemy superklassen
        private int fastHealth = 75;

        public int Death(int fastValue)
        {
            fastValue = 8;
            return fastValue;
        }

        public override void LoadContent(ContentManager content)
        {
            content.Load<Texture2D>("enemyFast");
            Health = 75;
        }

        public override void Update(GameTime gameTime)
        {
            // Make the unit move on the specified path (enum?)

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        //public void OnCollision(Enemy other)
        //{
        //    if (other is /* Insert projectile */)
        //    {
        //        // Add damage or destruction/de-activate
        //    }
        //}

    }
}
