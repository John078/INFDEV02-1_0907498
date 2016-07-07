using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentOP4
{
    class ElementsFactory : Factory
    {

        public override Button Create(int id, Texture2D texture, Action action)
        {
            if ((id == 1))
            {
                return new Button(Color.Red, new Point(200, 200), new Point(50, 50), texture, action);
            }
            if ((id == 2))
            {
                return new Button(Color.Yellow, new Point(400, 200), new Point(50, 50), texture, action);
                //return new Label(Color.Yellow, new Point(100, 100), new Point(100, 100), action, "Hallo", Tit);
            }
            throw new Exception("Wrong input");


        }
    }
}