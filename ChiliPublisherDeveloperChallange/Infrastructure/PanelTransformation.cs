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
        public static List<CustomPanel> RotatePanels(List<CustomPanel> customPanels)
        {
            MappingOneChild(customPanels[0]);

            return customPanels;
        }

        private static void MappingOneChild(CustomPanel node)
        {

            for (int i = 0; i < node.ChildPanels.Count; i++)
            {
                CustomPanel childPanel = node.ChildPanels[i];

                if (childPanel.IsRotatedFlag)
                {
                    continue;
                }

                childPanel = PanelRotate(childPanel, node);
                MappingOneChild(childPanel);
            }
        }

        //   ---------
        //   |   2   |
        //   |3     1|
        //   |   0   |
        //   ---------
        //rotation with 90 degree clockwise
        private static CustomPanel PanelRotate(CustomPanel currentChildPanel, CustomPanel parentPanel)
        {
           if (parentPanel.IsRotatedFlag)
            {
                if (parentPanel.RotationState == RotationState.none)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.twice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.once;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.none;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.thrice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        default:
                            break;
                    }
                    return currentChildPanel;
                }


                if (parentPanel.RotationState == RotationState.once)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.thrice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.twice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.once;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.none;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        default:
                            break;
                    }

                    return currentChildPanel;
                }
                if (parentPanel.RotationState == RotationState.twice)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.none;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.thrice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.twice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.once;
                            currentChildPanel.IsRotatedFlag = true; 
                            break;
                        default:
                            break;
                    }
                    return currentChildPanel;
                }
                if (parentPanel.RotationState == RotationState.thrice)
                {
                    switch (currentChildPanel.AT)
                    {
                        case "0":
                            currentChildPanel.RotationState = RotationState.once;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "1":
                            currentChildPanel.RotationState = RotationState.none;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "2":
                            currentChildPanel.RotationState = RotationState.thrice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        case "3":
                            currentChildPanel.RotationState = RotationState.twice;
                            currentChildPanel.IsRotatedFlag = true;
                            break;
                        default:
                            break;
                    }
                    return currentChildPanel;
                }

                return currentChildPanel;
            }
            else
            {
                 return currentChildPanel;
            }
        }
    }
}
