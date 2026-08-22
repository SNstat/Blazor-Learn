using Blazor_Learn.Business.Services;
using Blazor_Learn.Components;
using Blazor_Learn.Data;
using Blazor_Learn.Models.DataBrowser;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionStringEfTest = builder.Configuration.GetConnectionString("EfTestDb");

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<DataService>();
builder.Services.AddTransient<CustomerService>();

builder.Services.AddDbContextFactory<AppDbContext>(options => 
    options.UseSqlite(connectionStringEfTest));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
