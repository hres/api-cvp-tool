using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvpToolApi.Models
{
    interface IAdverseReactionReportRepository
    {
        IEnumerable<AdversReactionReport> GetAll();
        AdversReactionReport Get(int id);
        IEnumerable<AdversReactionReport> Get(string drugName);
    }
}
