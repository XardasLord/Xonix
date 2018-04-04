using System.Drawing;
using System.Windows.Input;

namespace Xonix
{
    class GameArea
    {
        private const int FIELD_SIZE = 10;
        private const int FIELD_WIDTH = 20;
        private const int FIELD_HEIGHT = 20;
        private const int PLAYER_START_X = 10;
        private const int PLAYER_START_Y = 10;

        public Field[,] Fields { get; private set; }
        public Player Player { get; private set; }
        public bool IsMapGenerated { get; private set; } = false;
        public bool IsPlayerSpawned { get; private set; } = false;

        private Graphics graphic;
        private int width; // Columns
        private int height; // Rows

        public GameArea(int width, int height)
        {
            this.width = width;
            this.height = height;
            Fields = new Field[height/FIELD_SIZE, width/FIELD_SIZE];
        }

        public void DrawMap(Graphics graphic)
        {
            this.graphic = graphic;

            if(IsMapGenerated == false)
                PrepareFields();

            DrawFields();

            IsMapGenerated = true;
        }

        private void PrepareFields()
        {
            int tmpX = 0, tmpY = 0;

            for(var row = 0; row < height/FIELD_SIZE; row++)
            {
                for (var col = 0; col < width / FIELD_SIZE; col++)
                {
                    var state = SpecifyDefaultState(tmpX, tmpY);

                    Fields[row, col] = new FieldBuilder()
                        .WithLocation(tmpX, tmpY)
                        .WithState(state)
                        .Build();

                    if (tmpX == width)
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
        }

        private FieldState SpecifyDefaultState(int x, int y)
        {
            if(x == 0 || x == 10 || y == 0 || y == 10 || x == 990 || x == 980 || y == 590 || y == 580)
            {
                // Map Boundary
                return FieldState.Outside;
            }
            else
            {
                return FieldState.Free;
            }
        }

        private void DrawFields()
        {
            graphic.Clear(Color.LightSkyBlue);

            foreach(var field in Fields)
            {
                graphic.FillRectangle(new SolidBrush(field.Color), field.Location.X, field.Location.Y, FIELD_WIDTH, FIELD_HEIGHT);
            }
        }

        private void SpawnPlayer()
        {
            Player = new Player(PLAYER_START_X, PLAYER_START_Y, graphic);
            Player.Move();

            IsPlayerSpawned = true;
        }

        public void MovePlayer()
        {
            int moveX = 0, moveY = 0;

            if (Keyboard.IsKeyDown(Key.Up))
                moveY = -10;
            else if (Keyboard.IsKeyDown(Key.Down))
                moveY = 10;
            else if (Keyboard.IsKeyDown(Key.Left))
                moveX = -10;
            else if (Keyboard.IsKeyDown(Key.Right))
                moveX = 10;

            Player.Move(moveX, moveY);
        }

        public void DrawPlayer()
        {
            if (IsPlayerSpawned == false)
                SpawnPlayer();

            Player.Draw(graphic);
        }
    }
}
