using CSharpTetris.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTetris.Objects.Shapes
{
    public class ShapeO : BaseShape
    {
        public override Image ShapeBackground => Resources.yellow_block;

        public override Point SpawnPosition => new Point(4, 0);

        public override Point OutlineShape => new Point(2, 2);

        public override List<Point[]> Rotations => new List<Point[]>
        {
            new Point[4] { new Point(0, 0),  new Point(0, 1),  new Point(1, 0),  new Point(1, 1) }
        };

        public ShapeO()
        {
            _value = 4; // The value of the blocks for the canvas control.
            this.OutlinePosition = SpawnPosition; // Spawn location
        }
    }
}
