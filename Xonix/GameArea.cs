using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xonix
{
    class GameArea
    {
        public ICollection<Field> Fields { get; private set; }

        public GameArea()
        {
            GenerateFields();
        }

        private void GenerateFields()
        {
            Fields = new List<Field>();
            var builder = new FieldBuilder();
            int locationX = 0, locationY = 0;

            //for(var i = 0; i < 10; i++)
            //{
            //    var field = builder
            //                .WithLocation(new Point(locationX, locationY))
            //                .WithName($"Field{i}")
            //                .Build();

            //    Fields.Add(field);
            //}
        }
    }
}
