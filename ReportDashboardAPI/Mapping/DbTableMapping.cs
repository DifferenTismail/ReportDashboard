using AutoMapper;
using ReportDashboard.DtoLayer.DbTableDto;
using ReportDashboard.EntityLayer.Entities;

namespace ReportDashboardAPI.Mapping
{
    public class DbTableMapping :Profile
    {
        public DbTableMapping()
        {
            CreateMap<DbTable, ResultDbTableDto>().ReverseMap();
            CreateMap<DbTable, CreateDbTableDto>().ReverseMap();
            CreateMap<DbTable, GetDbTableDto>().ReverseMap();
            CreateMap<DbTable, UpdateDbTableDto>().ReverseMap();
        }
    }
}
