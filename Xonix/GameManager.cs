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

            this.xonixGame.KeyUp += MovePlayer;
        }

        public void StartGame()
        {
            gameArea.GenerateMap(xonixGraphic);
            gameArea.SpawnPlayer();
        }

        private void MovePlayer(object sender, KeyEventArgs e)
        {
            int moveX = 0, moveY = 0;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    moveY = -10;
                    break;
                case Keys.Down:
                    moveY = 10;
                    break;
                case Keys.Left:
                    moveX = -10;
                    break;
                case Keys.Right:
                    moveX = 10;
                    break;
                default:
                    return;
            }

            //gameArea.MovePlayer(moveX, moveY);
        }
    }
}
