using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResponsiveMeetingSearch.Data.ViewModels;


namespace ResponsiveMeetingSearch.Data
{
   public class SearchRepository : ISearchRepository
    {
        public List<MeetingVM> RadiusMeetingSearch(int radiusInMiles, decimal latitude, decimal longitude, int DayOfWeek)
        {
            using (meetingDBDataContext context = new meetingDBDataContext())
            {              
                var meetings = context.RadiusSearch(latitude,longitude, radiusInMiles, DayOfWeek);
                return new List<MeetingVM>(); // <-- remove , just to compile
            }
        }
    }
}
