using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddViewLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddRequestLocalization(options =>
{
    options.SupportedCultures = new[]
    {
        new CultureInfo("en"),
        new CultureInfo("nl"),
        new CultureInfo("fr")
    };


    options.SupportedUICultures = options.SupportedCultures;

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRequestLocalization();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
