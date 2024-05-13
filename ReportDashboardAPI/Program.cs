using ReportDashboard.BusinessLayer.Abstarct;
using ReportDashboard.BusinessLayer.Concrete;
using ReportDashboard.DataAccessLayer.Abstract;
using ReportDashboard.DataAccessLayer.Concrete;
using ReportDashboard.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ReportDashboardContext>();

builder.Services.AddScoped<IReportService, ReportManager>();
builder.Services.AddScoped<IReportDal, EfReportDal>();

builder.Services.AddScoped<IDbTableService, DbTableManager>();
builder.Services.AddScoped<IDbTableDal, EfDbTableDal>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
