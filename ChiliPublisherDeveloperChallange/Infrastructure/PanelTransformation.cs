using ChiliPublisherDeveloperChallange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class PanelTransformation
    {
        public static List<CustomPanel> RotatePanels(List<CustomPanel> cusomPanels)
        {

            return new List<CustomPanel>();
        }
        private void PanelRotate(CustomPanel currentChildPanel, CustomPanel parentPanel)
        {

            if (currentChildPanel.AT != null)
            {
                switch (currentChildPanel.AT)
                {
                    case "0":
                        currentChildPanel.RotationState = RotationState.none;
                        break;
                    case "1":
                        currentChildPanel.RotationState = RotationState.once;
                        break;
                    case "2":
                        currentChildPanel.RotationState = RotationState.twice;
                        break;
                    case "3":
                        currentChildPanel.RotationState = RotationState.thrice;
                        break;
                    default:
                        break;
                }
            }
        }
        //   ---------
        //   |   2   |
        //   |3     1|
        //   |   0   |
        //   ---------

        //rotation with 90 degree clockwise
        private void PanelRotateHelper(CustomPanel currentChildPanel, CustomPanel parentPanel)
        {
            if (parentPanel.IsRotatedFlag)
            {
                if (parentPanel.RotationState == RotationState.none)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.twice;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.once;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.none;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.thrice;
                            break;
                        default:
                            break;
                    }
                }
                if (parentPanel.RotationState == RotationState.once)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.thrice;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.twice;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.once;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.none;
                            break;
                        default:
                            break;
                    }
                }
                if (parentPanel.RotationState == RotationState.twice)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.none;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.thrice;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.twice;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.once;
                            break;
                        default:
                            break;
                    }
                }
                if (parentPanel.RotationState == RotationState.thrice)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.once;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.none;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.thrice;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.twice;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
