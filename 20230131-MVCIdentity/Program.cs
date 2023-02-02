using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Services;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.Configure<IdentityOptions>(options =>
{
    //Password Settings
    //options.Password.RequireDigit = true;
    //options.Password.RequireNonAlphanumeric = true;
    //options.Password.RequireLowercase = true;
    //options.Password.RequireUppercase = true;
    //options.Password.RequiredLength = 6;
    //options.Password.RequiredUniqueChars = 1;

    //Lockout settings
    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    //options.Lockout.MaxFailedAccessAttempts = 5;

    //User settings
    options.User.RequireUniqueEmail = true;
    //options.User.AllowedUserNameCharacters = "abc";

});
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("IsAdmin", policy => policy.RequireClaim("IsAdmin", "true"));
});
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

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
app.UseAuthentication(); 

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
