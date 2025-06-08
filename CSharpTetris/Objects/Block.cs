using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTetris.Properties;

namespace CSharpTetris.Objects
{
    public class Block: PictureBox
    {
        private const int SIZE_X = 32;
        private const int SIZE_Y = 32;

        private Point _innerPosition;
        public Point InnerPosition { get => _innerPosition; set => _innerPosition = value; }

        public Block(int posX, int posY, Image background)
        {
            this.InnerPosition = new Point(posX, posY);

            this.Size = new Size(SIZE_X, SIZE_Y);
            this.Location = new Point(InnerPosition.X * 32, InnerPosition.Y * 32);
            this.BackgroundImage = background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void UpdateLocation()
        {
            this.Location = new Point(InnerPosition.X * 32, InnerPosition.Y * 32);
        }
    }
}
