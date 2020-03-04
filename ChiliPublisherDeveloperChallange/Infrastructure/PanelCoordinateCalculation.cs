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


                if (currentPanel.AT == "0" &&
                   currentPanel.Parent.RotationState == RotationState.none &&
                   currentPanel.RotationState == RotationState.twice
                   ||
                   currentPanel.AT == "1" &&
                   currentPanel.Parent.RotationState == RotationState.once &&
                   currentPanel.RotationState == RotationState.twice
                   )
                {
                    //string tempVal = currentPanel.Width;
                    //currentPanel.Width = currentPanel.Hight;
                    //currentPanel.Hight = tempVal;

                    currentPanel.X = currentPanel.Parent.X;
                    currentPanel.Y = currentPanel.Parent.Y + Converters.DoubleStringToIntWithRound(currentPanel.Parent.Hight);
                }

                if (currentPanel.AT == "1" &&
                    currentPanel.Parent.RotationState == RotationState.none &&
                    currentPanel.RotationState == RotationState.once
                    ||
                    currentPanel.AT == "2" &&
                    currentPanel.Parent.RotationState == RotationState.once &&
                    currentPanel.RotationState == RotationState.once
                    )
                {
                    string tempVal = currentPanel.Width;
                    currentPanel.Width = currentPanel.Hight;
                    currentPanel.Hight = tempVal;

                    currentPanel.X = currentPanel.Parent.X + Converters.DoubleStringToIntWithRound(currentPanel.Parent.Width);
                    currentPanel.Y = currentPanel.Parent.Y;
                }


               


                if (currentPanel.AT == "2" &&
                    currentPanel.Parent.RotationState == RotationState.none &&
                    currentPanel.RotationState == RotationState.none
                    ||
                    currentPanel.AT == "1" &&
                    currentPanel.Parent.RotationState == RotationState.thrice &&
                    currentPanel.RotationState == RotationState.none

                    )
                {
                    //string tempVal = currentPanel.Width;
                    //currentPanel.Width = currentPanel.Hight;
                    //currentPanel.Hight = tempVal;

                    currentPanel.X = currentPanel.Parent.X;
                    currentPanel.Y = currentPanel.Parent.Y - Converters.DoubleStringToIntWithRound(currentPanel.Hight);
                }


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

                if (currentPanel.AT == "3" &&
                  currentPanel.Parent.RotationState == RotationState.once &&
                  currentPanel.RotationState == RotationState.none
                  ||
                  currentPanel.AT == "2" &&
                  currentPanel.Parent.RotationState == RotationState.none &&
                  currentPanel.RotationState == RotationState.none
                  )
                {
                    //string tempVal = currentPanel.Width;
                    //currentPanel.Width = currentPanel.Hight;
                    //currentPanel.Hight = tempVal;

                    currentPanel.X = currentPanel.Parent.X;
                    currentPanel.Y = currentPanel.Parent.Y - Converters.DoubleStringToIntWithRound(currentPanel.Hight);
                }

                if (currentPanel.AT == "3" &&
                 currentPanel.Parent.RotationState == RotationState.thrice &&
                 currentPanel.RotationState == RotationState.twice)
                {
                    //string tempVal = currentPanel.Width;
                    //currentPanel.Width = currentPanel.Hight;
                    //currentPanel.Hight = tempVal;

                    currentPanel.X = currentPanel.Parent.X;
                    currentPanel.Y = currentPanel.Parent.Y + Converters.DoubleStringToIntWithRound(currentPanel.Parent.Hight);
                }



                CalculateReferencePointToAllPanels(currentPanel);
            }
        }
    }
}
