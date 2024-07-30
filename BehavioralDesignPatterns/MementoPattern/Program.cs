// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

// app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }

using MementoPattern;

var employee = new Employee {Id =1, Name = "Employee", Age = 25, Phone = "123"};
var employeeManager = new EmployeeManager();

employeeManager.AddMemento(1, employee.Create());

Console.WriteLine($"Initial State: {employee.Name}, {employee.Age}, {employee.Phone}");

employee.Phone = "34567";
employeeManager.AddMemento(1, employee.Create());
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");

employee.Age = 35;
employeeManager.AddMemento(1, employee.Create());
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");

employee.Undo(employeeManager.GetMemento(1));
employee.Undo(employeeManager.GetMemento(1));
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");

employee.Undo(employeeManager.GetMemento(1));
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");