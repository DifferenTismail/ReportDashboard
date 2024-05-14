using AutoMapper;
using ReportDashboard.DtoLayer.WriteQueryDto;
using ReportDashboard.EntityLayer.Entities;

namespace ReportDashboardAPI.Mapping
{
    public class WriteQueryMapping: Profile
    {
        public WriteQueryMapping()
        {
            CreateMap<WriteQuery, ResultWriteQueryDto>().ReverseMap();
            CreateMap<WriteQuery, CreateWriteQueryDto>().ReverseMap();
            CreateMap<WriteQuery, GetWriteQueryDto>().ReverseMap();
            CreateMap<WriteQuery, UpdateWriteQueryDto>().ReverseMap();
        }
    }
}
