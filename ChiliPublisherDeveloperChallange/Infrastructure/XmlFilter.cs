using ChiliPublisherDeveloperChallange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class XmlFilter
    {
        public static List<string> GetAllPanelNames(RootObject rootObject)
        {

            IEnumerable<String> listOfPanel = rootObject.Panels.PanelsItem.AttachedPanelsItems.AttachedPanelsItem.Select(x => x.PanelName);


            foreach (var level2 in rootObject.Panels.PanelsItem.AttachedPanelsItems.AttachedPanelsItem)
            {
                var items = level2.AttachedPanelsItems.AttachedPanelsItem
                    .Select(l3 => l3.AttachedPanelsItems)
                    .Select(l4 => l4.AttachedPanelsItem);

            };

            return new List<string>();
        }

    }
}
