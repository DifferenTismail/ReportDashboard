using AutoMapper;
using ReportDashboard.EntityLayer.Entities;
using ReportDashboard.DtoLayer.ReportDto;

namespace ReportDashboardAPI.Mapping
{
    public class ReportMapping: Profile
    {
        public ReportMapping()
        {
            CreateMap<Report, ResultReportDto>().ReverseMap();
            CreateMap<Report, CreateReportDto>().ReverseMap();
            CreateMap<Report, GetReportDto>().ReverseMap();
            CreateMap<Report, UpdateReportDto>().ReverseMap();
        }
    }
}
