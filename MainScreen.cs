using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeAI
{
    public partial class DodgeAI : Form
    {
        public DodgeAI()
        {
            InitializeComponent();
        }

        private void DodgeAI_Load(object sender, EventArgs e)
        {

        }

        private void DodgeAI_Paint(object sender, PaintEventArgs e)
        {

            Border borderLeft = new Border(0, 0, 1000, 25, 0, 0, "Black");
            Border borderRight = new Border(711, 0, 1000, 25, 0, 0, "Black");
            Border borderTop = new Border(0, 0, 25, 1000, 0, 0, "Black");
            Border borderBottom = new Border(0, 750, 25, 1000, 0, 0, "Black");
            SolidBrush brush = new SolidBrush(Color.FromName(borderLeft.Color));

            Rectangle recLeft = new Rectangle
            {
                X = borderLeft.X,
                Y = borderLeft.Y,
                Height = borderLeft.Height,
                Width = borderLeft.Width
            };

            Rectangle recRight = new Rectangle
            {
                X = borderRight.X,
                Y = borderRight.Y,
                Height = borderRight.Height,
                Width = borderRight.Width
            };

            Rectangle recTop = new Rectangle
            {
                X = borderTop.X,
                Y = borderTop.Y,
                Height = borderTop.Height,
                Width = borderTop.Width
            };

            Rectangle recBottom = new Rectangle
            {
                X = borderBottom.X,
                Y = borderBottom.Y,
                Height = borderBottom.Height,
                Width = borderBottom.Width
            };

            e.Graphics.FillRectangle(brush, recLeft);
            e.Graphics.FillRectangle(brush, recRight);
            e.Graphics.FillRectangle(brush, recTop);
            e.Graphics.FillRectangle(brush, recBottom);
        }
    }
}
