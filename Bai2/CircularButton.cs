using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Bai2
{
    class CircularButton:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath =new GraphicsPath();
            grPath.AddEllipse(0,0,ClientSize.Width,ClientSize.Width);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
