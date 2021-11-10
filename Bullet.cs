using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Tower_Defense
{
    class Bullet : Projectile
    {


        public Texture2D texture;
        public Vector2 position;
        public Vector2 movement;

        public void Init(Texture2D text, Vector2 pos, Vector2 move)
        {
            texture = text;
            position = pos;
            movement = move;
        }
        public override void OnHit(Enemy other)
        {

        }
        public Bullet()
        {

        }

        public override void LoadContent(ContentManager content)
        {

        }

        public override void Update(GameTime gameTime)
        {
            if (!dead)
            {
                position += movement;
            }


        }
        public Vector2 Position
        {
            get { return position; }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!dead)
            {
                spriteBatch.Draw(texture, position, Color.White);
            }
        }
            
    }

    
}




