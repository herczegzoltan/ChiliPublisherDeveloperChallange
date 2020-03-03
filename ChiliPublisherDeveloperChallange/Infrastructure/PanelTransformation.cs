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
            if (parentPanel.IsRotatedFlag)
            {

            }

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
}
