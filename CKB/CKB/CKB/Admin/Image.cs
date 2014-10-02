using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CKB
{
    public static class Image
    {
        public static Texture2D Particle
        {
            get { return Game1.GameContent.Load<Texture2D>("Testing/Particle"); }
        }

        public class Character
        {
            public static Texture2D Walk
            {
                get { return Game1.GameContent.Load<Texture2D>("Testing/PomruWalkCycle"); }
            }
        }


        // other images...
    }
}
