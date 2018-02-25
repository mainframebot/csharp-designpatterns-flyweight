using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyWeightPatternLesson;
using NUnit.Framework;

namespace FlyWeightPatternTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Testing()
        {
            for (var i = 0; i < 20; i++)
            {
                var tile = TileFactory.GetTile("Ceramic");
            }

            for (var i = 0; i < 20; i++)
            {
                var tile = TileFactory.GetTile("Stone");
            }

            var counter1 = CeramicTile.ObjectCounter;
            var counter2 = StoneTile.ObjectCounter;
        }
    }
}
