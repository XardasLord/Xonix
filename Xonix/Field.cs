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

        public Field()
        {
        }
    }
}
