using System.Windows.Forms;

namespace Xonix
{
    public partial class XonixGame : Form
    {
        private GameManager gameManager = new GameManager();

        public XonixGame()
        {
            InitializeComponent();

            GameTimer.Start();
        }

        private void GameAreaPanel_Paint(object sender, PaintEventArgs e)
        {
            gameManager.DrawEverything(e.Graphics);
        }

        private void GameTimer_Tick(object sender, System.EventArgs e)
        {
            gameManager.MovePlayer();
            GameAreaPanel.Invalidate();
        }
    }
}
