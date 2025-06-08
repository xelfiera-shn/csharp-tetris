using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTetris.Game
{
    public class ControlKeys
    {
        public const Keys MOVE_LEFT_KEY = Keys.A;
        public const Keys MOVE_RIGHT_KEY = Keys.D;
        public const Keys NEXT_ROTATION_KEY = Keys.W;
        public const Keys PREV_ROTATION_KEY = Keys.Z;
        public const Keys HOLD_KEY = Keys.F;
        public const Keys SOFT_DROP_KEY = Keys.S;
        public const Keys HARD_DROP_KEY = Keys.Space;
    }
}
