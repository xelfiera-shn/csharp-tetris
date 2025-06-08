using CSharpTetris.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTetris.Objects.Shapes
{
    public class ShapeT : BaseShape
    {
        public override Image ShapeBackground => Resources.purple_block;

        public override Point SpawnPosition => new Point(3, 0);

        public override Point OutlineShape => new Point(3, 3);

        public override List<Point[]> Rotations => new List<Point[]>
        {
            new Point[4] { new Point(1, 0),  new Point(0, 1),  new Point(1, 1),  new Point(2, 1) },
            new Point[4] { new Point(2, 1),  new Point(1, 0),  new Point(1, 1),  new Point(1, 2) },
            new Point[4] { new Point(1, 2),  new Point(2, 1),  new Point(1, 1),  new Point(0, 1) },
            new Point[4] { new Point(0, 1),  new Point(1, 2),  new Point(1, 1),  new Point(1, 0) }
        };

        public ShapeT()
        {
            _value = 6; // The value of the blocks for the canvas control.
            this.OutlinePosition = SpawnPosition; // Spawn location
        }
    }
}
