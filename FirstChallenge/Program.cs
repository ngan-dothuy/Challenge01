using System.ComponentModel;
using FirstChallenge.CategoryDto;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<CategoryDto> categories = [
    new (1, "Category 01"),
    new (2, "Category 02"),
    new (3, "Category 03"),
    new (4, "Category 04"),
    new (5, "Category 05")

];

app.MapGet("/categories", () => categories);

app.Run();
