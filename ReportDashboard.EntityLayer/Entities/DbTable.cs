using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.EntityLayer.Entities
{
    public class DbTable
    {
        [Key]
        public int DbTableID { get; set; }
        public string DbTable_ServerName { get; set; }
        public string DbTable_Database {  get; set; }
        public string? DbTable_UserName { get; set; }
        public string? DbTable_Password { get; set; }
        public List<Report> Reports { get; set; }
        public List<WriteQuery> WriteQueries { get; set; }
    }
}
