using System.Drawing;
using System.Windows.Forms;

namespace Xonix
{
    class GameManager
    {
        private const int MAP_WIDTH = 1000;
        private const int MAP_HEIGHT = 600;
        private Form xonixGame;
        private Graphics xonixGraphic;
        private GameArea gameArea;

        public GameManager(Form xonixGame, Graphics graphic)
        {
            this.xonixGame = xonixGame;
            xonixGraphic = graphic;
            gameArea = new GameArea(MAP_WIDTH, MAP_HEIGHT);
        }

        public void StartGame()
        {
            //TODO: Spawn player, enemies and start playing
            DrawGameArea();
        }

        private void DrawGameArea()
        {
            gameArea.GenerateMap(xonixGraphic);
        }
    }
}
