using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DtoLayer.WriteQueryDto
{
    public class ResultWriteQueryWithDbTable
    {
        [Key]
        public int WriteQueryID { get; set; }
        public string Query { get; set; }
        public string? DbTable_UserName { get; set; }
    }
}
