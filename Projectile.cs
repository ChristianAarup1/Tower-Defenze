using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;


namespace Tower_Defense
{
    public abstract class Projectile
    {
        protected int damage;
        protected float speed;
        protected bool isActive;
        protected Texture2D sprite;

        public abstract void OnHit(Enemy other);

        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public abstract void Draw(SpriteBatch spriteBatch);
    }

}
