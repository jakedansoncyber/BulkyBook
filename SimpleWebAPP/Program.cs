using SimpleWebAPP.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add service for sql db 
// Needed to go to tools>nuget package mgr > console and type:
// add-migration {name} ex: add-migration AddCategoryToDatabase
// This created the migrations folder with two cs files pre-written for us
// Then we type in: update-database which will push migrations we created to database
// Make sure appsettings.json has correct connection string syntax.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("SqlServer")
    ));
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    // If nothing is provided then it should go to the home controller and call
    // the action method of Index.
    // Below is the URL https://localhost.com:{portnumber}/{controller}/{action}/{id}
    // https://localhost:{portnumber}/Category -> will default to index
    // https://localhost:{portnumber}/Product/Details/3 -> will go to Product
    // and do an action called details
    name: "default", 
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
