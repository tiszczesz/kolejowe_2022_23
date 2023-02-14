using Microsoft.EntityFrameworkCore;
using MinimalApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoDb>
    (opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();
app.MapGet("/todoitems", async (TodoDb db) =>
{
    db.Database.EnsureCreated();
    var todos = await db.Todos.ToListAsync();
    // if (todos.Count == 0)
    // {
    //     db.Todos.Add(new Todo { Id = 1, Name = "Wyjść z psem", IsComplete = false });
    //     db.Todos.Add(new Todo { Id = 2, Name = "Inna czynność", IsComplete = false });
    //     db.Todos.Add(new Todo { Id = 3, Name = "Rybki nakarmić", IsComplete = false });
    //     db.Todos.Add(new Todo { Id = 4, Name = "Dobrze zjeść", IsComplete = false });
    //     db.SaveChanges();
    //     todos = await db.Todos.ToListAsync();
    // }
    return todos;
});

app.MapPost("/todoitems", async (Todo todo, TodoDb db) =>
{
    db.Todos.Add(todo);
    await db.SaveChangesAsync();
    return Results.Created($"/todoitems/{todo.Id}", todo);
});
app.MapGet("/", () => "Hello World!");

app.Run();
