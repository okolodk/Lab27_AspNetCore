var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>  "Привет от ИСП-234! Автор: Григорий");

app.Run();
