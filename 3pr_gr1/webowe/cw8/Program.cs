var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseStaticFiles();
// string name = "Ala ma kota";
// app.MapGet("/", () => $"<p>Hello World! {name}</p>");
// app.MapGet("/info",()=>$"Dzisiaj mamy : {DateTime.Now}");
// app.MapGet("/student",()=>$"Adam Nowak : 4T");
app.MapRazorPages();

app.Run();
