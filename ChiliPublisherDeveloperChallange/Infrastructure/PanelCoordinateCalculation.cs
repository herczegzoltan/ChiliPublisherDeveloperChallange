using ChiliPublisherDeveloperChallange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class PanelCoordinateCalculation
    {
        public static List<CustomPanel> ChangeReferencePointOfRoot(List<CustomPanel> customPanels, RootObject root)
        {
            customPanels[0].X = Converters.DoubleStringToIntWithRound(root.RootX) - Converters.DoubleStringToIntWithRound(customPanels[0].Width) / 2;

            customPanels[0].Y = Converters.DoubleStringToIntWithRound(root.RootY) - Converters.DoubleStringToIntWithRound(customPanels[0].Hight);


            CalculateReferencePointToAllPanels(customPanels[0]);
            return customPanels;
        }

        private static void CalculateReferencePointToAllPanels(CustomPanel node)
        {
            for (int i = 0; i < node.ChildPanels.Count; i++)
            {
                CustomPanel currentPanel = node.ChildPanels[i];

                if (currentPanel.AT == "3" &&
                    currentPanel.Parent.RotationState == RotationState.none &&
                    currentPanel.RotationState == RotationState.thrice)
                {
                    string tempVal = currentPanel.Width;
                    currentPanel.Width = currentPanel.Hight;
                    currentPanel.Hight = tempVal;

                    currentPanel.X = currentPanel.Parent.X - Converters.DoubleStringToIntWithRound(currentPanel.Width);
                    currentPanel.Y = currentPanel.Parent.Y;
                }


                if (currentPanel.AT == "1" &&
                    currentPanel.Parent.RotationState == RotationState.none &&
                    currentPanel.RotationState == RotationState.once)
                {
                    string tempVal = currentPanel.Width;
                    currentPanel.Width = currentPanel.Hight;
                    currentPanel.Hight = tempVal;

                    currentPanel.X = currentPanel.Parent.X + Converters.DoubleStringToIntWithRound(currentPanel.Parent.Width);
                    currentPanel.Y = currentPanel.Parent.Y;
                }

                //if (childPanel.IsRotatedFlag)
                //{
                //    continue;
                //}
                //todo
                //childPanel = PanelRotate(childPanel, node);
                CalculateReferencePointToAllPanels(currentPanel);
            }
        }
    }
}
