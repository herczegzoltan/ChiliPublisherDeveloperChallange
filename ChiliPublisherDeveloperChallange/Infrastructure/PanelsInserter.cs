using ChiliPublisherDeveloperChallange.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class PanelsInserter
    {
        public static Bitmap DrawingRectangles(Bitmap bm, List<Rectangle> listRec)
        {

            using (Graphics gr = Graphics.FromImage(bm))
            {
                foreach (var itemRec in listRec)
                {
                    using (Pen thick_pen = new Pen(Color.Black, 1))
                    {
                        gr.DrawRectangle(thick_pen, itemRec);
                    }
                }
            }
            return bm;

        }
    }
}
