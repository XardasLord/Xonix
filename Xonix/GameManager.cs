using System.Drawing;

namespace Xonix
{
    class GameManager
    {
        private Graphics xonixGraphic;
        private GameArea gameArea;

        public GameManager()
        {
            gameArea = new GameArea(ConstantsSettings.MAP_WIDTH, ConstantsSettings.MAP_HEIGHT);
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
