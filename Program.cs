using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ToDoDb>(opt => opt.UseInMemoryDatabase("ToDoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ToDo API",
        Description = "API for managing a list of ToDos and their task status.",
    });
});
var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<ToDoDb>();
    dbContext.Database.EnsureCreated();
}

 app.MapGet("/ToDolist",  async (ToDoDb db) =>
    await db.ToDos.ToListAsync())
    .WithTags("Get all ToDo"); 

app.MapGet("/ToDolist/Completed", async (ToDoDb db) =>
    await db.ToDos.Where(t => t.Completed).ToListAsync())
    .WithTags("Get all completed ToDo list items");

app.MapGet("/ToDolist/{id}", async (int id, ToDoDb db) =>
    await db.ToDos.FindAsync(id)
        is ToDo ToDo
            ? Results.Ok(ToDo)
            : Results.NotFound())
    .WithTags("Get ToDo by Id");

app.MapPost("/ToDolist", async (ToDo ToDo, ToDoDb db) =>
{
    db.ToDos.Add(ToDo);
    await db.SaveChangesAsync();

    return Results.Created($"/ToDolist/{ToDo.Id}", ToDo);
})
    .WithTags("Add ToDo to list");

app.MapPut("/ToDolist/{id}", async (int id, ToDo inputToDo, ToDoDb db) =>
{
    var ToDo = await db.ToDos.FindAsync(id);

    if (ToDo is null) return Results.NotFound();

    ToDo.TaskName = inputToDo.TaskName;
    ToDo.Completed = inputToDo.Completed;

    await db.SaveChangesAsync();

    return Results.NoContent();
})
    .WithTags("Update ToDo by Id");

app.MapDelete("/ToDolist/{id}", async (int id, ToDoDb db) =>
{
    if (await db.ToDos.FindAsync(id) is ToDo ToDo)
    {
        db.ToDos.Remove(ToDo);
        await db.SaveChangesAsync();
        return Results.Ok(ToDo);
    }

    return Results.NotFound();
})
    .WithTags("Delete ToDo by Id");


app.UseSwagger();
app.UseSwaggerUI();


app.Run();