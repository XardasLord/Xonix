using System.Drawing;

namespace Xonix
{
    class Player
    {
        public Point Location { get; private set; }
        private Graphics graphic;
        
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

        public void Draw()
        {   
            graphic.FillRectangle(new SolidBrush(Color.Blue), Location.X, Location.Y, 10, 10);
        }
    }
}
