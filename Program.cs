using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// サービス登録
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews(); // ← これだけでいい！

var app = builder.Build();

// パイプライン設定
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ★ポイント：RazorPagesをマッピングしない！
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Top}/{action=Index}/{id?}");

// app.MapRazorPages(); ← コメントアウトまたは削除！

app.Run();
