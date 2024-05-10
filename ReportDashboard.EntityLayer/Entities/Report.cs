using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.EntityLayer.Entities
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        public string ReportName { get; set; }
    }
}
