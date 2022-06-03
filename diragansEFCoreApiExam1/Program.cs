using Microsoft.EntityFrameworkCore;
using diragansEFCoreApiExam1.Repository;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<LinkContext>(options => 
//options.UseSqlServer(builder.Configuration.GetConnectionString("LocalMSSqlConnection")));
options.UseSqlServer(builder.Configuration.GetConnectionString("AzureDbConnection")));

builder.Services.AddScoped<IProductRepository,ProductRepository>();


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
