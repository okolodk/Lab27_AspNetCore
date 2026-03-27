var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>  "Добро пожаловать на сервер.");

app.MapGet("/about", () => "Это мой первый ASP.NET Core  сервер");

app.MapGet("/time", ()=> $"Время на сервере: {DateTime.Now}");

app.MapGet("/hello/{name}", (string name) => $"Hello, {name}!");

app.MapGet("/sum/{a}/{b}", (int a, int b) => $"Sum = {a + b}");

app.MapGet("/student", () => new {
    Name = "Алексеев Григорий",
    Group = "ISP-232",
    Year = 3,
    IsActive = true
});

app.MapGet("/subjects", () => new[] {
    "RPM",
    "RMP",
    "ISRPO",
    "SP",
});

app.MapGet("/product/{id}", (int id) => new Product(
    Id: id,
    Name: $"Товар #{id}",
    Price: id * 99.99m,
    InStock: id % 2 == 0
));
app.Run();

record Product(int Id, string Name, decimal Price, bool InStock);