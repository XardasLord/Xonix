using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xonix
{
    public partial class XonixGame : Form
    {
        private GameManager _gameManager;

        public XonixGame()
        {
            InitializeComponent();

            _gameManager = new GameManager(this);
            _gameManager.StartGame();
        }
    }
}
