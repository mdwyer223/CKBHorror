using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class Floor2 : Floor
    {
        public Floor2()
            : base(Image.Particle, Vector2.Zero, 800, 480)
        {
            color = Color.Green;
        }
    }
}
