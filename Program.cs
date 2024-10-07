using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (This is equivalent to ConfigureServices in older versions)
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<TodoService>(); // Register the TodoService

var app = builder.Build();

// Configure the HTTP request pipeline. (This is equivalent to Configure in older versions)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=Index}/{id?}");

app.Run();
