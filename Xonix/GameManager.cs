using System.Drawing;

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
            
            gameArea.DrawMap(xonixGraphic);
            gameArea.DrawPlayer();
        }

        public void MovePlayer()
        {
            gameArea.MovePlayer();
        }
    }
}
