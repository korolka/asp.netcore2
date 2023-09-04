//�������
//�������� ��� ����������, ������� ����� ������������ ��������� �������:
//Calc / Add / 20 / 20 ��������� �������� � ���������� �������� 30;
//Calc / Mul / 20 / 10 ��������� ��������� � ���������� �������� 200;
//Calc / Div / 20 / 10 ��������� �������� � ���������� �������� 2;
//Calc / Sub / 20 / 10 ��������� ��������� � ���������� �������� 10.
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