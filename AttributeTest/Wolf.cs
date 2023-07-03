using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest
{
    [AnimalInfo("wolf","dog",Classis ="Burundi",Phylum ="脊索动物门")]
    internal class Wolf
    {
        [ObsoleteAttribute("Depracte Function, please use the NewDrawMyself()",false)]
        public void DrawMyself()
        {
            Console.WriteLine(@" one wolf ");
        }
    }
}
