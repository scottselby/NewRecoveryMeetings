using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResponsiveMeetingSearch.Data;
using ResponsiveMeetingSearch.Data.ViewModels;

namespace ResponsiveMeetingSearch.Controllers
{
    public class AjaxController : Controller
    {
        #region Constructors
        private ISearchRepository searchRepository;

        public AjaxController(ISearchRepository searchRepository)
        {
            this.searchRepository = searchRepository;
        }
        #endregion

        public ActionResult RadiusMeetingSearch(int radiusInMiles, decimal latitude, decimal longitude, int DayOfWeek)
        {
            List<MeetingVM> meetingList = new List<MeetingVM>();
            meetingList = this.searchRepository.RadiusMeetingSearch(radiusInMiles, latitude, longitude, DayOfWeek);
            return this.Json("Fuck You Biotch!!");  // <-- remove mo fucka
        }
    }
}
