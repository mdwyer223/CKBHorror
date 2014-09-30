using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class Floor
    {
        //list of objects
        protected Color color;
        Texture2D background;
        Vector2 position;
        Rectangle drawingRec;
        int width, height;

        public Floor(Texture2D background, Vector2 position, int width, int height)
            : base()
        {
            this.background = background;
            this.position = position;
            this.width = width;
            this.height = height;

            drawingRec = new Rectangle((int)position.X, (int)position.Y, width, height);
        }

        public virtual void update(GameTime gameTime)
        {
            //updates everything
        }

        public virtual void draw(SpriteBatch spriteBatch)
        {
            //draws everything
            spriteBatch.Draw(background, drawingRec, color); 
        }
    }
}
