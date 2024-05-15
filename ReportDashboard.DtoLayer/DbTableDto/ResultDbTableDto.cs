using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DtoLayer.DbTableDto
{
    public class ResultDbTableDto
    {
        [Key]
        public int DbTableID { get; set; }
        public string DbTable_ServerName { get; set; }
        public string DBMS_Name { get; set; }
        public string DbTable_Database { get; set; }
        public string? DbTable_UserName { get; set; }
        public string? DbTable_Password { get; set; }
    }
}
