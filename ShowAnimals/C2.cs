using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAnimals
{
    internal class C2 :IDrawAnimal
    {
        public void ShowAnimal(Graphics g, int x, int y)
        {
            Bitmap animalImage = new Bitmap(ImageResource.C2);
            g.DrawImage(animalImage, x, y);
        }
    }
}
