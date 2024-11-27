using Microsoft.EntityFrameworkCore;
using TaskManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar banco de dados SQLite
builder.Services.AddDbContext<TaskContext>(options =>
    options.UseSqlite("Data Source=tasks.db"));

builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TaskContext>();
    context.Database.EnsureCreated();
}

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.MapGet("/", context =>
{
    context.Response.Redirect("/Tasks");
    return Task.CompletedTask;
});

app.Run();
