using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CKB
{
    public abstract class Object : AnimatedSprite
    {
        MouseState mouse, oldMouse;

        public Object(Texture2D texture, float scaleFactor, float secondsToCrossScreen, Vector2 startPos)
            : base(texture, scaleFactor, secondsToCrossScreen, startPos)
        {
        }

        public sealed override void update(GameTime gameTime)
        {
            base.update(gameTime);
            mouse = Mouse.GetState();

            Vector2 mousePos = new Vector2(mouse.X, mouse.Y);
            //Check for hover
            if (this.isColliding(mousePos))
            {
                onHover(mousePos);
                this.color = new Color(185, 185, 185);

                //Check for mouse click
                if (mouse.LeftButton == ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Released)
                {
                    onClick(mousePos); 
                    this.color = Color.Red;
                }
            }
            else
                this.color = Color.White;

            oldMouse = mouse;
        }

        protected virtual void onClick(Vector2 mousePos)
        {
        }

        protected virtual void onHover(Vector2 mousePos)
        {
        }
    }
}
