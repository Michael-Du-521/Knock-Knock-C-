using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShowAnimals
{
    internal interface IDrawAnimal
    {
        void ShowAnimal(Graphics g, int x, int y);
    }
}
