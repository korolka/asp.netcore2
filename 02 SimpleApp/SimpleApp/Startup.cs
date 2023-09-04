//Задание 1
//В приложении SampleApp, из первого домашнего задания. Добавьте в файл data.txt
//информацию о том, в какой категории находится товар.
//Модифицируйте контроллер Products таким образом, чтобы можно было через параметр в
//запросе получить на странице продукты в указанно категории.
//Например,
//localhost: 50234 / products / list – все продукты;
//localhost: 50234 / products / list / pc – все продукты, в категории pc;
//localhost: 50234 / products / list / office – все продукты, в категории office
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default2",
                    template: "{controller}/DetailsByCategory/{categoryName?}",
                     defaults: new { action = "DetailsByCategory", }
                     //constraints: new { categoryName = new StringRouteConstraint("{categoryName}") }
                     );

                routes.MapRoute(
                   name: "Default",
                   template: "{controller}/{action}/{id?}",
                   defaults: new {action = "details"},
                   constraints: new { id = new IntRouteConstraint() }
                   );
            });

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //       name: "Default",
            //       template: "{controller}/Details/{id?}",
            //       defaults: null,
            //       constraints: new { id = new IntRouteConstraint() }
            //       );
            //});



            // {id?} - данный фрагмент шаблона описывает не обязательный сегмент в адресе запроса.
            // При этом в контроллерах по имени id можно будет получить информацию, которая пришла в запросе
            // Products/Details/10
            // {controller} = Products
            // {action} = Details
            // {id} = 10
        }
    }
}
