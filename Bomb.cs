using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defense
{
    class Bomb : Projectile
    {
        Point dest;
        int damage;
        int areaofeffect;
        List<Enemy> enemylist;
        Vector2 direction;
        Action<int, Point> damageFunc;

        public Bomb(Point position, Texture2D tex, Point dest, List<Enemy> enemylist, int damage, int areaofeffect, Action<int, Point> damageFunc) : base(tex, position)
        {
            this.dest = dest;
            this.Tex = tex;
            this.damage = damage;
            this.areaofeffect = areaofeffect;
            this.enemylist = enemylist;
            this.damageFunc = damageFunc;

            direction = (position - dest).ToVector2();
            if (direction != Vector2.Zero)
            {
                direction.Normalize();
            }

            public override bool Move()
        {
            Position -= (direction * speed).ToPoint();

            if (Vector2.Distance(Position.ToVector2(), dest.ToVector2()) < 15)
            {
                Damage();
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Damage()
        {
            foreach(Enemy e in enemylist)
            {
                if((int)Math.Sqrt(Math.Pow(this.Position.X - e.Position.X, 2) + Math.Pow(this.Position.Y - e.Position.Y, 2)) <= areaofeffect)
                {
                    damageFunc(damage, e.Position);
                    e.damage(damage);
                }
            }
        }
        public override void OnHit(Enemy other)
        {
            if (other is Enemy)
            {

            }
        }

        public override void LoadContent(ContentManager content)
        {

        }

        public override void Update(GameTime gameTime)
        {
            //Spawne spriten
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //Spawne spriten

            //Lav Animate metode til at animere bombe
        }
    }
}

    }



   