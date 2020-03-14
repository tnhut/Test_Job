using Microsoft.Owin;
using Owin;
using Test_Job.Jobs;

[assembly: OwinStartupAttribute(typeof(Test_Job.Startup))]
namespace Test_Job
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            JobScheduler.Start();
        }
    }
}
