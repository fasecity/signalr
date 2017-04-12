using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalrPractice.Startup))]
namespace SignalrPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
            //adding signal r to staratup 
           
        }
    }
}
