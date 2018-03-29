using System.Windows.Forms;

namespace Xonix
{
    public partial class XonixGame : Form
    {
        private GameManager gameManager;

        public XonixGame()
        {
            InitializeComponent();
        }

        private void GameAreaPanel_Paint(object sender, PaintEventArgs e)
        {
            gameManager = new GameManager(this, e.Graphics);
            gameManager.StartGame();
        }
    }
}
