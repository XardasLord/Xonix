using System.Drawing;
using System.Windows.Input;

namespace Xonix
{
    class GameArea
    {
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
            Fields = new Field[height/ConstantsSettings.FIELD_SIZE, width/ConstantsSettings.FIELD_SIZE];
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

            for(var row = 0; row < height / ConstantsSettings.FIELD_SIZE; row++)
            {
                for (var col = 0; col < width / ConstantsSettings.FIELD_SIZE; col++)
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
                        tmpY += ConstantsSettings.FIELD_SIZE;
                    }
                    else
                    {
                        // Next column
                        tmpX += ConstantsSettings.FIELD_SIZE;
                    }
                }
            }
        }

        private FieldState SpecifyDefaultState(int x, int y)
        {
            if(x == 0 || x == ConstantsSettings.FIELD_SIZE ||
               y == 0 || y == ConstantsSettings.FIELD_SIZE || 
               x == ConstantsSettings.MAP_WIDTH - ConstantsSettings.FIELD_SIZE || 
               x == ConstantsSettings.MAP_WIDTH - (ConstantsSettings.FIELD_SIZE * 2) || 
               y == ConstantsSettings.MAP_HEIGHT - ConstantsSettings.FIELD_SIZE || 
               y == ConstantsSettings.MAP_HEIGHT - (ConstantsSettings.FIELD_SIZE * 2))
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
                graphic.FillRectangle(new SolidBrush(field.Color), field.Location.X, field.Location.Y, ConstantsSettings.FIELD_WIDTH, ConstantsSettings.FIELD_HEIGHT);
            }
        }

        private void SpawnPlayer()
        {
            Player = new Player(ConstantsSettings.PLAYER_START_X, ConstantsSettings.PLAYER_START_Y, graphic);
            Player.Move();

            IsPlayerSpawned = true;
        }

        public void MovePlayer()
        {
            int moveX = 0, moveY = 0;
            var value = ConstantsSettings.FIELD_SIZE;

            if (Keyboard.IsKeyDown(Key.Up))
                moveY = -value;
            else if (Keyboard.IsKeyDown(Key.Down))
                moveY = value;
            else if (Keyboard.IsKeyDown(Key.Left))
                moveX = -value;
            else if (Keyboard.IsKeyDown(Key.Right))
                moveX = value;

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
