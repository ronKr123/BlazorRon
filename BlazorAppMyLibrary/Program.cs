using BlazorAppMyLibrary;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ApiLibraryService.ApiService>();
builder.Services.AddScoped<Filter>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<MangerService>();
builder.Services.AddSingleton<FileService>();
builder.Services.AddSingleton<Filter>();



var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapBlazorHub();
    endpoints.MapFallbackToPage("/_Host");
});

app.Run();
