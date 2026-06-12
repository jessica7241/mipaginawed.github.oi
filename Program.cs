var builder = WebApplication.CreateBuilder(args);

// Agregar Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Mapear Razor Pages
app.MapRazorPages();

app.Run();