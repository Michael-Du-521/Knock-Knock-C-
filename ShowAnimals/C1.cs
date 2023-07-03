using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAnimals
{
    [assembly:AssemblyTitle("ZooMap")]
    internal class C1 : IDrawAnimal
    {
        public void ShowAnimal(Graphics g, int x, int y)
        {
            Bitmap animalImage = new Bitmap(ImageResource.C1);
            g.DrawImage(animalImage, x, y);
        }
    }
}
