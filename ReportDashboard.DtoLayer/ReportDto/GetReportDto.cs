using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DtoLayer.ReportDto
{
    public class GetReportDto
    {
        [Key]
        public int ReportID { get; set; }
        public string ReportName { get; set; }
    }
}
