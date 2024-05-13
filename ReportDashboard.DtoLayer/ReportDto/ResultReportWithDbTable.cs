using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DtoLayer.ReportDto
{
    public class ResultReportWithDbTable
    {
        [Key]
        public int ReportID { get; set; }
        public string ReportName { get; set; }
        public string? DbTable_UserName { get; set; }
    }
}
