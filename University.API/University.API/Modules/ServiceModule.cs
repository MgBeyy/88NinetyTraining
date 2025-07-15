using Autofac;
using University.Core.Services;
using University.Core.Services.Interfaces;

namespace University.API.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentService>()
                .As<IStudentService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseService>()
                .As<ICourseService>()
                .InstancePerLifetimeScope();
        }

    }
}
