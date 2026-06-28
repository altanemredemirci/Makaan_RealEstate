using Makaan_BLL.Abstract;
using Makaan_BLL.Concrete;
using Makaan_DAL.Abstract;
using Makaan_DAL.Concrete.EfCore;
using Makaan_UI.Mapping;

namespace Makaan_UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAutoMapper(typeof(MapProfile));


            //Dependency Injection - Bağımlılık Yönetimi
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProductDal, EfCoreProductDal>();

            builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
            builder.Services.AddScoped<IProductTypeDal, EfCoreProductTypeDal>();

            builder.Services.AddScoped<ISliderService, SliderService>();
            builder.Services.AddScoped<ISliderDal, EfCoreSliderDal>();


            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
