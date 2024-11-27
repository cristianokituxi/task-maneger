using Microsoft.EntityFrameworkCore;
using TaskManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar banco de dados SQLite
builder.Services.AddDbContext<TaskContext>(options =>
    options.UseSqlite("Data Source=tasks.db"));

builder.Services.AddRazorPages();

var app = builder.Build();

// Criar banco de dados automaticamente
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TaskContext>();
    context.Database.EnsureCreated();
}

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
