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
    public class Phone : Object
    {
        public Phone(Vector2 startPos)
            : base(Image.Particle, .07f, 0, startPos)
        {
            //playAnimation(new Animation(Image.Character.Walk, 50, .3f));
        }
        
    }
}
