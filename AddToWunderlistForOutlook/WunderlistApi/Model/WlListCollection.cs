using System;
using System.Collections.Generic;

namespace AddToWunderlistForOutlook.WunderlistApi.Model
{
    public class WlListCollection : List<WlList>
    {
        public new void Sort()
        {
            Sort((list, wlList) => String.Compare(list.Title, wlList.Title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
