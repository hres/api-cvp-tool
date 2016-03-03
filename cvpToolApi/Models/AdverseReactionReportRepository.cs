using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cvp;
namespace cvpToolApi.Models
{
    public class AdverseReactionReportRepository : IAdverseReactionReportRepository
    {
        // We are using the list and _fakeDatabaseID to represent what would
        // most likely be a database of some sort, with an auto-incrementing ID field:
        private List<AdversReactionReport> _reports = new List<AdversReactionReport>();
        private AdversReactionReport _report = new AdversReactionReport();
        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AdversReactionReport> GetAll()
        {
            _reports = null; // dbConnection.GetAllReport();

            return _reports;
        }


        public AdversReactionReport Get(int id)
        {
            _report = null; //dbConnection.GetReportById(id);
            return _report;
        }

        public IEnumerable<AdversReactionReport> Get(string drugName)
        {
           
            _reports = dbConnection.GetAEExportReportByDrugName(drugName);
            return _reports;
        }


    }
}