using Microsoft.EntityFrameworkCore;
using MinimalApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoDb>
    (opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();
app.MapGet("/todoitems", async (TodoDb db) => await db.Todos.ToListAsync());

app.MapPost("/todoitems", async (Todo todo, TodoDb db) => {
    db.Todos.Add(todo);
    await db.SaveChangesAsync();
    return Results.Created($"/todoitems/{todo.Id}", todo);
});
app.MapGet("/", () => "Hello World!");

app.Run();
