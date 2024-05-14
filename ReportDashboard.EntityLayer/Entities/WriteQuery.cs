using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.EntityLayer.Entities
{
    public class WriteQuery
    {
        [Key]
        public int WriteQueryID { get; set; }
        public string Query { get; set; }
        public int? DbTableID { get; set; }
        public DbTable DbTable { get; set; }
    }
}
