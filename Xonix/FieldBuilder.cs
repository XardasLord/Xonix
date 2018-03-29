using System.Drawing;

namespace Xonix
{
    class FieldBuilder
    {
        protected Field field = new Field();

        public FieldBuilder()
        {
        }

        public FieldBuilder WithLocation(Point location)
        {
            field.Location = location;
            return this;
        }

        public FieldBuilder WithState(FieldState state)
        {
            field.State = state;
            return this;
        }

        public Field Build()
        {
            return field;
        }
    }
}
