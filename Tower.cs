using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Tower_Defense
{
    public abstract class Tower
    {
        protected int damage;
        protected float range;
        protected int cost;
        protected float rateOfFire;
        protected Texture2D sprite;




        public Tower()
        {

        }

        public abstract void Shoot(GameTime gameTime);


        public abstract void Draw(SpriteBatch spriteBatch);



        public abstract void LoadContent(ContentManager content);



        public abstract void Update(GameTime gameTime);
        
}