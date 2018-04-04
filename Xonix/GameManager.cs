using System.Drawing;
using System.Windows.Input;

namespace Xonix
{
    class GameManager
    {
        private const int MAP_WIDTH = 1000;
        private const int MAP_HEIGHT = 600;
        private Graphics xonixGraphic;
        private GameArea gameArea;

        public GameManager()
        {
            gameArea = new GameArea(MAP_WIDTH, MAP_HEIGHT);
        }

        public void DrawEverything(Graphics graphic)
        {
            xonixGraphic = graphic;
            
            gameArea.GenerateMap(xonixGraphic);
            MovePlayer();
        }

        private void MovePlayer()
        {
            //TODO: Move this logic to the game area

            int moveX = 0, moveY = 0;

            if(Keyboard.IsKeyDown(Key.Up))
                moveY = -10;
            else if(Keyboard.IsKeyDown(Key.Down))
                moveY = 10;
            else if (Keyboard.IsKeyDown(Key.Left))
                moveX = -10;
            else if (Keyboard.IsKeyDown(Key.Right))
                moveX = 10;
            
            gameArea.MovePlayer(moveX, moveY, xonixGraphic);
        }
    }
}
