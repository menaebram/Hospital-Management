using Hospital_Management.Models;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);


var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{
    var frontendURL = configuration.GetValue<string>("frontend_url");

    options.AddDefaultPolicy(builder =>
    {
        Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder corsPolicyBuilder = builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader();
    });
});


// DbContext
builder.Services.AddDbContext<HospitalDbContext>(options =>
{
    var con = builder.Configuration.GetConnectionString("con");
    options.UseSqlServer(con);
});

builder.Services.AddDefaultIdentity<AppUsers>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<HospitalDbContext>();

// Add services to the container.

builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
    .AddNegotiate();

builder.Services.AddRazorPages();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.MapRazorPages();

app.UseStaticFiles();


app.UseRouting();
app.UseCors();
app.UseAuthentication(); // Ensure this is before UseAuthorization
app.UseAuthorization();


// Redirect root URL to the login page
app.MapGet("/", context =>
{
    context.Response.Redirect("Identity/Account/Login");
    return Task.CompletedTask;
});

app.Run();
