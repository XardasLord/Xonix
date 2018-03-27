using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xonix
{
    public enum FieldState
    {
        Outside,
        Free,
        Captured,
        Getting
    }

    class Field : PictureBox
    {
        private const int WIDTH = 20;
        private const int HEIGHT = 20;

        public FieldState State { get; set; }

        public Field()
        {
            this.Width = WIDTH;
            this.Height = HEIGHT;
        }
    }
}
