﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;

namespace ProjectZero.SoundSystem
{
    public partial class SoundRenderer
    {
        public ContentManager ContentManager { get; private set; }

        public SoundRenderer(ContentManager contentManager)
        {
            ContentManager = contentManager;
        }
    }
}
