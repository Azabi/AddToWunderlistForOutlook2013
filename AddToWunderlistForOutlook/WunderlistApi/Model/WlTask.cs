using System;

namespace AddToWunderlistForOutlook.WunderlistApi.Model
{
    public class WlTask
    {
        public string Id { get; set; }
        public DateTime? Completed_At { get; set; }
        public bool Starred { get; set; }
        public string Title { get; set; }
        public string List_Id { get; set; }
        public string Note { get; set; }
        public string Parent_Id { get; set; }
        public DateTime? Due_Date { get; set; }
        public int Recurring_Count { get; set; }
        public RecurringType Recurring_Type { get; set; }

    }

    public enum RecurringType
    {
        Day,
        Week,
        Month,
        Year
    }
}
