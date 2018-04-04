using System.Drawing;

namespace Xonix
{
    class Player
    {
        public Point Location { get; private set; }
        private Graphics graphic;
        private SolidBrush brush = new SolidBrush(Color.Blue);

        /// <summary>
        /// Initializate player with default spawn location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Player(int x, int y, Graphics graphic)
        {
            Location = new Point(x, y);
            this.graphic = graphic;
        }

        private void Draw()
        {
            graphic.FillRectangle(brush, Location.X, Location.Y, 10, 10);
        }

        public void Move(int moveX, int moveY, Graphics graphic)
        {
            this.graphic = graphic;

            Location = new Point(Location.X + moveX, Location.Y + moveY);
            Draw();
        }
    }
}
