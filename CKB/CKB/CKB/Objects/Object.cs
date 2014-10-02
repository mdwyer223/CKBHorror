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
    public class Object : AnimatedSprite
    {
        public Object(Texture2D texture, Vector2 startPos)
            : base(texture, 0.07f, 4, startPos)
        {
        }



    }
}
