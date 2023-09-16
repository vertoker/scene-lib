﻿using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneFramework.Interfaces.Kernel.Base
{
    public interface IContentUnload
    {
        public void Unload(ContentManager manager);
    }
}