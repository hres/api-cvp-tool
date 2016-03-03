using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using cvpToolApi.Models;

namespace cvpToolApi.Controllers
{
    public class AdverseReactionReportController : ApiController
    {
        static readonly IAdverseReactionReportRepository databasePlaceholder = new AdverseReactionReportRepository();

        public IEnumerable<AdversReactionReport> GetAllReport()
        {

            return databasePlaceholder.GetAll();
        }


        public AdversReactionReport GetReportByID(int id)
        {
            AdversReactionReport report = databasePlaceholder.Get(id);
            if (report == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return report;
        }


        public IEnumerable<AdversReactionReport> GetReportByDrugName(string drugName)
        {
            return databasePlaceholder.Get(drugName);
        }
        
    }
}
