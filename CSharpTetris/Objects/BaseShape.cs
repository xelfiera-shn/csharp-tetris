using CSharpTetris.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTetris.Objects
{
    public class BaseShape: Control
    {
        protected int _value;
        public virtual int Value { get => _value; }

        public virtual Image ShapeBackground => throw new NotImplementedException();

        public virtual Point SpawnPosition => throw new NotImplementedException();

        public virtual Point OutlineShape { get; }

        protected Point _outlinePosition;
        public virtual Point OutlinePosition
        {
            get => _outlinePosition;
            
            set
            {
                _outlinePosition = value;
                UpdateLocation();
            }
        }

        public virtual List<Point[]> Rotations => throw new NotImplementedException();

        protected int _currentRotationIndex;
        public virtual int CurrentRotationIndex
        {
            get => _currentRotationIndex;

            set
            {
                if (value < 0)
                {
                    value = Rotations.Count - 1;
                }

                else if (value >= Rotations.Count)
                {
                    value = 0;
                }

                _currentRotationIndex = value;
                this.UpdateRotation();
            }
        }

        public BaseShape()
        {
            this.Size = new Size(OutlineShape.X * 32, OutlineShape.Y * 32);

            for (int i = 0; i < Rotations[CurrentRotationIndex].Length; i++)
            {
                Block block = new(Rotations[CurrentRotationIndex][i].X, Rotations[CurrentRotationIndex][i].Y, ShapeBackground);
                this.Controls.Add(block);
            }
        }

        public void ChangeRotation(string rotation)
        {
            switch (rotation)
            {
                case "NEXT":
                    CurrentRotationIndex++;
                    break;

                case "PREVIOUS":
                    CurrentRotationIndex--;
                    break;
            }
        }

        public void UpdateRotation()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                ((Block)this.Controls[i]).InnerPosition = new Point(this.Rotations[CurrentRotationIndex][i].X, this.Rotations[CurrentRotationIndex][i].Y);
                ((Block)this.Controls[i]).UpdateLocation();
            }
        }

        public void ChangeLocation(string direction)
        {
            switch (direction)
            {
                case "LEFT":
                    OutlinePosition = new Point(OutlinePosition.X - 1, OutlinePosition.Y);
                    break;

                case "RIGHT":
                    OutlinePosition = new Point(OutlinePosition.X + 1, OutlinePosition.Y);
                    break;

                case "DOWN":
                    OutlinePosition = new Point(OutlinePosition.X, OutlinePosition.Y + 1);
                    break;
            }
        }

        public void UpdateLocation()
        {
            this.Location = new Point(OutlinePosition.X * 32, OutlinePosition.Y * 32);
        }
    }
}