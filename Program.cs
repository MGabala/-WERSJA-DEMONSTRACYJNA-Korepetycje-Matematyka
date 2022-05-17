
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddDbContext<DbContextAccount>(db_config => db_config.UseSqlite(builder.Configuration["ConnectionStrings:AccountsDB"]));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DbContextAccount>();
builder.Services.Configure<IdentityOptions>(config => {
    config.Password.RequiredLength = 6;
    config.Password.RequireNonAlphanumeric = false;
    config.Password.RequireLowercase = false;
    config.Password.RequireUppercase = false;
    config.Password.RequireDigit = false;
});
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<ITerminyRepository, TerminyRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//HttpLogging -> show logs in console
app.UseHttpLogging();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
