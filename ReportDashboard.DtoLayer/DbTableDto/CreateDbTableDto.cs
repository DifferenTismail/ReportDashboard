using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DtoLayer.DbTableDto
{
    public class CreateDbTableDto
    {
        public string DbTable_ServerName { get; set; }
        public string? DbTable_UserName { get; set; }
        public string? DbTable_Password { get; set; }
    }
}
