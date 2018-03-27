using System.Drawing;

namespace Xonix
{
    class FieldBuilder
    {
        protected Field _field = new Field();

        public FieldBuilder()
        {
        }

        public FieldBuilder WithLocation(Point location)
        {
            _field.Location = location;
            return this;
        }

        public FieldBuilder WithImage(string imagePath)
        {
            _field.Image = Image.FromFile(imagePath);
            return this;
        }

        public FieldBuilder WithName(string name)
        {
            _field.Name = name;
            return this;
        }

        public FieldBuilder WithState(FieldState state)
        {
            _field.State = state;
            return this;
        }

        public Field Build()
        {
            return _field;
        }
    }
}
