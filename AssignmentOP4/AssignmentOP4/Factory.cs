using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    abstract class Factory
        {
        public abstract Button Create(int id, Texture2D texture, Action action);
        }
    
}
