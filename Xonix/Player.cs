using System.Drawing;

namespace Xonix
{
    class Player
    {
        public Point Location { get; private set; }
        private SolidBrush brush = new SolidBrush(Color.Blue);

        /// <summary>
        /// Initializate player with default spawn location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Player(int x, int y, Graphics graphic)
        {
            Location = new Point(x, y);
        }

        public void Draw(Graphics graphic)
        {
            graphic.FillRectangle(brush, Location.X, Location.Y, 10, 10);
        }

        public void Move(int moveX = 0, int moveY = 0)
        {
            Location = new Point(Location.X + moveX, Location.Y + moveY);
        }
    }
}
