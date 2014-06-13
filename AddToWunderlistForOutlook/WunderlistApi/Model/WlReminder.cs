using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddToWunderlistForOutlook.WunderlistApi.Model
{
    public class WlReminder
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string User_Id { get; set; }
        public string Task_Id { get; set; }

    }
}
