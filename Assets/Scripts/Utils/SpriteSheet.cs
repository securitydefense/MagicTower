﻿using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class SpriteSheet : Dictionary<string, Sprite>
    {
        public SpriteSheet(Sprite[] sprites)
        {
            foreach (var sprite in sprites)
            {
                Add(sprite.name, sprite);
            }
        }

        public new Sprite this[string key]
        {
            get
            {
                Sprite ret;
                if (TryGetValue(key, out ret))
                    return ret;
                else
                    return null;
            }
        }
    }
}
