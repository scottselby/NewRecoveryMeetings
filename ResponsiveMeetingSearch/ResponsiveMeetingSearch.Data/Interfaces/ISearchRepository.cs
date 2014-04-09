using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResponsiveMeetingSearch.Data.ViewModels;

namespace ResponsiveMeetingSearch.Data
{
   public interface ISearchRepository
    {
        List<MeetingVM> RadiusMeetingSearch(int radiusInMiles, decimal latitude, decimal longitude, int DayOfWeek);
    }
}
