using CSharpTetris.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTetris.Objects.Shapes
{
    public class ShapeI : BaseShape
    {
        public override Image ShapeBackground => Resources.blue_block;

        public override Point SpawnPosition => new Point(3, 0);

        public override Point OutlineShape => new Point(4, 4);

        public override List<Point[]> Rotations => new List<Point[]>
        {
            new Point[4] { new Point(0, 1),  new Point(1, 1),  new Point(2, 1),  new Point(3, 1) },
            new Point[4] { new Point(2, 0),  new Point(2, 1),  new Point(2, 2),  new Point(2, 3) },
            new Point[4] { new Point(0, 2),  new Point(1, 2),  new Point(2, 2),  new Point(3, 2) },
            new Point[4] { new Point(1, 0),  new Point(1, 1),  new Point(1, 2),  new Point(1, 3) }
        };

        public ShapeI()
        {
            _value = 1; // The value of the blocks for the canvas control.
            this.OutlinePosition = SpawnPosition;
        }
    }
}
