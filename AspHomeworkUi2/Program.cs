//Задание
//Создайте веб приложение, которое будет обрабатывать следующие запросы:
//Calc / Add / 20 / 20 выполняет сложение и возвращает значение 30;
//Calc / Mul / 20 / 10 выполняет умножение и возвращает значение 200;
//Calc / Div / 20 / 10 выполняет сложение и возвращает значение 2;
//Calc / Sub / 20 / 10 выполняет вычитание и возвращает значение 10.
using Microsoft.AspNetCore.SignalR;

namespace AspHomeworkUi2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller}/{action}/{x:int}/{y:int}");

                endpoints.MapControllerRoute(name: "default2", pattern: "{controller=home}/{action=index}");
            });

            app.Run();
        }
    }
}