using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CKB
{

    //To allows sub classes to easily play animations
    public abstract class AnimatedSprite : BaseSprite
    {
        Animation curAni;
        int aniIndex;

        float time = 0;

        SpriteEffects flip;
        public bool Flip
        {
            get
            {
                return flip == SpriteEffects.FlipHorizontally;
            }
            protected set
            {
                if (value)
                    flip = SpriteEffects.FlipHorizontally;
                else
                    flip = SpriteEffects.None;
            }
            
        }

        public AnimatedSprite(Texture2D texture, float scaleFactor, float secondsToCrossScreen, Vector2 startPos)
            : base (texture, scaleFactor, secondsToCrossScreen, startPos)
        {
            this.Flip = false;
        }

        public override void update(GameTime gameTime)
        {
            if (curAni != null)
            {
                time += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (time >= curAni.getFrame(aniIndex).Time)
                {
                    aniIndex = (aniIndex + 1) % curAni.FrameCount;
                    time = 0;
                }
            }

        }

        public override void draw(SpriteBatch spriteBatch)
        {
            if (curAni == null)
                base.draw(spriteBatch);
            else
                spriteBatch.Draw(curAni.Strip, this.rec, curAni.getFrame(aniIndex).Rec, this.color, 0, Vector2.Zero, flip, 0);
        }

        public void playAnimation(Animation ani)
        {
            if (ani != null && ani != curAni)
                curAni = ani;
        }


    }
}
