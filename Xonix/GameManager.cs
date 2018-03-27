using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xonix
{
    class GameManager
    {
        private Form _xonixGame;
        private GameArea _gameArea = new GameArea();

        public GameManager(Form xonixGame)
        {
            _xonixGame = xonixGame;
        }

        public void StartGame()
        {
            //TODO: Spawn player, enemies and start playing
            DrawGameArea();
        }

        private void DrawGameArea()
        {
            _xonixGame.Controls.AddRange(_gameArea.Fields.ToArray());
        }
    }
}
