# utworzenie projektu 
```console

dotnet new web -o NazwaProjektu
```
# Możliwość obsługi plików stycnych
1. Utworzyć katalog wwwroot
2. Dodać do Program.cs
```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();

```

3. Dodać katalog Pages i w nim dodać nową stronę RazorPage
```console

dotnet new page -n Index
```
4. Dodać do Pages viewimports  aby korzystać z tag helperów
```console
dotnet new viewimports
```