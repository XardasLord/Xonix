using System.Drawing;

namespace Xonix
{
    class GameArea
    {
        private const int FIELD_SIZE = 10;
        private const int FIELD_WIDTH = 20;
        private const int FIELD_HEIGHT = 20;

        public Field[,] Fields { get; private set; }

        private Graphics graphic;
        private int width; // Columns
        private int height; // Rows

        public GameArea(int width, int height)
        {
            this.width = width;
            this.height = height;
            Fields = new Field[height/FIELD_SIZE, width/FIELD_SIZE];
        }

        public void GenerateMap(Graphics graphic)
        {
            this.graphic = graphic;

            PrepareFields();
            DrawFields();
        }

        private void PrepareFields()
        {
            int tmpX = 0, tmpY = 0;

            for(var row = 0; row < height/FIELD_SIZE; row++)
                for(var col = 0; col < width/FIELD_SIZE; col++)
                {
                    Fields[row, col] = new FieldBuilder()
                        .WithLocation(new Point(tmpX, tmpY))
                        .WithState(FieldState.Free)
                        .Build();

                    if(tmpX == width)
                    {
                        // Move to the next row
                        tmpX = 0;
                        tmpY += FIELD_SIZE;
                    }
                    else
                    {
                        // Next column
                        tmpX += FIELD_SIZE;
                    }
                }
        }

        private void DrawFields()
        {
            foreach(var field in Fields)
            {
                graphic.FillRectangle(new SolidBrush(Color.Black), field.Location.X, field.Location.Y, FIELD_WIDTH, FIELD_HEIGHT);
            }
        }
    }
}
