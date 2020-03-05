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
        public static Bitmap DrawingRectangles(Bitmap bm, List<RectangleWrapper> listRec)
        {
            using (Graphics gr = Graphics.FromImage(bm))
            {
                foreach (var itemRec in listRec)
                {
                    using (Font arialFont = new Font("Arial", 20))
                    {
                        gr.DrawString(itemRec.Name, arialFont, Brushes.Blue,new Point() { X = itemRec.ActualRectangle.X, Y = itemRec.ActualRectangle.Y});
                    }
                    using (Pen thick_pen = new Pen(Color.Black, 3))
                    {
                        //itemRec.ActualRectangle.X = itemRec.ActualRectangle.X + itemRec.Offset;

                        Rectangle temp = new Rectangle();

                        temp = itemRec.ActualRectangle;
                        temp.Offset(itemRec.Offset, 0);
                        gr.DrawRectangle(thick_pen, temp);

                    }
                }
            }
            return bm;

        }
    }
}
