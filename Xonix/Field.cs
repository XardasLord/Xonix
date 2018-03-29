using System;
using System.Drawing;

namespace Xonix
{
    public enum FieldState
    {
        Outside,
        Free,
        Captured,
        Getting
    }

    class Field
    {
        public FieldState State { get; set; }
        public Point Location { get; set; }
        public Color Color => GetColor();

        public Field()
        {
        }

        private Color GetColor()
        {
            var color = Color.White;

            switch (State)
            {
                case FieldState.Free:
                    color = Color.White;
                    break;
                case FieldState.Outside:
                    color = Color.Black;
                    break;
                case FieldState.Getting:
                    color = Color.Beige;
                    break;
                case FieldState.Captured:
                    color = Color.Brown;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Field State value is out of range.");
            }

            return color;
        }
    }
}
